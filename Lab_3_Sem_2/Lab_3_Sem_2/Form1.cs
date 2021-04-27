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
            if ((e.X >= button1.Left - 10) && (e.X <= button1.Left + button1.Width + 10))
            {
                if (e.X >= button1.Left + (button1.Width / 2))
                {
                    button1.Left = button1.Left - 5;
                }
                else button1.Left = button1.Left + 5;
                button1.Width -= 1;
                button1.Height -= 1;
            }
            if ((e.Y >= button1.Top - 10) && (e.Y <= button1.Top + button1.Height + 10))
            {
                if (e.Y >= button1.Top + (button1.Height / 2))
                {
                    button1.Top = button1.Top - 5;
                }
                else button1.Top = button1.Top + 5;
                button1.Width -= 1;
                button1.Height -= 1;
            }
            if (button1.Left < 0)
            {
                button1.Left = 50;
            }
            if ((button1.Left + button1.Width) > this.ClientSize.Width)
            { button1.Left = this.ClientSize.Width - button1.Width; }
            if (button1.Top < 0)
            {
                button1.Top = 50;
            }
            if ((button1.Top + button1.Height) > this.ClientSize.Height)
            { button1.Top = this.ClientSize.Height - button1.Height; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            while(i != 8)
            {
                this.Text = "Press OK!";
                i++;
            }
            if (button1.Width <= 0 || button1.Height <= 0)
            {
                this.Text = "You will never press OK!";
                timer1.Stop();
            }
        }
    }
}
