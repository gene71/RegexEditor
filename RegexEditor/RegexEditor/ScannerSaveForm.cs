using CR.Core;
using CR.Core.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegexEditor
{
    public partial class ScannerSaveForm : Form
    {
        CRScanner crScanner;
        
        public ScannerSaveForm(CRScanner crs)
        {
            InitializeComponent();
            crScanner = crs;
       
            initFormFeilds();
        }

        private void initFormFeilds()
        {
            textBox1.Text = crScanner.Name;
            textBox2.Text = crScanner.Description;
            foreach (var p in crScanner.Patterns)
            {
                if(!comboBox1.Items.Contains(p))
                {
                    comboBox1.Items.Add(p);
                }
                
            }

            foreach (var fex in crScanner.FileExtensions)
            {
                if(!comboBox2.Items.Contains(fex))
                {
                    comboBox2.Items.Add(fex);
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Opens the SaveFile dialog and sets the save path
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //get attributes
                crScanner.Name = textBox1.Text;
                crScanner.Description = textBox2.Text;

                CRObjSerializer cros = new CRObjSerializer();
                saveFileDialog1.ShowDialog();
                cros.SaveCRObj(saveFileDialog1.FileName, crScanner);
                RegexEditorForm.fileSavePath = saveFileDialog1.FileName;
                MessageBox.Show("file saved to: " + RegexEditorForm.fileSavePath,
                    "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error"
                , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
