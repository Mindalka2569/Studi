using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp68
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 childForm = new Form2(); 
            childForm.MdiParent = this; 
            childForm.Show();
            int n = this.MdiChildren.Count();
            childForm.Text = "Документ" + Convert.ToString(n);
        }
        private void открыть1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Rich Text File|*.rtf";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {  
                Form2 childForm = new Form2();
                childForm.richTextBox1.LoadFile(openFileDialog1.FileName);
                childForm.Text = openFileDialog1.FileName;
                childForm.MdiParent = this;
                childForm.Show();
            }
        }
    private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.fontDialog1.ShowDialog() == DialogResult.OK)
            {
                this.ActiveMdiChild.Font = fontDialog1.Font;
            }
        }
        private void сохранитьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if(this.ActiveMdiChild != null)
            {
                Form2 childForm = (Form2)this.ActiveMdiChild;
                saveFileDialog1.Filter = "Rich Text File|*.rtf";
                if(saveFileDialog1.ShowDialog()==DialogResult.OK)
                {
                    childForm.richTextBox1.SaveFile(saveFileDialog1.FileName);
                    childForm.Text = saveFileDialog1.FileName;
                }
            }
        }
    }
}
