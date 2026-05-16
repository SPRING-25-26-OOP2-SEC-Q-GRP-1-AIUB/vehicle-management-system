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
    public partial class Customer_portal : Form
    {
        string id;

        public Customer_portal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Customer_portal_Load(object sender, EventArgs e)
        {

        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            id                    = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtname.Text          = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtusername.Text      = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtemail.Text         = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtcontactnumber.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtpassword.Text      = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtaddress.Text       = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtpurchaseddate.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString().Trim();

            
            string carID = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString().Trim();
            if (carID == "")
                txtcarid.SelectedIndex = -1;
            else
                txtcarid.SelectedItem = carID;

            string gender = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            if (gender.Contains("Male"))
                rbmale.Checked = true;
            if (gender.Contains("Female"))
                rbfemale.Checked = true;
            if (gender.Contains("Others"))
                rbothers.Checked = true;
        }

        private void txtcarid_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Clear()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=mahin\SQLEXPRESS;Initial Catalog=vehicle management system;Integrated Security=True;Encrypt=False;");
            conn.Open();
            string query = "select * from Customer";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.AutoGenerateColumns = true;
            conn.Close();

            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;

            SqlConnection conn2 = new SqlConnection(@"Data Source=mahin\SQLEXPRESS;Initial Catalog=vehicle management system;Integrated Security=True;Encrypt=False;");
            conn2.Open();
            string query2 = "SELECT [Car ID] FROM Cars ORDER BY [Car ID]";
            SqlCommand cmd2 = new SqlCommand(query2, conn2);
            SqlDataAdapter adp2 = new SqlDataAdapter(cmd2);
            DataSet ds2 = new DataSet();
            adp2.Fill(ds2);
            conn2.Close();

            txtcarid.Items.Clear();
            foreach (DataRow row in ds2.Tables[0].Rows)
                txtcarid.Items.Add(row["Car ID"].ToString());

            txtcarid.SelectedIndex = -1;

            txtname.Text = txtusername.Text = txtemail.Text = "";
            txtcontactnumber.Text = txtpassword.Text = txtpurchaseddate.Text = "";
            txtaddress.Text = "";
            rbmale.Checked = rbfemale.Checked = rbothers.Checked = false;
            id = "";
        }

        private bool IsValidDate(string date)
        {
            if (date.Trim() == "") return true;
            DateTime dummy;
            string[] formats = { "dd/MM/yyyy", "d/M/yyyy", "dd/M/yyyy", "d/MM/yyyy", "d/M/yy", "dd/MM/yy", "d/MM/yy", "dd/M/yy" };
            return DateTime.TryParseExact(date.Trim(), formats, null, System.Globalization.DateTimeStyles.None, out dummy);
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

        private bool IsValidEmail(string email)
        {
            if (!email.Contains("@")) return false;
            string[] parts = email.Split('@');
            if (parts.Length != 2) return false;
            if (parts[0] == "" || parts[1] == "") return false;
            if (!parts[1].Contains(".")) return false;
            return true;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" || txtusername.Text == "" || txtemail.Text == "" ||
                txtcontactnumber.Text == "" || txtpassword.Text == "" || txtaddress.Text == "" ||
                (!rbmale.Checked && !rbfemale.Checked && !rbothers.Checked))
            {
                MessageBox.Show("Please fill up all the fields.");
                return;
            }

            if (!IsValidEmail(txtemail.Text))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            if (!IsNumbersOnly(txtpassword.Text))
            {
                MessageBox.Show("Password must contain numbers only.");
                return;
            }

            if (txtpassword.Text.Length != 4)
            {
                MessageBox.Show("Password must be exactly 4 digits.");
                return;
            }

            if (!IsNumbersOnly(txtcontactnumber.Text))
            {
                MessageBox.Show("Contact number must contain numbers only.");
                return;
            }

            if (txtcontactnumber.Text.Length != 10)
            {
                MessageBox.Show("Contact number must be exactly 10 digits.");
                return;
            }

            if (txtpurchaseddate.Text.Trim() != "" && !IsValidDate(txtpurchaseddate.Text.Trim()))
            {
                MessageBox.Show("Purchased date must be in DD/MM/YYYY format.");
                return;
            }

            string selectedCarID = txtcarid.SelectedItem != null ? txtcarid.SelectedItem.ToString() : "";

            string gender = "";
            if (rbmale.Checked)   gender = "Male";
            if (rbfemale.Checked) gender = "Female";
            if (rbothers.Checked) gender = "Others";

            SqlConnection conn = new SqlConnection(@"Data Source=mahin\SQLEXPRESS;Initial Catalog=vehicle management system;Integrated Security=True;Encrypt=False;");
            conn.Open();
            string query = "UPDATE Customer SET Name='" + txtname.Text +
                           "', Username='" + txtusername.Text +
                           "', Email='" + txtemail.Text +
                           "', Gender='" + gender +
                           "', [Contact Number]='" + txtcontactnumber.Text +
                           "', Password='" + txtpassword.Text +
                           "', Address='" + txtaddress.Text +
                           "', [Car ID]='" + selectedCarID +
                           "', [Purchased date]='" + txtpurchaseddate.Text +
                           "' WHERE ID=" + Convert.ToInt32(id);
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

            SqlConnection conn = new SqlConnection(@"Data Source=mahin\SQLEXPRESS;Initial Catalog=vehicle management system;Integrated Security=True;Encrypt=False;");
            conn.Open();
            string query = "DELETE FROM Customer WHERE ID=" + Convert.ToInt32(id);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            Clear();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" || txtusername.Text == "" || txtemail.Text == "" ||
                txtcontactnumber.Text == "" || txtpassword.Text == "" || txtaddress.Text == "" ||
                (!rbmale.Checked && !rbfemale.Checked && !rbothers.Checked))
            {
                MessageBox.Show("Please fill up all the fields.");
                return;
            }

            if (!IsValidEmail(txtemail.Text))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            if (!IsNumbersOnly(txtpassword.Text))
            {
                MessageBox.Show("Password must contain numbers only.");
                return;
            }

            if (txtpassword.Text.Length != 4)
            {
                MessageBox.Show("Password must be exactly 4 digits.");
                return;
            }

            if (!IsNumbersOnly(txtcontactnumber.Text))
            {
                MessageBox.Show("Contact number must contain numbers only.");
                return;
            }

            if (txtcontactnumber.Text.Length != 10)
            {
                MessageBox.Show("Contact number must be exactly 10 digits.");
                return;
            }

            if (txtpurchaseddate.Text.Trim() != "" && !IsValidDate(txtpurchaseddate.Text.Trim()))
            {
                MessageBox.Show("Purchased date must be in DD/MM/YYYY format.");
                return;
            }

            string selectedCarID = txtcarid.SelectedItem != null ? txtcarid.SelectedItem.ToString() : "";

            string gender = "";
            if (rbmale.Checked)   gender = "Male";
            if (rbfemale.Checked) gender = "Female";
            if (rbothers.Checked) gender = "Others";

            SqlConnection conn = new SqlConnection(@"Data Source=mahin\SQLEXPRESS;Initial Catalog=vehicle management system;Integrated Security=True;Encrypt=False;");
            conn.Open();
            string query = "INSERT INTO Customer (Name, Username, Email, Gender, [Contact Number], Password, Address, [Car ID], [Purchased date]) VALUES ('" +
                           txtname.Text + "','" + txtusername.Text + "','" + txtemail.Text + "','" + gender + "','" +
                           txtcontactnumber.Text + "','" + txtpassword.Text + "','" + txtaddress.Text + "','" +
                           selectedCarID + "','" + txtpurchaseddate.Text + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            Clear();
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
