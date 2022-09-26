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
    /// Interaction logic for AddCatagorie.xaml
    /// </summary>
    public partial class AddCatagorie : Window
    {
        public AddCatagorie()
        {
            InitializeComponent();
        }

        private void CancelBTN_Click(object sender, RoutedEventArgs e)
        {
            Catagorie catagorie = new Catagorie();
            catagorie.Show();
            Close();
        }

        private void EnterBTN_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=308-PC06\SQLEXPRESS;Initial Catalog=MasonH;Integrated Security=True");

            //SqlConnection sqlConnection = new SqlConnection(@"Data Source=MASON-LAPTOP\SQLEXPRESS;Initial Catalog=RhinoGames_Merchencide;Integrated Security=True");

            try
            {
                string Query = "INSERT into [Category] (CategoryName, CategoryDescription) values(@CategoryName, @CategoryDescription)";
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@CategoryName", CatNameTB.Text);
                sqlCommand.Parameters.AddWithValue("@CategoryDescription", CatDescTB.Text);

                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                Catagorie catagorie = new Catagorie();
                catagorie.Show();
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
