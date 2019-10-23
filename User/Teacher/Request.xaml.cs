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
using ControlStudents.Enter;

namespace ControlStudents.User.Teacher
{
    /// <summary>
    /// Логика взаимодействия для Request.xaml
    /// </summary>
    public partial class Request : Window
    {
        public Request()
        {
            InitializeComponent();
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            PanelTeach PT = new PanelTeach();
            PT.Show();
            Close();
        }
    }
}
