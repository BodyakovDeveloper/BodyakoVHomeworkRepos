using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lb_6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Init_Button();
        }

        
        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            if (textbox1.Text != "")
            {
                comboBox.Items.Add(textbox1.Text);
                textbox1.Text = "";
            }
        }
        private void Grid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (textbox1.Text != "")
                {
                    comboBox.Items.Add(textbox1.Text);
                    textbox1.Text = "";
                }
            }
            if (e.Key == Key.Delete)
            {
                comboBox.Items.Remove(comboBox.SelectedItem);
            }
        }
        private void buttonDelete_Click(object sender, RoutedEventArgs e)
        {
            comboBox.Items.Remove(comboBox.SelectedItem);
        }
     
        private void textbox1_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

       
        public Button[] arrayOfButtons = new Button[16];

        TextBox tb = new TextBox
        {
            Height = 50,
            Width = 400,
            Text = "как добавить все на одну вкладку ей",
            FontSize = 20
        };

        public void Init_Button()
        {
            
            int x = 1;
            int y = 1;
            int namebtn = 1;
            for (int i = 0; i < 16; ++i)
            {
                if ((i % 4) == 0)
                {
                    x += 1;
                    y = 1;
                }
                arrayOfButtons[i] = new Button();
                arrayOfButtons[i].Margin = new Thickness(x * 50, y * 50, 0, 40); // = new Point(x * 50, y * 50);
                arrayOfButtons[i].Width = 50;
                arrayOfButtons[i].Height = 50;

               // arrayOfButtons[i].Padding = new Padding(5);
                arrayOfButtons[i].Background = Brushes.Gray;
                arrayOfButtons[i].Content = namebtn.ToString();
                arrayOfButtons[i].MouseDown += new MouseButtonEventHandler(arrayOfButtons_MouseClick);
                //  tab2.Controls.Add(arrayOfButtons[i]);
                namebtn++;
                y += 1;
                tbControl.Items.Add(arrayOfButtons[i]);
            }
            tbControl.Items.Add(tb);
            // tab2 tabItem = new TabItem()
            // tabPage2.Controls.Add(tb);

            // tab2. (tb);
        }
        int mustClick1 = 1;
        int wasClicked;
        void arrayOfButtons_MouseClick(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            wasClicked = Convert.ToInt32(button.Content);
            if (wasClicked == mustClick1)
            {
              //  arrayOfButtons[mustClick1 - 1].Vsisble = f;
                mustClick1++;
                tb.Text = "";
                if (mustClick1 == 17)
                {
                    tb.Text = "Молодець!";
                    for (int i = 0; i < mustClick1 - 1; i++)
                    {
                 //       arrayOfButtons[i].Vsisble = t;
                    }
                    mustClick1 = 1;
                }
            }
            else
            {
                for (int i = 0; i < mustClick1 - 1; i++)
                {
                //    arrayOfButtons[i].Visible = true;
                }
                mustClick1 = 1;
                tb.Text = "Помилка!";
            }
        }

       
    }
}
