using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace txtedit
{
    public partial class findReplace : Form
    {
        Form1 parent;

        public void setParent(Form1 _parent)
        {
            parent = _parent;
        }

        public findReplace()
        {
            InitializeComponent();
        }

        private void findNextBtn_Click(object sender, EventArgs e)
        {
            int j = 0;
            for (int i = parent.textBox1.SelectionStart; i < parent.textBox1.Text.Length; i++)
            {
                if (parent.textBox1.Text[i] == findBox.Text[j])
                {
                    j++;
                }
                if (j == findBox.Text.Length)
                {
                    parent.textBox1.SelectionStart = i - j + 1;
                    parent.textBox1.SelectionLength = j;
                    return;
                }
            }
        }

        private void replaceNextBtn_Click(object sender, EventArgs e)
        {

        }

        private void replaceAllBtn_Click(object sender, EventArgs e)
        {
            if (!replaceCheck.Checked)
            {
                return;
            }
            parent.textBox1.Text = parent.textBox1.Text.Replace(findBox.Text, replaceBox.Text);
        }
    }
}
