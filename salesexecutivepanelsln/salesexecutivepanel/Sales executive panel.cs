using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace salesexecutivepanel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openChildForm(new Dashboard());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnaddnewcustomer_Click(object sender, EventArgs e)
        {
            openChildForm(new Customer_portal());
        }

        private void btnviewcustomer_Click(object sender, EventArgs e)
        {
            openChildForm(new Car_portal());
        }

        private void btnupdatecustomer_Click(object sender, EventArgs e)
        {
            openChildForm(new Order_portal());
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            openChildForm(new Dashboard());
        }


        //to show dashboard form in mainform
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel2.Controls.Add(childForm);
            panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void username_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
