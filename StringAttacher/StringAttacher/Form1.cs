using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringAttacher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String resultString = textBoxString2Add.Text + textBoxOriginal.Text;
            Clipboard.SetText(resultString);
            label3.Text = "处理完成";
        }

        private void textBoxOriginal_TextChanged(object sender, EventArgs e)
        {
            label3.Text = "";
        }

        private void textBoxString2Add_TextChanged(object sender, EventArgs e)
        {
            label3.Text = "";
        }
    }
}
