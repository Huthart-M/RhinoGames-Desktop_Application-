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
using System.Data.SqlClient;
using System.Data;

namespace RiGa_Merch
{
    /// <summary>
    /// Interaction logic for Product.xaml
    /// </summary>
    public partial class Product : Window
    {
        public Product()
        {
            InitializeComponent();

            //SqlConnection sqlConnection = new SqlConnection(@"Data Source=308-PC06\SQLEXPRESS;Initial Catalog=MasonH;Integrated Security=True");

            //string Query = "SELECT * FROM Product";
            ////string Query = "SELECT * FROM ProductTable";

            //sqlConnection.Open();

            //SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            //DataTable dataTable = new DataTable("Product");
            ////DataTable dataTable = new DataTable("ProductTable");
            //sqlDataAdapter.Fill(dataTable);
            //ProductTBL.ItemsSource = dataTable.DefaultView;


        }

        private void ProductBTN_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OrderBTN_Click(object sender, RoutedEventArgs e)
        {
            Order order = new Order();
            order.Show();
            Close();
        }

        private void CustomerBTN_Click(object sender, RoutedEventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
            Close();
        }

        private void CategoryBTN_Click(object sender, RoutedEventArgs e)
        {
            Catagorie catagorie = new Catagorie();
            catagorie.Show();
            Close();
        }

        private void AddItemBTN_Click(object sender, RoutedEventArgs e)
        {
            ProductAdd productAdd = new ProductAdd();
            productAdd.Show();
            Close();
        }

        private void UpdateBTN_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteBTN_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RealoadBTN_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=308-PC06\SQLEXPRESS;Initial Catalog=MasonH;Integrated Security=True");

           // SqlConnection sqlConnection = new SqlConnection(@"Data Source=MASON-LAPTOP\SQLEXPRESS;Initial Catalog=RhinoGames_Merchencide;Integrated Security=True");

            try
            {
                string Query = "SELECT * FROM Product";
                //string Query = "SELECT * FROM ProductTable";

                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable("Product");
                //DataTable dataTable = new DataTable("ProductTable");
                sqlDataAdapter.Fill(dataTable);
                ProductTBL.ItemsSource = dataTable.DefaultView;
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error : \n{ ex.Message}", "Error");
            }
            sqlConnection.Close();
        }

        private void ProductTBL_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
