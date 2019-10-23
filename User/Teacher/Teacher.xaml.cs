using ControlStudents.Enter;
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

namespace ControlStudents.User.Teacher
{
    /// <summary>
    /// Логика взаимодействия для Teacher.xaml
    /// </summary>
    public partial class Teacher : Window
    {
        public Teacher()
        {
            InitializeComponent();
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            Close();
        }

        private void Panel_Click(object sender, RoutedEventArgs e)
        {
            PanelTeach PT = new PanelTeach();
            PT.Show();
            Close();
        }
    }
}
