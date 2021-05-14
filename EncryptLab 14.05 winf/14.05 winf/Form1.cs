using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _14._05_winf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Text files(*.txt)|*.txt|all files(*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read, FileShare.Read))
                    {
                        using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))
                        {
                            richTextBox1.Text += sr.ReadToEnd();
                        }
                    }
                }
                           }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string toProcess = richTextBox1.Text;

            char[] resultC = new char[richTextBox1.Text.Length];


            for (int i = 0; i < toProcess.Length; i++)
            {
                char c = (char)(toProcess[i] + 1);
                resultC[i] = c;
            }

            richTextBox2.Text = new string(resultC);
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Text files(*.txt) | *.txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write))
                    {
                        using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                        {
                            sw.Write(richTextBox2.Text);
                        }
                    }
                }
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string toProcess = richTextBox1.Text;

            char[] resultC = new char[richTextBox1.Text.Length];


            for (int i = 0; i < toProcess.Length; i++)
            {
                char c = (char)(toProcess[i] - 1);
                resultC[i] = c;
            }

            richTextBox2.Text = new string(resultC);
        }
    }
}




