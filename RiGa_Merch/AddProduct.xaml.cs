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
    /// Interaction logic for ProductAdd.xaml
    /// </summary>
    public partial class ProductAdd : Window
    {
        public ProductAdd()
        {
            InitializeComponent();
        }

        private void AddBTN_Click(object sender, RoutedEventArgs e)
        {
           

            SqlConnection sqlConnection = new SqlConnection(@"Data Source=308-PC06\SQLEXPRESS;Initial Catalog=MasonH;Integrated Security=True");

            //SqlConnection sqlConnection = new SqlConnection(@"Data Source=MASON-LAPTOP\SQLEXPRESS;Initial Catalog=RhinoGames_Merchencide;Integrated Security=True");

            try
            {
                string Query = "INSERT into [Product] (ProductName, ProductDescription, ProductCategory, ProductSize, ProductRetailCost, ProductWholesale, Instock, ProductQuantity, ProductSerialNumber) values(@ProductName, @ProductDescription, @ProductCategory, @ProductSize, @ProductRetailCost, @ProductWholesale, @Instock, @ProductQuantity, @ProductSerialNumber)";
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@ProductName", ProdNameEnt.Text);
                sqlCommand.Parameters.AddWithValue("@ProductDescription", ProdDesENT.Text);
                sqlCommand.Parameters.AddWithValue("@ProductCategory", ProdCtgryEnt.Text);
                sqlCommand.Parameters.AddWithValue("@ProductSize", ProdSizeEnt.Text);
                sqlCommand.Parameters.AddWithValue("@ProductRetailCost", ProdRetailCostENt.Text);
                sqlCommand.Parameters.AddWithValue("@ProductWholesale", ProdWhlSaleEnt.Text);
                sqlCommand.Parameters.AddWithValue("@Instock", TruePick.IsChecked);
                sqlCommand.Parameters.AddWithValue("@ProductQuantity", ProdQuality.Text);
                sqlCommand.Parameters.AddWithValue("@ProductSerialNumber", ProdSecrialNU.Text);

                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                Product product = new Product();
                product.Show();
                Close();
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show($"Error \n{ex.Message}", "Error");
            }
        }

        private void CancelBTN_Click(object sender, RoutedEventArgs e)
        {
            Product product = new Product();
            product.Show();
            Close();
        }
    }
}
