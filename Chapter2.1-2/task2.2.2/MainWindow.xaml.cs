using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace task2._2._2
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

        private async void button_progress_Click(object sender, RoutedEventArgs e)
        {
            var progress = new Progress<int>(value => ProgressBar.Value = value);
            var progress1 = new Progress<int>(value => ProgressBar1.Value = value);
            await Task.Run(async () =>
            {
                for (int i = 0; i <= 100; i++)
                {
                    await Task.Delay(40);
                    //Thread.Sleep(40);
                    ((IProgress<int>)progress).Report(i);
                    ((IProgress<int>)progress1).Report(i);
                    
                }
            });
        }

        public class User
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public int Age { get; set; }
            public int Pay { get; set; }
            public string Sex { get; set; }
        }

        private void Add_Male_LV_Click(object sender, RoutedEventArgs e)
        {
            listView.Items.Add(new User { Name = "Ivan", Surname = "Paczenko", Age = 22, Sex = "Mężczyzna", Pay = 7300 });            
        }

        private void Add_Female_LV_Click(object sender, RoutedEventArgs e)
        {
            listView.Items.Add(new User { Name = "Ivania", Surname = "Paczenko", Age = 23, Sex = "Kobieta", Pay = 2300 });
        }

        private void button_DelLV_Click(object sender, RoutedEventArgs e)
        {
            if (listView.SelectedItems.Count == 0) return;
            listView.Items.RemoveAt(listView.Items.IndexOf(listView.SelectedItem));
            //foreach (ListViewItem item in listView.SelectedItems)
             //  listView.Items.Remove(item);
        }

        private void button_ParentTV_Click(object sender, RoutedEventArgs e)
        {
            TreeViewItem parent = new TreeViewItem();
            parent.Header = "Parent";
            treeView.Items.Add(parent);
        }

        private void button_ChildTV_Click(object sender, RoutedEventArgs e)
        {
            if(treeView.SelectedItem != null)
            {
                TreeViewItem newchild = new TreeViewItem();
                newchild.Header = "Child";
                TreeViewItem item = treeView.SelectedItem as TreeViewItem;
                item.Items.Add(newchild);
            }

           
        }
    }
}
