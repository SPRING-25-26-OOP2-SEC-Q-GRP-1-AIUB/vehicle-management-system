using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Service_Panel
{
    public partial class ucSpareParts : UserControl
    {
        private List<SparePart> parts;
        private SparePart selected;

        public ucSpareParts()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(46, 51, 73);
            this.Dock = DockStyle.Fill;
        }

        private void ucSpareParts_Load(object sender, EventArgs e)
        {
            LoadSampleData();
            cmbCategoryFilter.Items.Add("All");
            cmbCategoryFilter.Items.AddRange(parts.Select(p => p.Category).Distinct().OrderBy(c => c).ToArray());
            cmbCategoryFilter.SelectedIndex = 0;
            UpdateStatistics();
        }

        private void LoadSampleData()
        {
            parts = new List<SparePart>
            {
                new SparePart("SP001", "Engine Oil 5W-30", "Lubricants", 29.99, 50, "Liter", "Synthetic engine oil"),
                new SparePart("SP002", "Oil Filter", "Filters", 12.99, 100, "Piece", "Premium oil filter"),
                new SparePart("SP003", "Air Filter", "Filters", 19.99, 75, "Piece", "High flow air filter"),
                new SparePart("SP004", "Brake Pads (Front)", "Brakes", 45.99, 30, "Set", "Ceramic brake pads"),
                new SparePart("SP005", "Brake Pads (Rear)", "Brakes", 42.99, 28, "Set", "Ceramic brake pads"),
                new SparePart("SP006", "Spark Plug", "Engine", 8.99, 200, "Piece", "Iridium spark plug"),
                new SparePart("SP007", "Battery 12V", "Electrical", 89.99, 15, "Piece", "Maintenance free battery"),
                new SparePart("SP008", "Windshield Wiper", "Accessories", 15.99, 40, "Pair", "All-season wiper blades"),
                new SparePart("SP009", "Coolant/Antifreeze", "Lubricants", 24.99, 35, "Gallon", "Pre-mixed coolant"),
                new SparePart("SP010", "Brake Fluid", "Lubricants", 18.99, 45, "Liter", "DOT 4 brake fluid"),
                new SparePart("SP011", "Timing Belt", "Engine", 67.99, 20, "Piece", "Reinforced timing belt"),
                new SparePart("SP012", "Alternator", "Electrical", 199.99, 8, "Piece", "High output alternator")
            };
            UpdatePartsList();
        }

        private void UpdatePartsList()
        {
            listBoxParts.Items.Clear();
            string filter = cmbCategoryFilter.SelectedItem?.ToString() ?? "All";
            var filtered = filter == "All" ? parts : parts.Where(p => p.Category == filter).ToList();
            foreach (var part in filtered)
            {
                string stock = part.Quantity <= 5 ? "⚠️" : (part.Quantity <= 10 ? "●" : "✓");
                listBoxParts.Items.Add($"{stock} {part.Name} - ${part.Price:F2} ({part.Quantity} {part.Unit})");
            }
            lblTotalParts.Text = $"Total: {filtered.Count} items";
        }

        private void listBoxParts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxParts.SelectedIndex >= 0)
            {
                string name = listBoxParts.SelectedItem.ToString().Substring(2).Split('-')[0].Trim();
                selected = parts.First(p => p.Name == name);
                DisplayDetails(selected);
                EnableControls(true);
            }
        }

        private void DisplayDetails(SparePart part)
        {
            txtPartID.Text = part.ID;
            txtPartName.Text = part.Name;
            txtCategory.Text = part.Category;
            txtPrice.Text = $"${part.Price:F2}";
            txtQuantity.Text = part.Quantity.ToString();
            txtUnit.Text = part.Unit;
            txtDescription.Text = part.Description;
            txtQuantity.BackColor = part.Quantity <= 5 ? Color.FromArgb(220, 53, 69) : (part.Quantity <= 10 ? Color.FromArgb(255, 193, 7) : Color.FromArgb(55, 61, 83));
            txtQuantity.ForeColor = part.Quantity <= 5 ? Color.White : (part.Quantity <= 10 ? Color.Black : Color.White);
            lblTotalValue.Text = $"Total Value: ${part.Price * part.Quantity:F2}";
        }

        private void EnableControls(bool enable) { btnUpdateQuantity.Enabled = enable; btnUpdatePrice.Enabled = enable; btnDelete.Enabled = enable; }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            var addForm = new frmAddPart();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                parts.Add(addForm.GetSparePart());
                UpdatePartsList();
                UpdateCategoryFilter();
                UpdateStatistics();
                MessageBox.Show($"Part added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdateQuantity_Click(object sender, EventArgs e)
        {
            var updateForm = new frmUpdateQuantity(selected);
            if (updateForm.ShowDialog() == DialogResult.OK)
            {
                selected.Quantity = updateForm.NewQuantity;
                UpdatePartsList();
                DisplayDetails(selected);
                UpdateStatistics();
            }
        }

        private void btnUpdatePrice_Click(object sender, EventArgs e)
        {
            var updateForm = new frmUpdatePrice(selected);
            if (updateForm.ShowDialog() == DialogResult.OK)
            {
                selected.Price = updateForm.NewPrice;
                UpdatePartsList();
                DisplayDetails(selected);
                UpdateStatistics();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Delete '{selected.Name}'?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                parts.Remove(selected);
                selected = null;
                UpdatePartsList();
                UpdateCategoryFilter();
                ClearDetails();
                UpdateStatistics();
            }
        }

        private void UpdateCategoryFilter()
        {
            cmbCategoryFilter.Items.Clear();
            cmbCategoryFilter.Items.Add("All");
            cmbCategoryFilter.Items.AddRange(parts.Select(p => p.Category).Distinct().OrderBy(c => c).ToArray());
            cmbCategoryFilter.SelectedIndex = 0;
        }

        private void ClearDetails()
        {
            foreach (TextBox txt in new[] { txtPartID, txtPartName, txtCategory, txtPrice, txtQuantity, txtUnit, txtDescription })
                txt.Clear();
            lblTotalValue.Text = "Total Value: $0.00";
            EnableControls(false);
        }

        private void UpdateStatistics()
        {
            lblTotalInventory.Text = parts.Sum(p => p.Quantity).ToString();
            lblTotalInventoryValue.Text = $"${parts.Sum(p => p.Price * p.Quantity):F2}";
            int lowStock = parts.Count(p => p.Quantity <= 5);
            lblLowStockCount.Text = lowStock.ToString();
            lblLowStockCount.ForeColor = lowStock > 0 ? Color.FromArgb(220, 53, 69) : Color.LightGreen;
        }

        private void cmbCategoryFilter_SelectedIndexChanged(object sender, EventArgs e) => UpdatePartsList();
        private void btnRefresh_Click(object sender, EventArgs e) => UpdatePartsList();

        private class SparePart
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public string Category { get; set; }
            public double Price { get; set; }
            public int Quantity { get; set; }
            public string Unit { get; set; }
            public string Description { get; set; }
            public SparePart(string id, string name, string cat, double price, int qty, string unit, string desc) { ID = id; Name = name; Category = cat; Price = price; Quantity = qty; Unit = unit; Description = desc; }
        }

        private class frmAddPart : Form
        {
            private TextBox txtName, txtPrice, txtQuantity, txtUnit, txtDescription;
            private ComboBox cmbCategory;
            public frmAddPart()
            {
                this.Text = "Add New Spare Part";
                this.Size = new Size(450, 400);
                this.StartPosition = FormStartPosition.CenterParent;
                this.BackColor = Color.FromArgb(46, 51, 73);
                this.FormBorderStyle = FormBorderStyle.FixedDialog;

                int y = 20;
                txtName = AddField("Part Name:", ref y);
                cmbCategory = new ComboBox { Location = new Point(130, y), Size = new Size(270, 25), DropDownStyle = ComboBoxStyle.DropDownList, BackColor = Color.FromArgb(55, 61, 83), ForeColor = Color.White };
                cmbCategory.Items.AddRange(new[] { "Lubricants", "Filters", "Brakes", "Engine", "Electrical", "Accessories", "Other" });
                cmbCategory.SelectedIndex = 0;
                this.Controls.Add(new Label { Text = "Category:", Location = new Point(20, y), Size = new Size(100, 25), ForeColor = Color.White });
                this.Controls.Add(cmbCategory);
                y += 35;
                txtPrice = AddField("Price ($):", ref y);
                txtQuantity = AddField("Quantity:", ref y);
                txtUnit = AddField("Unit:", ref y);
                txtDescription = AddField("Description:", ref y, true);

                var btnAdd = new Button { Text = "Add Part", Location = new Point(130, y + 70), Size = new Size(100, 35), BackColor = Color.FromArgb(0, 126, 249), ForeColor = Color.White, FlatStyle = FlatStyle.Flat };
                btnAdd.Click += (s, e) => { if (ValidateInputs()) this.DialogResult = DialogResult.OK; };
                var btnCancel = new Button { Text = "Cancel", Location = new Point(250, y + 70), Size = new Size(100, 35), BackColor = Color.FromArgb(64, 64, 64), ForeColor = Color.White, FlatStyle = FlatStyle.Flat };
                btnCancel.Click += (s, e) => { this.DialogResult = DialogResult.Cancel; this.Close(); };
                this.Controls.AddRange(new Control[] { btnAdd, btnCancel });
            }
            private TextBox AddField(string label, ref int y, bool multiLine = false)
            {
                this.Controls.Add(new Label { Text = label, Location = new Point(20, y), Size = new Size(100, 25), ForeColor = Color.White });
                var txt = new TextBox { Location = new Point(130, y), Size = new Size(270, multiLine ? 60 : 25), Multiline = multiLine, BackColor = Color.FromArgb(55, 61, 83), ForeColor = Color.White };
                if (!multiLine) txt.Text = multiLine ? "" : (label.Contains("Price") ? "0.00" : (label.Contains("Quantity") ? "0" : (label.Contains("Unit") ? "Piece" : "")));
                this.Controls.Add(txt);
                y += multiLine ? 70 : 35;
                return txt;
            }
            private bool ValidateInputs()
            {
                if (string.IsNullOrWhiteSpace(txtName.Text)) { MessageBox.Show("Enter part name!"); return false; }
                if (!double.TryParse(txtPrice.Text, out double p) || p <= 0) { MessageBox.Show("Enter valid price!"); return false; }
                if (!int.TryParse(txtQuantity.Text, out int q) || q < 0) { MessageBox.Show("Enter valid quantity!"); return false; }
                return true;
            }
            public SparePart GetSparePart() => new SparePart($"SP{new Random().Next(100, 999)}", txtName.Text, cmbCategory.SelectedItem.ToString(), double.Parse(txtPrice.Text), int.Parse(txtQuantity.Text), txtUnit.Text, txtDescription.Text);
        }

        private class frmUpdateQuantity : Form
        {
            public int NewQuantity { get; private set; }
            public frmUpdateQuantity(SparePart part)
            {
                this.Text = $"Update Quantity - {part.Name}";
                this.Size = new Size(350, 160);
                this.StartPosition = FormStartPosition.CenterParent;
                this.BackColor = Color.FromArgb(46, 51, 73);
                var num = new NumericUpDown { Location = new Point(130, 50), Size = new Size(120, 25), Minimum = 0, Maximum = 9999, Value = part.Quantity };
                var btnUpdate = new Button { Text = "Update", Location = new Point(130, 90), Size = new Size(80, 35), BackColor = Color.FromArgb(0, 126, 249), ForeColor = Color.White, FlatStyle = FlatStyle.Flat };
                btnUpdate.Click += (s, e) => { NewQuantity = (int)num.Value; this.DialogResult = DialogResult.OK; this.Close(); };
                var btnCancel = new Button { Text = "Cancel", Location = new Point(220, 90), Size = new Size(80, 35), BackColor = Color.FromArgb(64, 64, 64), ForeColor = Color.White, FlatStyle = FlatStyle.Flat };
                btnCancel.Click += (s, e) => { this.DialogResult = DialogResult.Cancel; this.Close(); };
                this.Controls.AddRange(new Control[] { new Label { Text = $"Current: {part.Quantity} {part.Unit}", Location = new Point(20, 20), ForeColor = Color.White },
                    new Label { Text = "New Quantity:", Location = new Point(20, 52), ForeColor = Color.White }, num, btnUpdate, btnCancel });
            }
        }

        private class frmUpdatePrice : Form
        {
            public double NewPrice { get; private set; }
            public frmUpdatePrice(SparePart part)
            {
                this.Text = $"Update Price - {part.Name}";
                this.Size = new Size(350, 160);
                this.StartPosition = FormStartPosition.CenterParent;
                this.BackColor = Color.FromArgb(46, 51, 73);
                var txt = new TextBox { Location = new Point(130, 50), Size = new Size(120, 25), BackColor = Color.FromArgb(55, 61, 83), ForeColor = Color.White, Text = part.Price.ToString("F2") };
                var btnUpdate = new Button { Text = "Update", Location = new Point(130, 90), Size = new Size(80, 35), BackColor = Color.FromArgb(0, 126, 249), ForeColor = Color.White, FlatStyle = FlatStyle.Flat };
                btnUpdate.Click += (s, e) => { if (double.TryParse(txt.Text, out double p) && p > 0) { NewPrice = p; this.DialogResult = DialogResult.OK; this.Close(); } else MessageBox.Show("Enter valid price!"); };
                var btnCancel = new Button { Text = "Cancel", Location = new Point(220, 90), Size = new Size(80, 35), BackColor = Color.FromArgb(64, 64, 64), ForeColor = Color.White, FlatStyle = FlatStyle.Flat };
                btnCancel.Click += (s, e) => { this.DialogResult = DialogResult.Cancel; this.Close(); };
                this.Controls.AddRange(new Control[] { new Label { Text = $"Current: ${part.Price:F2}", Location = new Point(20, 20), ForeColor = Color.White },
                    new Label { Text = "New Price ($):", Location = new Point(20, 52), ForeColor = Color.White }, txt, btnUpdate, btnCancel });
            }
        }
    }
}