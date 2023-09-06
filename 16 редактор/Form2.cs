using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp68
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent(); 
            saveFileDialog1.Filter = "Rich Text File(*.txt)|*.";
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(richTextBox1.TextLength > 0 )
            {
                richTextBox1.Copy();
            }
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
                richTextBox1.Paste();          
        }

        private void выделитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.SelectAll();
            }
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Cut();
            }
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.Font = fontDialog1.Font;
        }

        private void ChildForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Сохранить Файл?", "Выход", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                Form2 childForm = (Form2)this.ActiveMdiChild;
                saveFileDialog1.Filter = "Rich Text File|*.rtf";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    childForm.richTextBox1.SaveFile(saveFileDialog1.FileName);
                    childForm.Text = saveFileDialog1.FileName;
                }
            }  
        }
    }
}
