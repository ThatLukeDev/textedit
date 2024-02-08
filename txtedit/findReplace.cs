using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

            if (regexCheck.Checked)
            {
                Match _m = Regex.Match(parent.textBox1.Text.Substring(parent.textBox1.SelectionStart + 1), findBox.Text);
                int offset = parent.textBox1.SelectionStart + 1;
                if (!_m.Success)
                {
                    _m = Regex.Match(parent.textBox1.Text, findBox.Text);
                    offset = 0;
                }
                if (!_m.Success)
                {
                    return;
                }
                parent.textBox1.SelectionStart = _m.Index + offset;
                parent.textBox1.SelectionLength = _m.Length;
                parent.textBox1.Focus();
            }
            else
            {
                for (int i = parent.textBox1.SelectionStart + 1; i < parent.textBox1.Text.Length; i++)
                {
                    if (parent.textBox1.Text[i] == findBox.Text[j])
                    {
                        j++;
                    }
                    if (j == findBox.Text.Length)
                    {
                        parent.textBox1.SelectionStart = i - j + 1;
                        parent.textBox1.SelectionLength = j;
                        parent.textBox1.Focus();
                        return;
                    }
                }
                for (int i = 0; i < parent.textBox1.Text.Length; i++)
                {
                    if (parent.textBox1.Text[i] == findBox.Text[j])
                    {
                        j++;
                    }
                    if (j == findBox.Text.Length)
                    {
                        parent.textBox1.SelectionStart = i - j + 1;
                        parent.textBox1.SelectionLength = j;
                        parent.textBox1.Focus();
                        return;
                    }
                }
            }
        }

        private void replaceNextBtn_Click(object sender, EventArgs e)
        {
            if (!replaceCheck.Checked)
            {
                return;
            }
            StringBuilder builder = new StringBuilder(parent.textBox1.Text);
            builder.Remove(parent.textBox1.SelectionStart, parent.textBox1.SelectionLength);
            builder.Insert(parent.textBox1.SelectionStart, replaceBox.Text);
            parent.textBox1.Text = builder.ToString();
            parent.textBox1.Focus();
        }

        private void replaceAllBtn_Click(object sender, EventArgs e)
        {
            if (!replaceCheck.Checked)
            {
                return;
            }
            if (regexCheck.Checked)
            {
                parent.textBox1.Text = Regex.Replace(parent.textBox1.Text, findBox.Text, replaceBox.Text);
                parent.textBox1.Focus();
            }
            else
            {
                parent.textBox1.Text = parent.textBox1.Text.Replace(findBox.Text, replaceBox.Text);
                parent.textBox1.Focus();
            }
        }

        private void findReplace_Load(object sender, EventArgs e)
        {

        }

        private void replaceCheck_CheckedChanged(object sender, EventArgs e)
        {
            replaceBox.Enabled = replaceCheck.Checked;
        }
    }
}
