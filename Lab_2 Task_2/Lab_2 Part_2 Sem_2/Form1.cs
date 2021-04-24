using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2_Part_2_Sem_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Init_Button();
        }

        public Button[] arrayOfButtons = new Button[16];
        TextBox tb = new TextBox
        {
            Location = new Point(100, 260),
            Margin = new Padding(5),
            BackColor = Color.White,
            ForeColor = Color.Gold,
        };

        public void Init_Button()
        {
            this.tb.Font = new System.Drawing.Font("Maiandra GD", 30);
            this.tb.Size = new System.Drawing.Size(200, 100);
            int x = 1;
            int y = 1;
            int namebtn = 1;
            for (int i = 0; i < 16; ++i) {
                if ((i % 4) == 0)
                {
                    x += 1;
                    y = 1;
                }
                arrayOfButtons[i] = new Button();
                arrayOfButtons[i].Location = new Point(x * 50, y * 50);
                arrayOfButtons[i].Size = new Size(50, 50);
                arrayOfButtons[i].Padding = new Padding(5);
                arrayOfButtons[i].BackColor = Color.AntiqueWhite;
                arrayOfButtons[i].Text = namebtn.ToString();
                arrayOfButtons[i].MouseClick += new MouseEventHandler(arrayOfButtons_MouseClick);
                Controls.Add(arrayOfButtons[i]);
                namebtn++;
                y += 1;
            }
            this.Controls.Add(tb);
        }
        int mustClick1 = 1;
        int wasClicked;
        void arrayOfButtons_MouseClick(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            wasClicked = Convert.ToInt32(button.Text);
            if (wasClicked == mustClick1)
            {
                arrayOfButtons[mustClick1 - 1].Visible = false;
                mustClick1++;
                tb.Text = "";
                if (mustClick1 == 17)
                {
                    tb.Text = "Молодець!";
                    for (int i = 0; i < mustClick1 - 1; i++)
                    {
                        arrayOfButtons[i].Visible = true;
                    }
                    mustClick1 = 1;
                }
            }
            else
            {
                for (int i = 0; i < mustClick1 - 1; i++)
                {
                    arrayOfButtons[i].Visible = true;
                }
                mustClick1 = 1;
                tb.Text = "Помилка!";
            }
        }
    }
}

