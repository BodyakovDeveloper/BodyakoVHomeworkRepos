using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3_Sem_2
{
    public partial class Form1 : Form
    {
        int i = 0;
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            textBoxHei.Text = "Height: ";
            textBoxWid.Text = "Width: ";
            textBoxHei.Text += buttonOk.Height;
            textBoxWid.Text += buttonOk.Width;
            if ((e.X >= buttonOk.Left - 10) && (e.X <= buttonOk.Left + buttonOk.Width + 10))
            {
                if (e.X >= buttonOk.Left + (buttonOk.Width / 2))
                {
                    buttonOk.Left = buttonOk.Left - 5;
                }
                else buttonOk.Left = buttonOk.Left + 5;
                buttonOk.Width -= 1;
                buttonOk.Height -= 1;
            }
            if ((e.Y >= buttonOk.Top - 10) && (e.Y <= buttonOk.Top + buttonOk.Height + 10))
            {
                if (e.Y >= buttonOk.Top + (buttonOk.Height / 2))
                {
                    buttonOk.Top = buttonOk.Top - 5;
                }
                else buttonOk.Top = buttonOk.Top + 5;
                buttonOk.Width -= 1;
                buttonOk.Height -= 1;
            }
            if (buttonOk.Left < 0)
            {
                buttonOk.Left = 50;
            }
            if ((buttonOk.Left + buttonOk.Width) > this.ClientSize.Width)
            { buttonOk.Left = this.ClientSize.Width - buttonOk.Width; }
            if (buttonOk.Top < 0)
            {
                buttonOk.Top = 50;
            }
            if ((buttonOk.Top + buttonOk.Height) > this.ClientSize.Height)
            { buttonOk.Top = this.ClientSize.Height - buttonOk.Height; }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine(textBoxHei.Text += buttonOk.Height);
            Console.WriteLine(textBoxWid.Text += buttonOk.Width);
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            while(i != 8)
            {
                this.Text = "Press OK!";
                i++;
            }
            if (buttonOk.Width <= 0 || buttonOk.Height <= 0)
            {
                i = 0;
                while (i != 8)
                {
                    this.Text = "You will never press OK!";
                    i++;
                }
                timer1.Stop();
            }
        }
    }
}