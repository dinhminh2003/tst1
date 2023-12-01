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

namespace tst1
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

        private void Add_btn_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            form2 form2 = new form2();
            form2.Show();
        }

        private void show_list_btn_Click(object sender, RoutedEventArgs e)
        {
            ListView_list.Items.Clear();
            foreach(Employee employee in list.StaticList)
            {
                ListView_list.Items.Add(employee);
            }
        }

        private void Remove_btn_Click(object sender, RoutedEventArgs e)
        {
            for(int i=0; i<list.StaticList.Count; i++)
            {
                if (list.StaticList[i].Id.ToString() == ID_box.Text)
                {
                    list.StaticList.RemoveAt(i);
                }
            }
            ListView_list.Items.Clear();
            foreach (Employee employee in list.StaticList)
            {
                ListView_list.Items.Add(employee);
            }
        }

        private void Gender_choice_male_btn_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
