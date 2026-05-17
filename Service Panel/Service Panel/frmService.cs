using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Service_Panel
{
    public partial class ucServiceType : UserControl
    {
        private Dictionary<string, List<ServiceInfo>> serviceData;

        public ucServiceType()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(46, 51, 73);
            this.Dock = DockStyle.Fill;
            InitializeServiceData();
        }

        private void InitializeServiceData()
        {
            serviceData = new Dictionary<string, List<ServiceInfo>>
            {
                ["Basic Maintenance"] = new List<ServiceInfo>
                {
                    new ServiceInfo("Oil Change", "Engine oil change with filter replacement", 49, "30 min"),
                    new ServiceInfo("Full Service", "Complete vehicle inspection and maintenance", 199, "2 hours"),
                    new ServiceInfo("Basic Service", "Essential checks and maintenance", 89, "1 hour"),
                    new ServiceInfo("Filter Replacement", "Air, oil, and fuel filter replacement", 79, "45 min")
                },
                ["Engine Services"] = new List<ServiceInfo>
                {
                    new ServiceInfo("Engine Diagnosis", "Complete engine diagnostic check", 129, "1.5 hours"),
                    new ServiceInfo("Spark Plug Replacement", "Replace spark plugs and wires", 99, "1 hour"),
                    new ServiceInfo("Timing Belt Replacement", "Replace timing belt and tensioner", 399, "3 hours"),
                    new ServiceInfo("Engine Tune-Up", "Complete engine tuning", 249, "2 hours")
                },
                ["Electrical Services"] = new List<ServiceInfo>
                {
                    new ServiceInfo("Battery Replacement", "New battery installation", 79, "30 min"),
                    new ServiceInfo("Alternator Repair", "Alternator testing and repair", 199, "2 hours"),
                    new ServiceInfo("Starter Motor Repair", "Starter motor diagnosis and repair", 179, "1.5 hours"),
                    new ServiceInfo("Electrical Wiring", "Electrical system diagnosis", 149, "1.5 hours")
                },
                ["AC & Cooling"] = new List<ServiceInfo>
                {
                    new ServiceInfo("AC Service", "AC system check and refill", 99, "1 hour"),
                    new ServiceInfo("Coolant Flush", "Complete coolant system flush", 89, "1 hour"),
                    new ServiceInfo("AC Repair", "AC system diagnosis and repair", 199, "2 hours"),
                    new ServiceInfo("Radiator Repair", "Radiator flush and repair", 159, "1.5 hours")
                },
                ["Brake Services"] = new List<ServiceInfo>
                {
                    new ServiceInfo("Brake Pad Replacement", "Replace front or rear brake pads", 159, "1.5 hours"),
                    new ServiceInfo("Brake Rotor Replacement", "Replace brake rotors", 249, "2 hours"),
                    new ServiceInfo("Brake Fluid Flush", "Complete brake fluid replacement", 79, "1 hour"),
                    new ServiceInfo("Complete Brake Service", "Full brake system service", 399, "3 hours")
                },
                ["Tire Services"] = new List<ServiceInfo>
                {
                    new ServiceInfo("Tire Rotation", "Rotate all four tires", 39, "30 min"),
                    new ServiceInfo("New Tires", "Replace all four tires", 399, "1 hour"),
                    new ServiceInfo("Wheel Alignment", "Four-wheel alignment", 89, "1 hour"),
                    new ServiceInfo("Tire Balance", "Wheel balancing", 49, "45 min")
                },
                ["Transmission"] = new List<ServiceInfo>
                {
                    new ServiceInfo("Transmission Service", "Transmission fluid change", 299, "2 hours"),
                    new ServiceInfo("Transmission Repair", "Transmission diagnosis and repair", 599, "4 hours"),
                    new ServiceInfo("Clutch Replacement", "Replace clutch assembly", 499, "3 hours")
                },
                ["Exhaust System"] = new List<ServiceInfo>
                {
                    new ServiceInfo("Muffler Repair", "Muffler replacement or repair", 149, "1 hour"),
                    new ServiceInfo("Exhaust System Check", "Complete exhaust inspection", 79, "45 min"),
                    new ServiceInfo("Catalytic Converter", "Converter replacement", 399, "2 hours")
                }
            };
        }

        private void ucServiceType_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void LoadCategories()
        {
            var categories = new (string Name, string Icon, Color Color)[]
            {
                ("Basic Maintenance", "🔧", Color.FromArgb(0, 126, 249)),
                ("Engine Services", "⚙️", Color.FromArgb(0, 150, 136)),
                ("Electrical Services", "💡", Color.FromArgb(255, 193, 7)),
                ("AC & Cooling", "❄️", Color.FromArgb(33, 150, 243)),
                ("Brake Services", "🛑", Color.FromArgb(244, 67, 54)),
                ("Tire Services", "🛞", Color.FromArgb(76, 175, 80)),
                ("Transmission", "⚡", Color.FromArgb(156, 39, 176)),
                ("Exhaust System", "💨", Color.FromArgb(255, 87, 34))
            };

            foreach (var cat in categories)
                flowLayoutPanelCategories.Controls.Add(CreateCategoryCard(cat.Name, cat.Icon, cat.Color));
        }

        private Panel CreateCategoryCard(string title, string icon, Color color)
        {
            var panel = new Panel { Width = 220, Height = 120, BackColor = Color.FromArgb(55, 61, 83), Margin = new Padding(10), Cursor = Cursors.Hand };
            panel.MouseEnter += (s, e) => panel.BackColor = Color.FromArgb(65, 71, 93);
            panel.MouseLeave += (s, e) => panel.BackColor = Color.FromArgb(55, 61, 83);
            panel.Click += (s, e) => LoadServices(title);

            panel.Controls.Add(new Label { Text = icon, Font = new Font("Segoe UI", 32), ForeColor = color, Location = new Point(15, 15), Size = new Size(60, 60), TextAlign = ContentAlignment.MiddleCenter });
            panel.Controls.Add(new Label { Text = title, Font = new Font("Segoe UI", 11, FontStyle.Bold), ForeColor = Color.White, Location = new Point(85, 30), Size = new Size(120, 40), TextAlign = ContentAlignment.MiddleLeft });
            panel.Controls.Add(new Label { Text = "→", Font = new Font("Segoe UI", 14, FontStyle.Bold), ForeColor = color, Location = new Point(185, 45), Size = new Size(20, 30), TextAlign = ContentAlignment.MiddleCenter });

            return panel;
        }

        private void LoadServices(string category)
        {
            flowLayoutPanelServices.Controls.Clear();
            flowLayoutPanelServices.Visible = true;
            btnBackToCategories.Visible = true;
            lblSelectedCategory.Text = category;
            lblSelectedCategory.Visible = true;

            foreach (var service in serviceData[category])
                flowLayoutPanelServices.Controls.Add(CreateServiceCard(service));
        }

        private Panel CreateServiceCard(ServiceInfo service)
        {
            var panel = new Panel { Width = 500, Height = 100, BackColor = Color.FromArgb(55, 61, 83), Margin = new Padding(10) };

            panel.Controls.Add(new Label { Text = service.Name, Font = new Font("Segoe UI", 12, FontStyle.Bold), ForeColor = Color.FromArgb(0, 126, 249), Location = new Point(15, 10), Size = new Size(250, 25) });
            panel.Controls.Add(new Label { Text = service.Description, Font = new Font("Segoe UI", 9), ForeColor = Color.LightGray, Location = new Point(15, 40), Size = new Size(300, 40) });

            var durationPanel = new Panel { Location = new Point(330, 15), Size = new Size(70, 30), BackColor = Color.FromArgb(33, 150, 243) };
            durationPanel.Controls.Add(new Label { Text = service.Duration, Font = new Font("Segoe UI", 9, FontStyle.Bold), ForeColor = Color.White, Location = new Point(5, 5), Size = new Size(60, 20), TextAlign = ContentAlignment.MiddleCenter });
            panel.Controls.Add(durationPanel);

            panel.Controls.Add(new Label { Text = $"${service.Price}", Font = new Font("Segoe UI", 16, FontStyle.Bold), ForeColor = Color.FromArgb(76, 175, 80), Location = new Point(415, 15), Size = new Size(70, 35), TextAlign = ContentAlignment.MiddleRight });

            var selectBtn = new Button { Text = "Select", FlatStyle = FlatStyle.Flat, BackColor = Color.FromArgb(0, 126, 249), ForeColor = Color.White, Font = new Font("Segoe UI", 10, FontStyle.Bold), Location = new Point(415, 55), Size = new Size(70, 30), Cursor = Cursors.Hand };
            selectBtn.Click += (s, e) => SelectService(service);
            panel.Controls.Add(selectBtn);

            return panel;
        }

        private void SelectService(ServiceInfo service)
        {
            if (MessageBox.Show($"Would you like to book this service?\n\nService: {service.Name}\nDescription: {service.Description}\nPrice: ${service.Price}\nDuration: {service.Duration}",
                "Confirm Service Selection", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show($"✓ SERVICE SELECTED!\n\nService: {service.Name}\nPrice: ${service.Price}\nEstimated Duration: {service.Duration}\n\nPlease go to 'Book Service' to complete your booking.",
                    "Service Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBackToCategories_Click(object sender, EventArgs e)
        {
            flowLayoutPanelServices.Visible = false;
            btnBackToCategories.Visible = false;
            lblSelectedCategory.Visible = false;
            flowLayoutPanelServices.Controls.Clear();
        }

        private class ServiceInfo
        {
            public string Name { get; }
            public string Description { get; }
            public int Price { get; }
            public string Duration { get; }
            public ServiceInfo(string name, string desc, int price, string duration) { Name = name; Description = desc; Price = price; Duration = duration; }
        }
    }
}