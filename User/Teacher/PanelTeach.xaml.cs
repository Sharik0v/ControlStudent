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
    /// Логика взаимодействия для PanelTeach.xaml
    /// </summary>
    public partial class PanelTeach : Window
    {
        public PanelTeach()
        {
            InitializeComponent();
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Teacher tc = new Teacher();
            tc.Show();
            Close();
        }

        private void Results_Click(object sender, RoutedEventArgs e)
        {
            Results r = new Results();
            r.Show();
            Close();
        }

        private void Control_Click(object sender, RoutedEventArgs e)
        {
            Control c = new Control();
            c.Show();
            Close();
        }

        private void ContEye_Click(object sender, RoutedEventArgs e)
        {
            ControlEye CE = new ControlEye();
            CE.Show();
            Close();
        }

        private void Resuests_Click(object sender, RoutedEventArgs e)
        {
            Request rq = new Request();
            rq.Show();
            Close();
        }
    }
}
