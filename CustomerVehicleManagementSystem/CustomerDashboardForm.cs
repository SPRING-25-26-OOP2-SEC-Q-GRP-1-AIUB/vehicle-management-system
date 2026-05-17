using System;
using System.Windows.Forms;

namespace CustomerVehicleManagementSystem
{
    public partial class CustomerDashboardForm : Form
    {
        private int userId;
        private string username;
        private string customerName;

        public CustomerDashboardForm()
            : this(1, "kaif", "Kaif")
        {
        }

        public CustomerDashboardForm(int loggedInUserId, string loggedInUsername, string loggedInName)
        {
            userId = loggedInUserId;
            username = loggedInUsername;
            customerName = loggedInName;

            InitializeComponent();
            lblUser.Text = username;
            lblWelcome.Text = "Welcome " + customerName;
            LoadCars();
        }

        private void LoadCars()
        {
            dgvCars.DataSource = DemoRepository.GetAvailableCars(txtSearch.Text.Trim());
        }

        private void LoadOrders()
        {
            dgvOrders.DataSource = DemoRepository.GetOrders(userId);
        }

        private void LoadPayments()
        {
            dgvPayments.DataSource = DemoRepository.GetPayments(userId);
        }

        private int GetSelectedId(DataGridView grid, string columnName)
        {
            if (grid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row first.");
                return 0;
            }

            return Convert.ToInt32(grid.SelectedRows[0].Cells[columnName].Value);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            tabCustomer.SelectedTab = tabDashboard;
        }

        private void btnCars_Click(object sender, EventArgs e)
        {
            tabCustomer.SelectedTab = tabCars;
            LoadCars();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            tabCustomer.SelectedTab = tabOrders;
            LoadOrders();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            tabCustomer.SelectedTab = tabPayments;
            LoadPayments();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            tabCustomer.SelectedTab = tabProfile;
            LoadProfile();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadCars();
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            int carId = GetSelectedId(dgvCars, "CarID");
            if (carId == 0) return;

            DemoCar car = DemoRepository.GetAvailableCar(carId);
            if (car == null)
            {
                MessageBox.Show("This car is not available for ordering.");
                LoadCars();
                return;
            }

            MessageBox.Show(
                "Car Details\n\nBrand: " + car.Brand +
                "\nModel: " + car.Model +
                "\nColor: " + car.Color +
                "\nYear: " + car.Year +
                "\nEngine: " + car.Engine +
                "\nPrice: " + car.Price +
                "\nStatus: " + car.Status);
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            int carId = GetSelectedId(dgvCars, "CarID");
            if (carId == 0) return;

            if (DemoRepository.PlaceOrder(userId, carId))
            {
                MessageBox.Show("Order placed successfully. Order status is Pending.");
                LoadCars();
            }
            else
            {
                MessageBox.Show("This car is not available.");
            }
        }

        private void btnRefreshOrders_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            ChangePendingOrder(false);
        }

        private void btnRemoveOrder_Click(object sender, EventArgs e)
        {
            ChangePendingOrder(true);
        }

        private void ChangePendingOrder(bool deleteOrder)
        {
            int orderId = GetSelectedId(dgvOrders, "OrderID");
            if (orderId == 0) return;

            bool success = deleteOrder
                ? DemoRepository.RemoveOrder(userId, orderId)
                : DemoRepository.CancelOrder(userId, orderId);

            MessageBox.Show(success
                ? (deleteOrder ? "Order removed successfully." : "Order cancelled successfully.")
                : "Only pending orders can be changed.");

            LoadOrders();
        }

        private void LoadProfile()
        {
            DemoUser user = DemoRepository.GetUser(userId);
            if (user == null) return;

            txtProfileName.Text = user.Name;
            txtProfileEmail.Text = user.Email;
            txtProfilePhone.Text = user.Phone;
            txtProfileAddress.Text = user.Address;
        }

        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
            if (txtProfileName.Text.Trim() == "" || txtProfileEmail.Text.Trim() == "" || txtProfilePhone.Text.Trim() == "")
            {
                MessageBox.Show("Name, email and phone are required.");
                return;
            }

            DemoRepository.UpdateProfile(userId, txtProfileName.Text.Trim(), txtProfileEmail.Text.Trim(), txtProfilePhone.Text.Trim(), txtProfileAddress.Text.Trim());
            customerName = txtProfileName.Text.Trim();
            lblWelcome.Text = "Welcome " + customerName;
            MessageBox.Show("Profile updated successfully.");
        }

        private void lblIcon_Click(object sender, EventArgs e)
        {

        }
    }
}
