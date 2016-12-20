using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//test
namespace RegexEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// keeps zoom between line numbers and editor the same
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void richTextBox2_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            
            richTextBox1.ZoomFactor = richTextBox2.ZoomFactor;
        }
        /// <summary>
        /// keeps zoom between line numbers and editor the same
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void richTextBox1_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            richTextBox2.ZoomFactor = richTextBox1.ZoomFactor;
        }

        private void lineNumbersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(lineNumbersToolStripMenuItem.Checked)
            {
                lineNumbersToolStripMenuItem.Checked = false;
                //remove line numbers
                richTextBox1.Visible = false;
                return;
            }

            if(!lineNumbersToolStripMenuItem.Checked)
            {
                lineNumbersToolStripMenuItem.Checked = true;
                //do something else
                richTextBox1.Visible = true;
                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            foreach(var l in richTextBox2.Lines)
            {
                
            }
        }

      
    }
}
