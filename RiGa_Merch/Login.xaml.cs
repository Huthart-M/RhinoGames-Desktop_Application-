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

namespace RiGa_Merch
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void ClearBTN_Click(object sender, RoutedEventArgs e)
        {
            //List<string> TbsClear = new List<string>() { UserTB.Text, PasswordEnt.Password };

            //foreach (string textBox in TbsClear)
            //{
            //    textBox = "";
            //}
        }

        private void EnterBTN_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=308-PC06\SQLEXPRESS;Initial Catalog=MasonH;Integrated Security=True");

            try
            {
                sqlConnection.Open();

                string Query = "SELECT UserName, Password FROM UserTable";

                SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    if (sqlDataReader["UserName"].ToString() == UserTB.Text && sqlDataReader["Password"].ToString() == PasswordEnt.Text)
                    {
                        MessageBox.Show($"Login Succsessfull");
                        Product product1 = new Product();
                        product1.Show();
                        Close();
                        break;
                    }

                    else
                    {
                        MessageBox.Show($"Access Denined incorect crednetials");
                    }
                }

                sqlDataReader.Close();
                sqlConnection.Close();
            }


            catch (Exception error)
            {

                sqlConnection.Close();
                MessageBox.Show($"Error, \n{error.Message}", "Error");
            }

            //For in house development 
            
            //Product product = new Product();
            //product.Show();
            //Close();

        }
    }
}
