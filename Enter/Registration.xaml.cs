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

namespace ControlStudents.Enter
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public void Reset()
        {
            TxtRegLogin.Text = "";
            TxtRegPass.Password = "";
            TxtRegPass2.Password = "";
            FIO.Text = "";
            Klass.Text = "";
        }
        public Registration()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            Close();
        }

        private void BtnRegistration_Click(object sender, RoutedEventArgs e)
        {

            if (TxtRegLogin.Text.Length == 0)
            {
                MessageBox.Show("Введите логин");
                TxtRegLogin.Focus();
            }
            else
            {
                string login = TxtRegLogin.Text;
                string password = TxtRegPass.Password;
                string name = FIO.Text;
                string klass = Klass.Text;
                if (TxtRegPass.Password.Length == 0)
                {
                    MessageBox.Show("Введите пароль!");
                    TxtRegPass.Focus();
                }
                else if (TxtRegPass2.Password.Length == 0)
                {
                    MessageBox.Show("Повторите пароль!");
                    TxtRegPass2.Focus();
                }
                else if (TxtRegPass.Password != TxtRegPass2.Password)
                {
                    MessageBox.Show("Пароли не совпадают!");
                    TxtRegPass2.Focus();
                }
                else if (FIO.Text.Length == 0)
                {
                    MessageBox.Show("Введите имя!");
                    TxtRegPass2.Focus();
                }
                  // else if (Klass.Text.Length == 0)
                  // {
                  //  MessageBox.Show("Введите Группу!");
                  //  TxtRegPass2.Focus();
                  // }
                else
                {
                    SqlConnection conn = DBUtils.GetDBConnection();
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO [User] (Login,Password,Role,Name) values('" + login + "', '" + password + "', '" + "Студент" + "' , '" + name + "' )", conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Вы успешно зарегестрировались");
                    Reset();
                    Login Logw = new Login();
                    Logw.Show();
                    this.Close();
                }
            }
        }
    }
}
