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
    public partial class Car_portal : Form
    {
        string id;

        public Car_portal()
        {
            InitializeComponent();

            
            dataGridView1.DataSource = null;
        }

        private void Car_portal_Load(object sender, EventArgs e)
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
            textcarmodel.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtcaravailable.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txteachprice.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtcarbrand.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textcarmodel.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtcaravailable.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txteachprice.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void Clear()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CJ35126\SQLEXPRESS;Initial Catalog=vehicle management system;Integrated Security=True;Encrypt=False;");
            conn.Open();
            string query = "SELECT * FROM Cars";
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

            txtcarbrand.Text = textcarmodel.Text = txtcaravailable.Text = txteachprice.Text = "";
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
            if (txtcarbrand.Text == "" || textcarmodel.Text == "" ||
                txtcaravailable.Text == "" || txteachprice.Text == "")
            {
                MessageBox.Show("Please fill up all the fields.");
                return;
            }

            if (!IsNumbersOnly(txtcaravailable.Text))
            {
                MessageBox.Show("Cars available must contain numbers only.");
                return;
            }

            if (!IsNumbersOnly(txteachprice.Text))
            {
                MessageBox.Show("Each price must contain numbers only.");
                return;
            }

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CJ35126\SQLEXPRESS;Initial Catalog=vehicle management system;Integrated Security=True;Encrypt=False;");
            conn.Open();
            string query = "INSERT INTO Cars ([Car brand], Model, [Cars available], [Each price]) VALUES ('" +
                           txtcarbrand.Text + "','" + textcarmodel.Text + "','" +
                           txtcaravailable.Text + "','" + txteachprice.Text + "')";
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

            if (txtcarbrand.Text == "" || textcarmodel.Text == "" ||
                txtcaravailable.Text == "" || txteachprice.Text == "")
            {
                MessageBox.Show("Please fill up all the fields.");
                return;
            }

            if (!IsNumbersOnly(txtcaravailable.Text))
            {
                MessageBox.Show("Cars available must contain numbers only.");
                return;
            }

            if (!IsNumbersOnly(txteachprice.Text))
            {
                MessageBox.Show("Each price must contain numbers only.");
                return;
            }

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CJ35126\SQLEXPRESS;Initial Catalog=vehicle management system;Integrated Security=True;Encrypt=False;");
            conn.Open();
            string query = "UPDATE Cars SET [Car brand]='" + txtcarbrand.Text +
                           "', Model='" + textcarmodel.Text +
                           "', [Cars available]='" + txtcaravailable.Text +
                           "', [Each price]='" + txteachprice.Text +
                           "' WHERE [Car ID]=" + Convert.ToInt32(id);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            Clear();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (id == "" || id == null)
            {
                MessageBox.Show("Please select a row first.");
                return;
            }

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CJ35126\SQLEXPRESS;Initial Catalog=vehicle management system;Integrated Security=True;Encrypt=False;");
            conn.Open();
            string query = "DELETE FROM Cars WHERE [Car ID]=" + Convert.ToInt32(id);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            Clear();
        }

        private void txtcarbrand_TextChanged(object sender, EventArgs e) 
        { 
        
        }
        private void textcarmodel_TextChanged(object sender, EventArgs e) 
        { 
        
        }
        private void txtcaravailable_TextChanged(object sender, EventArgs e) 
        { 
        
        }
        private void txteachprice_TextChanged(object sender, EventArgs e) 
        { 
        
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}