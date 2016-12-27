using CR.Core;
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
    public partial class FileExtForm : Form
    {
        CRScanner crScanner;
        
        public FileExtForm(CRScanner crs)
        {
            InitializeComponent();
            foreach(var ex in crs.FileExtensions)
            {
                if(!comboBox1.Items.Contains(ex))
                {
                    comboBox1.Items.Add(ex);
                }
            }
            crScanner = crs;
        }

        /// <summary>
        /// Adds file extension entered in combobox to combobox drop down
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
           
                
                    if (!comboBox1.Items.Contains(comboBox1.Text))
                    {
                        comboBox1.Items.Add(comboBox1.Text);
                        //fire mbox
                        MessageBox.Show("added " + comboBox1.Text, "Info"
                       , MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //clear
                        comboBox1.Text = "";
                        saveToScanner();

                    }
                
            


           
        }

        /// <summary>
        /// Removes combobox item per selected from list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {

            if (comboBox1.Items.Contains(comboBox1.Text))
            {
                //remove from object first
                if (crScanner.FileExtensions.Contains(comboBox1.Text))
                {
                    crScanner.FileExtensions.Remove(comboBox1.Text);
                }
                //remove from combobox
                comboBox1.Items.Remove(comboBox1.Text);
                //fire mbox
                MessageBox.Show("removed " + comboBox1.Text, "Info"
               , MessageBoxButtons.OK, MessageBoxIcon.Information);
                //clear
                comboBox1.Text = "";
               

               

            }

        }

        /// <summary>
        /// Saves the changes from the form to the referenced CRScanner object
        /// </summary>
        private void saveToScanner()
        {
                       
           foreach(var ex in comboBox1.Items)
           {
                if (!crScanner.FileExtensions.Contains(ex))
                {
                    crScanner.FileExtensions.Add(ex.ToString());
                }

           }
        }
    }
}
