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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp4.model;

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loadd();
        }


        public void Loadd()
        {
            MyDbContext db =new MyDbContext();

            using (SqlConnection connection=new SqlConnection(db.connectionString))
            using (SqlCommand command = new SqlCommand("select Id_товара, Название, Цена, Описание from Товары",connection))
            {
                connection.Open();

                List<Товар> товар = new List<Товар>();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        товар.Add(new Товар
                        {
                            //Id_Товар=reader.GetInt32(0),
                            //Название=reader.GetString(1),
                            //Стоимость = reader.GetInt32(2),
                            //Описание=reader.GetString(3),
                        });
                    }

                    Load.ItemsSource=товар;
                }

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Redact redact = new Redact();
            redact.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            if(Load.SelectedItem is Товар id)
            {
                DeleteProduct(id.Id_Товар);
                Loadd();
            }
            else
            {
                MessageBox.Show("Выберите товар для удаления.");
            }
        }
        public void DeleteProduct(int idТовара)
        {
            MyDbContext db = new MyDbContext();

            using (SqlConnection connection = new SqlConnection(db.connectionString))
            using (SqlCommand command = new SqlCommand("delete from Товары where Id_товара=@Id_товара",connection))
            {
                command.Parameters.AddWithValue("@Id_товара",idТовара);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }


    }
}
