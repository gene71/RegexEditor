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
    public partial class NameAndDesForm : Form
    {
        CRScanner crs;
        public NameAndDesForm(CRScanner crs)
        {
            InitializeComponent();
            this.crs = crs;
            initFormFeilds();
        }

        private void initFormFeilds()
        {
            textBox1.Text = this.crs.Name;
            richTextBox1.Text = this.crs.Description;
        }

        /// <summary>
        /// Cancel button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Done button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.crs.Name = textBox1.Text;
            this.crs.Description = richTextBox1.Text;
            this.Close();
        }
    }
}
