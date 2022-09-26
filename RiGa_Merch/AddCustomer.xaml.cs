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
    /// Interaction logic for AddCustomer.xaml
    /// </summary>
    public partial class AddCustomer : Window
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void CanelBtn_Click(object sender, RoutedEventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
            Close();
        }

        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=308-PC06\SQLEXPRESS;Initial Catalog=MasonH;Integrated Security=True");

            

            try
            {
                string Query = "INSERT into [Customer] (CustomerFirstName, CustomerSurname, CustomerHouseNo, CustomerStreetName, CustomerCity, CustomerCountry, CustomerPostcode, CustomerHomeTel, CustomerMobile) values(@CustomerFirstName, @CustomerSurname, @CustomerHouseNo, @CustomerStreetName, @CustomerCity, @CustomerCountry, @CustomerPostcode, @CustomerHomeTel, @CustomerMobile)";
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@CustomerFirstName", NameEnt.Text);
                sqlCommand.Parameters.AddWithValue("@CustomerSurname", SurnameEnt.Text);
                sqlCommand.Parameters.AddWithValue("@CustomerHouseNo", HouseNumEnt.Text);
                sqlCommand.Parameters.AddWithValue("@CustomerStreetName", StreetNameEnt.Text);
                sqlCommand.Parameters.AddWithValue("@CustomerCity", CityEnt.Text);
                sqlCommand.Parameters.AddWithValue("@CustomerCountry", CountryEnt.Text);
                sqlCommand.Parameters.AddWithValue("@CustomerPostcode", PostCodeEnt.Text);
                sqlCommand.Parameters.AddWithValue("@CustomerHomeTel", HomeTelNumEnt.Text);
                sqlCommand.Parameters.AddWithValue("@CustomerMobile", MobileNumEnt.Text);
                

                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                Customer customer = new Customer();
                customer.Show();
                Close();

            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show($"Error \n{ex.Message}", "Error");
            }
        }
    }
}
