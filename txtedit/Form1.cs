using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace txtedit
{

    public partial class Form1 : Form
    {
        public string fileName = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            fileName = openFileDialog1.FileName;
            if (fileName == "")
            {
                return;
            }
            StreamReader sr = new StreamReader(fileName);
            textBox1.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileName == "")
            {
                saveAsToolStripMenuItem_Click(this, e);
                return;
            }
            StreamWriter sw = new StreamWriter(fileName);
            sw.Write(textBox1.Text);
            sw.Close();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            fileName = saveFileDialog1.FileName;
            saveToolStripMenuItem_Click(this, e);
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            findReplace popup = new findReplace();
            popup.setParent(this);
            popup.replaceCheck.Checked = false;
            popup.Show();
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            findReplace popup = new findReplace();
            popup.setParent(this);
            popup.replaceCheck.Checked = true;
            popup.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
