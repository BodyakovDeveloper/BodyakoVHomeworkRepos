using System;
using System.IO;
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

namespace Lab_7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static string path = @"C:\Folder";
        public MainWindow()
        {
            InitializeComponent();
            MessageBox.Show($"Yout path {path}");
        }
        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 4674; i++)
            {
                DirectoryInfo dir = new DirectoryInfo(path);
                path += $@"\Folder_{i}";
                if (!dir.Exists)
                {
                    dir.Create();
                }
            }
            MessageBox.Show($"Max of created folders = 4675");
            path = @"C:\Folder";
        }
        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            foreach (string folder in Directory.GetDirectories(path))
            {
                Directory.Delete(folder, true);
            }
            DirectoryInfo dir = new DirectoryInfo(path);
            dir.Delete();
        }
    }
}
