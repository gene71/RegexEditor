using CR.Core;
using CR.Core.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegexEditor
{
    public partial class RegexEditorForm : Form
    {
        CRScanner crs;
        public static string fileSavePath;
        public RegexEditorForm()
        {
            InitializeComponent();
            infotextBox.Visible = false;//default view for infotextbox
            crs = new CRScanner();
            fileSavePath = "";
           
        }
 
        /// <summary>
        /// lineNumbersToolStripMenuItem_Click handles the line numbers and view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lineNumbersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Disabled because there are development issues with adding line numbers
            if (lineNumbersToolStripMenuItem.Checked)
            {
                lineNumbersToolStripMenuItem.Checked = false;
                //remove line numbers
                infotextBox.Visible = false;
                return;
            }

            //if(!lineNumbersToolStripMenuItem.Checked)
            {
                lineNumbersToolStripMenuItem.Checked = true;
                //do something else
                infotextBox.Visible = true;
                return;
            }
        }


        private void infoTextBoxUpdate()
        {
            int line = richTextBox1.GetLineFromCharIndex(richTextBox1.SelectionStart);
            line++;//account for 0 to 1 conversion from array
            
            StringBuilder sb = new StringBuilder();
            foreach (var fex in crs.FileExtensions)
            {
                sb.AppendFormat("{0},", fex);
            }

            infotextBox.Text = "Line: " + line.ToString() + 
                "\tScanner file associations: " + sb.ToString() +
                "\tfile: " + fileSavePath + "\tScanner name: " + crs.Name;

        }
        /// <summary>
        /// Calls infoTextBoxUpdate to update status on infoTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void richTextBox1_Click(object sender, EventArgs e)
        {
            infoTextBoxUpdate();
        }

        /// <summary>
        /// Calls infoTextBoxUpdate to update status on infoTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void richTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            infoTextBoxUpdate();
           
        }


        private void getMatch()
        {
           
            try
            {
                richTextBox1.SelectAll();
                richTextBox1.SelectionBackColor = Color.White;
                //infoTextBoxUpdate(Regex.Matches(richTextBox1.Text, textBox1.Text).Count);
                foreach (Match m in Regex.Matches(richTextBox1.Text, comboBox1.Text))
                {
                    richTextBox1.Select(m.Index, m.Length);
                    richTextBox1.SelectionBackColor = Color.Aqua;
                    
                }
            }
            catch
            {
               //does nothing to allow a match for partial regex
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            getMatch();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            getMatch();
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            //update combox
            foreach(var p in crs.Patterns)
            {
                if(!comboBox1.Items.Contains(p))
                {
                    comboBox1.Items.Add(p);
                }
            }
            getMatch();
        }

        private void addPatternToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text != "" && !comboBox1.Items.Contains(comboBox1.Text))
            {
                comboBox1.Items.Add(comboBox1.Text);
                //add it to object
                if (!crs.Patterns.Contains(comboBox1.Text))
                {
                    crs.Patterns.Add(comboBox1.Text);
                }

                MessageBox.Show(comboBox1.Text +
                    " added to scanner! ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBox1.Text = "";
            }
        }

        private void removePatternToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && comboBox1.Items.Contains(comboBox1.Text))
            {
                //first remove from object
                if (crs.Patterns.Contains(comboBox1.Text))
                {
                    crs.Patterns.Remove(comboBox1.Text);
                }
                comboBox1.Items.Remove(comboBox1.Text);
               
                MessageBox.Show(comboBox1.Text +
                    " removed from scanner! ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBox1.Text = "";
            }
        }
        /// <summary>
        /// This handler starts a dialog to scan an entire directory using the current scanner
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quickScanToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            crs.CRVID = "000000";//test id
            foreach (var p in comboBox1.Items)
            {
                crs.Patterns.Add(p.ToString());
            }


            if (crs.Patterns.Count < 1)
            {
                MessageBox.Show("you must have at least one pattern ", "Warning"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (crs.FileExtensions.Count < 1)
            {
                MessageBox.Show("you must have at least one file association ", "Warning"
                   , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //do scan here
                ScanEngine se = new ScanEngine();
                try
                {
                    DialogResult result = folderBrowserDialog1.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        var vuls = se.GetVuls(folderBrowserDialog1.SelectedPath, crs);
                        //create the output
                        StringBuilder sb = new StringBuilder();
                        foreach (var v in vuls)
                        {
                            sb.AppendFormat("{0}\n", v);
                        }
                        richTextBox1.Text = "";
                        richTextBox1.Text = sb.ToString();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error"
                   , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// This handler opens any file to display in the text editor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" error opening file " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        /// <summary>
        /// Calls the dependency checker for 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cSProjectRefScanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = folderBrowserDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    StringBuilder sb = new StringBuilder();
                    
                    var refs = CSRefScanner.ProjectReferences(folderBrowserDialog1.SelectedPath);
                    foreach(var l in refs)
                    {
                        //first list project files
                        if (l.Contains("Project"))
                        {
                            sb.AppendFormat("{0}\n", l);
                        }

                        
                    }
                    foreach (var l in refs)
                    {
                        //then list refs
                        if (!l.Contains("Project"))
                        {
                            sb.AppendFormat("{0}\n", l);
                        }


                    }

                    richTextBox1.Text = "";//clear text
                    richTextBox1.Text = sb.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" error parsing refs\n" + ex.Message, "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void addFileExtensionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileExtForm fef = new FileExtForm(crs);
            fef.Show();
        
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileSavePath == "")
            {
                //call save as
                saveAsToolStripMenuItem_Click(this, null);
            }
            else
            {
                try
                {
                    //do save to fileSavePath
                    CRObjSerializer cros = new CRObjSerializer();
                    cros.SaveCRObj(fileSavePath, crs);
                    MessageBox.Show("File saved to: " + fileSavePath, "Info",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (crs.Patterns.Count < 1)
                {
                    MessageBox.Show("Scanner must contain at least one pattern", "Warning"
                 , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (crs.FileExtensions.Count < 1)
                {
                    MessageBox.Show("Scanner must contain at least one file association", "Warning"
                 , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    ScannerSaveForm ssf = new ScannerSaveForm(crs);
                    ssf.Show();
                }
               
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error"
                  , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        /// <summary>
        /// Opens a saved scanner file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void scannerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
                if (result == DialogResult.OK) // Test result.
                {
                    
                    CRObjSerializer cros = new CRObjSerializer();
                    crs = cros.LoadCRScanner(openFileDialog1.FileName);
                    //set drop down box
                    comboBox1.Items.Clear();
                    foreach(var p in crs.Patterns)
                    {
                        comboBox1.Items.Add(p);
                    }
                    //set the save path
                    fileSavePath = openFileDialog1.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error"
                , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void scannerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //init scanner object
            crs = null;
            crs = new CRScanner();
            //clear the patter combobox
            comboBox1.Items.Clear();
            //open scanner save form
            ScannerSaveForm ssf = new ScannerSaveForm(crs);
            ssf.Show();

        }
        /// <summary>
        /// Name and description menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nameAndDescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NameAndDesForm ndf = new NameAndDesForm(crs);
            ndf.Show();
                
        }

        /// <summary>
        /// Scanner Details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void scannerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("File path: {0}\n", fileSavePath);
                sb.AppendFormat("Scanner name: {0}\n", crs.Name);
                sb.AppendFormat("Scanner description: {0}\n", crs.Description);
                sb.AppendFormat("Pattern count: {0}\n", crs.Patterns.Count);
                sb.AppendFormat("File associations: {0}", " ");
                foreach (var fex in crs.FileExtensions)
                {
                    sb.AppendFormat("{0},", fex);
                }
                sb.AppendFormat("{0}", "\n");
                richTextBox1.Text = "";
                richTextBox1.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            
        }
        /// <summary>
        /// Clear the text area
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearTextFeildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }
        /// <summary>
        /// Add multiple patterns
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addPatternsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMulPatForm amp = new AddMulPatForm(crs);
            amp.Show();
        }
        /// <summary>
        /// Save text file 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveTextToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
