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
using ControlStudents.DataBase;
using ControlStudents.User;
using ControlStudents.User.Admin;
using ControlStudents.User.Student;
using ControlStudents.User.Teacher;

namespace ControlStudents.Enter
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public void Reset()
        {
            TxtLogin.Text = "";
            TxtPass.Password = "";
        }
        public Login()
        {
            InitializeComponent();
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnEnt_Click(object sender, RoutedEventArgs e)
        {
            if (TxtLogin.Text.Length == 0)
            {
                MessageBox.Show("Введите логин");
                TxtLogin.Focus();
            }
            else if (TxtPass.Password.Length == 0)
            {
                MessageBox.Show("Введите Пароль");
                TxtPass.Focus();
            }
            else
            {
                string login = TxtLogin.Text;
                string password = TxtPass.Password;
                SqlConnection conn = DBUtils.GetDBConnection();
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Role FROM [User] WHERE Login='" + login + "' AND Password='" + password + "'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    if (dt.Rows[0][0].ToString() == "Администратор")
                    {
                        Administration Adm = new Administration();
                        Adm.Show();
                        this.Close();
                    }
                    else if (dt.Rows[0][0].ToString() == "Студент")
                    {
                        Student St = new Student();
                        St.Show();
                        this.Close();
                    }
                    else if (dt.Rows[0][0].ToString() == "Преподаватель")
                    {
                        Teacher Tc = new Teacher();
                        Tc.Show();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Неправильный Логин или Пароль");
                    Reset();
                    return;
                }
                conn.Close();
            }
        }

        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
            Close();
        }
    }
}
