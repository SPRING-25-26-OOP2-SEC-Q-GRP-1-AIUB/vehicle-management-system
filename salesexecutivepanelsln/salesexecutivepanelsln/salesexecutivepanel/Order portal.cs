using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace salesexecutivepanel
{
    public partial class Order_portal : Form
    {
        string id;

        public Order_portal()
        {
            InitializeComponent();
            dataGridView1.DataSource = null;
        }

        private void Order_portal_Load(object sender, EventArgs e)
        {
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;

            id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtcarbrand.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

            string status = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString().Trim();

            radioButton1.CheckedChanged -= radioButton1_CheckedChanged;
            radioButton2.CheckedChanged -= radioButton2_CheckedChanged;

            radioButton1.Checked = (status == "Accepted");
            radioButton2.Checked = (status == "Rejected");

            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
        }

        private void Clear()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CJ35126\SQLEXPRESS;Initial Catalog=vehicle management system;Integrated Security=True;Encrypt=False;");
            conn.Open();
            string query = "SELECT * FROM Orders";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            conn.Close();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dt;
            dataGridView1.AutoGenerateColumns = true;

            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;

            txtcarbrand.Text = textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            id = "";
        }

        private bool IsNumbersOnly(string text)
        {
            foreach (char c in text)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtcarbrand.Text == "" || textBox1.Text == "" ||
                textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Please fill up all the fields.");
                return;
            }

            if (!IsNumbersOnly(textBox2.Text))
            {
                MessageBox.Show("Ordered cars must contain numbers only.");
                return;
            }

            if (!IsNumbersOnly(textBox3.Text))
            {
                MessageBox.Show("Each price must contain numbers only.");
                return;
            }

            if (!int.TryParse(textBox4.Text, out int pct) || pct < 0 || pct > 100)
            {
                MessageBox.Show("Payment % done must be a number between 0 and 100.");
                return;
            }

            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Please select an order status (Accepted or Rejected).");
                return;
            }

            string status = radioButton1.Checked ? "Accepted" : "Rejected";

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CJ35126\SQLEXPRESS;Initial Catalog=vehicle management system;Integrated Security=True;Encrypt=False;");
            conn.Open();
            string query = "INSERT INTO Orders ([Car brand], Model, [Ordered cars], [Each price], [Payment done percentage], [Order status]) " +
                           "VALUES ('" + txtcarbrand.Text + "','" + textBox1.Text + "'," +
                           textBox2.Text + "," + textBox3.Text + "," + textBox4.Text + ",'" + status + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            Clear();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (id == "" || id == null)
            {
                MessageBox.Show("Please select a row first.");
                return;
            }

            if (txtcarbrand.Text == "" || textBox1.Text == "" ||
                textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Please fill up all the fields.");
                return;
            }

            if (!IsNumbersOnly(textBox2.Text))
            {
                MessageBox.Show("Ordered cars must contain numbers only.");
                return;
            }

            if (!IsNumbersOnly(textBox3.Text))
            {
                MessageBox.Show("Each price must contain numbers only.");
                return;
            }

            if (!int.TryParse(textBox4.Text, out int pct) || pct < 0 || pct > 100)
            {
                MessageBox.Show("Payment % done must be a number between 0 and 100.");
                return;
            }

            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Please select an order status (Accepted or Rejected).");
                return;
            }

            string status = radioButton1.Checked ? "Accepted" : "Rejected";

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CJ35126\SQLEXPRESS;Initial Catalog=vehicle management system;Integrated Security=True;Encrypt=False;");
            conn.Open();
            string query = "UPDATE Orders SET [Car brand]='" + txtcarbrand.Text +
                           "', Model='" + textBox1.Text +
                           "', [Ordered cars]=" + textBox2.Text +
                           ", [Each price]=" + textBox3.Text +
                           ", [Payment done percentage]=" + textBox4.Text +
                           ", [Order status]='" + status +
                           "' WHERE [Order ID]=" + Convert.ToInt32(id);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            Clear();
        }

        private void label7_Click(object sender, EventArgs e) 
        { 
        
        }
        private void txtcarbrand_TextChanged(object sender, EventArgs e) 
        { 
        
        }
        private void textBox1_TextChanged(object sender, EventArgs e) 
        {
        
        }
        private void textBox2_TextChanged(object sender, EventArgs e) 
        { 
        
        }
        private void textBox3_TextChanged(object sender, EventArgs e) 
        { 
        
        }
        private void textBox4_TextChanged(object sender, EventArgs e) 
        { 
        
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e) 
        { 
        
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e) 
        { 
        
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}