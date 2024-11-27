using System;
using System.Collections.Generic;
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

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для Aurz.xaml
    /// </summary>
    public partial class Aurz : Window
    {
        public Aurz()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string логин = logintxt.Text;
            string пароль = passwordtxt.Password;

            MyDbContext db = new MyDbContext();

            if (!IsLoginPassword(db.connectionString, логин, пароль))
            {
                MessageBox.Show("nononono");
            }
            else
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }

        }

        public bool IsLoginPassword(string connectionString, string логин, string пароль)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("select count(*) from Клиент where логин =@Логин and пароль =@Пароль", connection))
            {
                command.Parameters.AddWithValue("@Логин",логин);
                command.Parameters.AddWithValue("@Пароль",пароль);
                connection.Open();
                return (int)command.ExecuteScalar()>0;
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Registr registr = new Registr();
            registr.Show();
            this.Close();
        }
    }
}
