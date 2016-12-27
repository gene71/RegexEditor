using CR.Core;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RegexEditor
{
    public partial class AddMulPatForm : Form
    {
        CRScanner crs;
        public AddMulPatForm(CRScanner crs)
        {
            InitializeComponent();
            this.crs = crs;
        }
        /// <summary>
        /// Cancel button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            
            try
            {
                //do add
                string[] sa = textBox1.Text.Split('\n');
                int pCount = 0;
                for(int i = 0; i < sa.Length; i++)
                {
                    if(!this.crs.Patterns.Contains(sa[i].ToString()) && sa[i].ToString() != "")
                    {
                        //clean the \r
                        string s = Regex.Replace(sa[i].ToString(), "\r", string.Empty);
                        this.crs.Patterns.Add(s);
                        
                        pCount++;
                    }
                }
                MessageBox.Show("Added " + pCount + " patterns", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            
            //exit
            this.Close();
        }
    }
}
