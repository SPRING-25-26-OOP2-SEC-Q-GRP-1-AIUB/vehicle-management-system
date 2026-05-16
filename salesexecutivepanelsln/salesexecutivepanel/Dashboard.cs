using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.CodeDom.Compiler;

namespace salesexecutivepanel
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=mahin\SQLEXPRESS;Initial Catalog=vehicle management system;Integrated Security=True;Encrypt=False");

            conn.Open();

            SqlCommand cmd = new SqlCommand(
                "SELECT COUNT(*) FROM Customer", conn);

            int totalCustomers = (int)cmd.ExecuteScalar();

            txttotalcustomer.Text = totalCustomers.ToString();

            SqlCommand cmd2 = new SqlCommand(
                "SELECT SUM([Cars available]) FROM Cars", conn);

            object carsavailable = cmd2.ExecuteScalar();

            txttotalcars.Text = carsavailable.ToString();

            SqlCommand cmd3 = new SqlCommand(
                "SELECT SUM([Ordered cars]) FROM Orders", conn);

            object carsordered = cmd3.ExecuteScalar();

            txtcarsordered.Text = carsordered.ToString();

            SqlCommand cmd4 = new SqlCommand(
                "SELECT TOP 1 [Car brand], SUM([Cars available]) AS TotalAvailableCars FROM Cars GROUP BY [Car brand] ORDER BY TotalAvailableCars DESC;", conn);

            object mostavailablebrand = cmd4.ExecuteScalar();

            txtmostavailablebrand.Text = mostavailablebrand.ToString();

            SqlCommand cmd5 = new SqlCommand(
                "SELECT TOP 1 [Car brand], SUM([Ordered cars]) AS MostOrderedCars FROM Orders GROUP BY [Car brand] ORDER BY MostOrderedCars DESC;", conn);

            object mostorderedbrand = cmd5.ExecuteScalar();

            txtmostorderedbrand.Text = mostorderedbrand.ToString();

            SqlCommand cmd6 = new SqlCommand(
                "SELECT TOP 1 Model FROM Cars ORDER BY [Each price] DESC;", conn);

            object expensivemodelavailable = cmd6.ExecuteScalar();

            txtexpensivemodelavailable.Text = expensivemodelavailable.ToString();

            SqlCommand cmd7 = new SqlCommand(
                "SELECT TOP 1 Model FROM Cars ORDER BY [Each price] ASC;", conn);

            object cheapestmodelavailable = cmd7.ExecuteScalar();

            txtcheapestmodelavailable.Text = cheapestmodelavailable.ToString();

            SqlCommand cmd8 = new SqlCommand(
                "SELECT AVG([Each price]) AS AveragePrice FROM Cars;", conn);

            object averageprice = cmd8.ExecuteScalar();

            txtaverageprice.Text = averageprice.ToString();

            conn.Close();
        }

        private void txttotalcustomer_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttotalcars_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcarsordered_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmostavailablebrand_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmostorderedbrand_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtexpensivemodelavailable_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcheapestmodelavailable_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
