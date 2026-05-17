using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Service_Panel
{
    public partial class ucVehicleHistory : UserControl
    {
        private List<VehicleRecord> vehicles;

        public ucVehicleHistory()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(46, 51, 73);
            this.Dock = DockStyle.Fill;
        }

        private void ucVehicleHistory_Load(object sender, EventArgs e)
        {
            LoadSampleData();
        }

        private void LoadSampleData()
        {
            vehicles = new List<VehicleRecord>
            {
                new VehicleRecord("Toyota Camry", "555-0101", new List<ServiceRecord>{
                    new ServiceRecord("Oil Change", 5000, new DateTime(2024,1,15)),
                    new ServiceRecord("Tire Rotation", 7500, new DateTime(2024,2,20)),
                    new ServiceRecord("Full Service", 10000, new DateTime(2024,4,5))
                }),
                new VehicleRecord("Honda Civic", "555-0102", new List<ServiceRecord>{
                    new ServiceRecord("Oil Change", 3000, new DateTime(2024,1,10)),
                    new ServiceRecord("Engine Diagnosis", 4500, new DateTime(2024,2,15)),
                    new ServiceRecord("Brake Repair", 6000, new DateTime(2024,3,20))
                }),
                new VehicleRecord("Ford Mustang", "555-0103", new List<ServiceRecord>{
                    new ServiceRecord("Full Service", 15000, new DateTime(2024,1,5)),
                    new ServiceRecord("Oil Change", 18500, new DateTime(2024,3,15)),
                    new ServiceRecord("AC Service", 19500, new DateTime(2024,4,1))
                }),
                new VehicleRecord("BMW X5", "555-0104", new List<ServiceRecord>{
                    new ServiceRecord("Oil Change", 8000, new DateTime(2024,1,20)),
                    new ServiceRecord("Brake Pad Replacement", 12000, new DateTime(2024,3,5))
                }),
                new VehicleRecord("Tesla Model 3", "555-0105", new List<ServiceRecord>{
                    new ServiceRecord("Battery Check", 5000, new DateTime(2024,2,1)),
                    new ServiceRecord("Tire Rotation", 7500, new DateTime(2024,3,10))
                })
            };
            UpdateVehicleList();
        }

        private void UpdateVehicleList()
        {
            listBoxVehicles.Items.Clear();
            vehicles.ForEach(v => listBoxVehicles.Items.Add($"{v.Model} - {v.Phone}"));
            lblVehicleCount.Text = $"Total Vehicles: {vehicles.Count}";
        }

        private void listBoxVehicles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxVehicles.SelectedIndex >= 0)
            {
                var vehicle = vehicles[listBoxVehicles.SelectedIndex];
                txtVehicleModel.Text = vehicle.Model;
                txtPhoneNumber.Text = vehicle.Phone;
                DisplayServiceHistory(vehicle.Services);
            }
        }

        private void DisplayServiceHistory(List<ServiceRecord> services)
        {
            dataGridViewHistory.Rows.Clear();
            foreach (var service in services.OrderByDescending(s => s.Date))
                dataGridViewHistory.Rows.Add(service.Type, service.Mileage.ToString("N0"), service.Date.ToString("MMM dd, yyyy"));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var filtered = vehicles.Where(v => (string.IsNullOrEmpty(txtSearchModel.Text) || v.Model.ToLower().Contains(txtSearchModel.Text.ToLower())) &&
                                               (string.IsNullOrEmpty(txtSearchPhone.Text) || v.Phone.Contains(txtSearchPhone.Text))).ToList();
            listBoxVehicles.Items.Clear();
            filtered.ForEach(v => listBoxVehicles.Items.Add($"{v.Model} - {v.Phone}"));
            lblVehicleCount.Text = $"Found: {filtered.Count} vehicles";
            if (filtered.Count == 0) ClearVehicleDetails();
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearchModel.Clear(); txtSearchPhone.Clear();
            UpdateVehicleList();
            ClearVehicleDetails();
        }

        private void ClearVehicleDetails()
        {
            txtVehicleModel.Clear(); txtPhoneNumber.Clear();
            dataGridViewHistory.Rows.Clear();
        }

        private class VehicleRecord
        {
            public string Model { get; }
            public string Phone { get; }
            public List<ServiceRecord> Services { get; }
            public VehicleRecord(string model, string phone, List<ServiceRecord> services) { Model = model; Phone = phone; Services = services; }
        }

        private class ServiceRecord
        {
            public string Type { get; }
            public int Mileage { get; }
            public DateTime Date { get; }
            public ServiceRecord(string type, int mileage, DateTime date) { Type = type; Mileage = mileage; Date = date; }
        }
    }
}