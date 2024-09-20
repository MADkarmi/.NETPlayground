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

namespace task2._2._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void acceptButton_Click(object sender, RoutedEventArgs e)
        {
            string temp = string.Format("{0}\n{1}\n{2}", textBox_Name.Text, textBox_Adress.Text, comboBox.Text);
            if((bool)checkBox.IsChecked) //why ischecked return bool?
                temp = string.Format("{0}\n{1}", temp, checkBox.Content);
            else
                temp = string.Format("{0}\n{1}", temp, checkBox1.Content);

            MessageBox.Show(temp, "Uczelnia");

        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void discardButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
    
}
