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
using System.Windows.Shapes;

namespace tst1
{
    /// <summary>
    /// Interaction logic for form2.xaml
    /// </summary>
    public partial class form2 : Window
    {
        public form2()
        {
            InitializeComponent();
        }

        protected void OK_btn_Click(object sender, RoutedEventArgs e)
        {
            Employee employee = new Employee();
            string g = "";
            if (Gender_choice_male_btn.IsChecked == true)
            {
                g = "Male";
            }
            else
            {
                g = "Female";
            }
            bool trung = false;
            foreach(Employee em in list.StaticList)
            {
                if(ID_box.Text == em.Id.ToString())
                {
                    trung = true;
                }
            }
            if (trung== false)
            {
                employee.nhapTT(int.Parse(ID_box.Text), Name_box.Text, g, Borndate_box, float.Parse(DayWave_box.Text), int.Parse(WorkDay_box.Text));
                list.StaticList.Add(employee);
                MessageBox.Show("Da them");
                Close();
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
            }
            else
            {
                MessageBox.Show("Trung id!");

            }
            
           
        }
    }
}
