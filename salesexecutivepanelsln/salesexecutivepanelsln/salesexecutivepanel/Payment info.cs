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
    public partial class Payment_info : Form
    {
        public Payment_info()
        {
            InitializeComponent();
        }

        private void txttotalcustomer_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcustomerbought_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtearnedfromcars_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtordernumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtordervalue_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CJ35126\SQLEXPRESS;Initial Catalog=vehicle management system;Integrated Security=True;Encrypt=False");

            conn.Open();

            SqlCommand cmd = new SqlCommand(
                "SELECT COUNT(*) FROM Customer", conn);

            int totalCustomers = (int)cmd.ExecuteScalar();

            txttotalcustomer.Text = totalCustomers.ToString();

            SqlCommand cmd2 = new SqlCommand(
                  "SELECT COUNT([Car ID]) FROM Customer WHERE [Car ID] IS NOT NULL", conn);

            int customerbought = (int)cmd2.ExecuteScalar();

            txtcustomerbought.Text = customerbought.ToString();

            SqlCommand cmd3 = new SqlCommand(
                  "SELECT SUM(ca.[Each price]) FROM Customer cu JOIN Cars ca ON cu.[Car ID] = ca.[Car ID] WHERE cu.[Car ID] IS NOT NULL", conn);

            int earnedfromcars = (int)cmd3.ExecuteScalar();

            txtearnedfromcars.Text = earnedfromcars.ToString();

            SqlCommand cmd4 = new SqlCommand(
                  "SELECT SUM([Ordered cars]) FROM Orders WHERE [Order status] = 'Accepted'", conn);

            int ordernumber = (int)cmd4.ExecuteScalar();

            txtordernumber.Text = ordernumber.ToString();

            SqlCommand cmd5 = new SqlCommand(
                 "SELECT SUM([Ordered cars] * [Each price]) FROM Orders WHERE [Order status] = 'Accepted'", conn);

            int ordervalue = (int)cmd5.ExecuteScalar();

            txtordervalue.Text = ordervalue.ToString();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
