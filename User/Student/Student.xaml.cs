using ControlStudents.DataBase;
using ControlStudents.Enter;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace ControlStudents.User.Student
{
    /// <summary>
    /// Логика взаимодействия для Student.xaml
    /// </summary>
    public partial class Student : Window
    {
        public Student()
        {
            InitializeComponent();
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            Close();
        }

        private void ResultsStu_Click(object sender, RoutedEventArgs e)
        {
            Results Rs = new Results();
            Rs.Show();
            Close();
        }

        private void ControlStu_Click(object sender, RoutedEventArgs e)
        {
            Control CT = new Control();
            CT.Show();
            Close();
        }


        
    }
}
