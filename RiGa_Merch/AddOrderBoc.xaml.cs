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
    /// Interaction logic for AddOrderBoc.xaml
    /// </summary>
    public partial class AddOrderBoc : Window
    {
        public AddOrderBoc()
        {
            InitializeComponent();
        }

        private void CancelBTN_Click(object sender, RoutedEventArgs e)
        {
            Order order = new Order();
            order.Show();
            Close();
        }

        private void EnterBTN_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=308-PC06\SQLEXPRESS;Initial Catalog=MasonH;Integrated Security=True");

            //SqlConnection sqlConnection = new SqlConnection(@"Data Source=MASON-LAPTOP\SQLEXPRESS;Initial Catalog=RhinoGames_Merchencide;Integrated Security=True");

            int orderCost = Convert.ToInt32(OrderCostEnt.Text);
            int shippingCost = Convert.ToInt32(ShippingCostEnt.Text);

            int FinalCost = orderCost + shippingCost;


            try
            {
                string Query = "INSERT into [Product] (CustomerSurname, CustomerHouseNo, CustomerStreetName, CustomerTown, CustomerPostCode, ProductName, ProductQTY, OrderCost, OrderShippingCost, OrderFinalCost, OrderStatus) values(@CustomerSurname, @CustomerHouseNo, @CustomerStreetName, @CustomerTown, @CustomerPostCode, @ProductName, @ProductQTY, @OrderCost, @OrderShippingCost, @OrderFinalCost, @OrderStatus)";
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@CustomerSurname", CusSurnameEnt.Text);
                sqlCommand.Parameters.AddWithValue("@CustomerHouseNo", CusHouseNUmEnt.Text);
                sqlCommand.Parameters.AddWithValue("@CustomerStreetName", CusStreeNameEnt.Text);
                sqlCommand.Parameters.AddWithValue("@CustomerTown", CusTownEnt.Text);
                sqlCommand.Parameters.AddWithValue("@CustomerPostCode", CusPostCodeEnt.Text);
                sqlCommand.Parameters.AddWithValue("@ProductName", ProdNameEnt.Text);
                sqlCommand.Parameters.AddWithValue("@ProductQTY", ProdQtyEnt.Text);
                sqlCommand.Parameters.AddWithValue("@OrderCost", OrderCostEnt.Text);
                sqlCommand.Parameters.AddWithValue("@OrderShippingCost", ShippingCostEnt.Text);
                sqlCommand.Parameters.AddWithValue("@OrderFinalCost", FinalCost);
                sqlCommand.Parameters.AddWithValue("@OrderShippingCost", OrderStatusEnt.Text);

                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                Order order = new Order();
                order.Show();
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
