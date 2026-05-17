using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Service_Panel
{
    public partial class ucBillings : UserControl
    {
        private List<BillItem> billItems = new List<BillItem>();
        private List<ServiceItem> services;
        private List<PartItem> parts;

        public ucBillings()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(46, 51, 73);
            this.Dock = DockStyle.Fill;
        }

        private void ucBillings_Load(object sender, EventArgs e)
        {
            LoadSampleData();
            cmbCustomer.Items.AddRange(new[] { "John Smith - Toyota Camry", "Emma Davis - Honda Civic", "Robert Wilson - Ford Mustang", "Lisa Anderson - BMW X5", "Michael Lee - Tesla Model 3" });
            cmbPaymentMethod.SelectedIndex = -1;
        }

        private void LoadSampleData()
        {
            services = new List<ServiceItem>
            {
                new ServiceItem("SRV001", "Oil Change", 49.99),
                new ServiceItem("SRV002", "Full Service", 199.99),
                new ServiceItem("SRV003", "Brake Repair", 159.99),
                new ServiceItem("SRV004", "Engine Diagnosis", 129.99),
                new ServiceItem("SRV005", "Tire Rotation", 39.99),
                new ServiceItem("SRV006", "AC Service", 99.99),
                new ServiceItem("SRV007", "Battery Replacement", 79.99),
                new ServiceItem("SRV008", "Transmission Service", 299.99)
            };
            parts = new List<PartItem>
            {
                new PartItem("SP001", "Engine Oil 5W-30", 29.99),
                new PartItem("SP002", "Oil Filter", 12.99),
                new PartItem("SP003", "Air Filter", 19.99),
                new PartItem("SP004", "Brake Pads (Front)", 45.99),
                new PartItem("SP005", "Brake Pads (Rear)", 42.99),
                new PartItem("SP006", "Spark Plug", 8.99),
                new PartItem("SP007", "Battery 12V", 89.99),
                new PartItem("SP008", "Windshield Wiper", 15.99)
            };
            
            cmbService.Items.Clear();
            services.ForEach(s => cmbService.Items.Add($"{s.Name} - ${s.Price:F2}"));
            
            cmbPart.Items.Clear();
            parts.ForEach(p => cmbPart.Items.Add($"{p.Name} - ${p.Price:F2}"));
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            if (cmbService.SelectedIndex == -1) 
            { 
                MessageBox.Show("Please select a service first!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                return; 
            }
            
            var service = services[cmbService.SelectedIndex];
            
            if (!billItems.Any(i => i.ID == service.ID && i.Type == "Service"))
            {
                billItems.Add(new BillItem(service.ID, service.Name, "Service", service.Price, 1, service.Price));
                UpdateBillList();
                CalculateTotals();
                cmbService.SelectedIndex = -1;
            }
            else 
            {
                MessageBox.Show("This service is already added to the bill!", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            if (cmbPart.SelectedIndex == -1) 
            { 
                MessageBox.Show("Please select a part first!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                return; 
            }
            
            if (numQuantity.Value <= 0) 
            { 
                MessageBox.Show("Please enter a valid quantity!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                return; 
            }
            
            var part = parts[cmbPart.SelectedIndex];
            double total = part.Price * (int)numQuantity.Value;
            var existing = billItems.FirstOrDefault(i => i.ID == part.ID && i.Type == "Part");
            
            if (existing != null) 
            { 
                existing.Quantity += (int)numQuantity.Value; 
                existing.Total = existing.UnitPrice * existing.Quantity; 
            }
            else 
            { 
                billItems.Add(new BillItem(part.ID, part.Name, "Part", part.Price, (int)numQuantity.Value, total)); 
            }
            
            UpdateBillList();
            CalculateTotals();
            cmbPart.SelectedIndex = -1;
            numQuantity.Value = 1;
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (listBoxBillItems.SelectedIndex >= 0 && listBoxBillItems.SelectedItem.ToString() != "No items added yet")
            {
                string selectedItem = listBoxBillItems.SelectedItem.ToString();
                string name = selectedItem.Split('-')[0].Trim();
                billItems.RemoveAll(i => i.Name == name);
                UpdateBillList();
                CalculateTotals();
            }
            else if (listBoxBillItems.SelectedIndex >= 0)
            {
                MessageBox.Show("No items to remove!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select an item to remove!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClearBill_Click(object sender, EventArgs e)
        {
            if (billItems.Count == 0 && string.IsNullOrWhiteSpace(txtCustomerName.Text) && cmbCustomer.SelectedIndex == -1)
            {
                MessageBox.Show("Bill is already empty!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            if (MessageBox.Show("Are you sure you want to clear the entire bill?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                billItems.Clear(); 
                UpdateBillList(); 
                CalculateTotals();
                txtCustomerName.Clear(); 
                txtPhone.Clear(); 
                cmbCustomer.SelectedIndex = -1; 
                cmbPaymentMethod.SelectedIndex = -1;
                cmbService.SelectedIndex = -1;
                cmbPart.SelectedIndex = -1;
                numQuantity.Value = 1;
                lblPartPreview.Text = "Preview: $0.00";
            }
        }

        private void UpdateBillList()
        {
            listBoxBillItems.Items.Clear();
            if (billItems.Count == 0) 
            {
                listBoxBillItems.Items.Add("No items added yet");
            }
            else 
            {
                foreach (var i in billItems)
                {
                    listBoxBillItems.Items.Add($"{i.Name} - {i.Quantity} x ${i.UnitPrice:F2} = ${i.Total:F2}");
                }
            }
        }

        private void CalculateTotals()
        {
            double serviceTotal = billItems.Where(i => i.Type == "Service").Sum(i => i.Total);
            double partsTotal = billItems.Where(i => i.Type == "Part").Sum(i => i.Total);
            double subtotal = serviceTotal + partsTotal;
            double tax = subtotal * 0.10;
            double grandTotal = subtotal + tax;
            
            lblServiceTotal.Text = $"${serviceTotal:F2}";
            lblPartsTotal.Text = $"${partsTotal:F2}";
            lblSubtotal.Text = $"${subtotal:F2}";
            lblTax.Text = $"${tax:F2}";
            lblGrandTotal.Text = $"${grandTotal:F2}";
        }

        private void btnGenerateBill_Click(object sender, EventArgs e)
        {
            if (billItems.Count == 0) 
            { 
                MessageBox.Show("No items added to the bill!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                return; 
            }
            
            string customer = !string.IsNullOrWhiteSpace(txtCustomerName.Text) ? txtCustomerName.Text : (cmbCustomer.SelectedIndex >= 0 ? cmbCustomer.SelectedItem.ToString() : "");
            
            if (string.IsNullOrWhiteSpace(customer)) 
            { 
                MessageBox.Show("Please enter or select customer name!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                return; 
            }
            
            if (cmbPaymentMethod.SelectedIndex == -1) 
            { 
                MessageBox.Show("Please select payment method!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                return; 
            }

            string invoiceNo = $"INV-{DateTime.Now:yyyyMMdd}-{new Random().Next(1000, 9999)}";
            string bill = GenerateBill(invoiceNo, customer);
            
            frmBillPreview previewForm = new frmBillPreview(bill);
            previewForm.ShowDialog();

            if (MessageBox.Show("Bill generated successfully!\n\nDo you want to save this bill?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SaveFileDialog save = new SaveFileDialog 
                { 
                    Filter = "Text Files (*.txt)|*.txt", 
                    FileName = $"{invoiceNo}.txt" 
                };
                if (save.ShowDialog() == DialogResult.OK) 
                {
                    System.IO.File.WriteAllText(save.FileName, bill);
                    MessageBox.Show($"Bill saved successfully!\n\nLocation: {save.FileName}", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
            // Clear bill after generation
            billItems.Clear(); 
            UpdateBillList(); 
            CalculateTotals();
            txtCustomerName.Clear(); 
            txtPhone.Clear(); 
            cmbCustomer.SelectedIndex = -1; 
            cmbPaymentMethod.SelectedIndex = -1;
            cmbService.SelectedIndex = -1;
            cmbPart.SelectedIndex = -1;
            numQuantity.Value = 1;
            lblPartPreview.Text = "Preview: $0.00";
        }

        private string GenerateBill(string invoiceNo, string customer)
        {
            string b = $"╔══════════════════════════════════════════════════════════════════╗\n";
            b += $"║                    SERVICE BILLING INVOICE                         ║\n";
            b += $"╚══════════════════════════════════════════════════════════════════╝\n\n";
            b += $"Invoice Number: {invoiceNo}\n";
            b += $"Date: {DateTime.Now:dddd, MMMM dd, yyyy}\n";
            b += $"Time: {DateTime.Now:hh:mm tt}\n";
            b += $"Customer: {customer}\n";
            if (!string.IsNullOrWhiteSpace(txtPhone.Text))
                b += $"Phone: {txtPhone.Text}\n";
            b += $"\n{new string('─', 70)}\n";
            b += $"{"Item",-35} {"Qty",-5} {"Unit Price",-12} {"Total",-12}\n";
            b += $"{new string('─', 70)}\n";
            
            foreach (var i in billItems)
            {
                string itemName = i.Name.Length > 32 ? i.Name.Substring(0, 29) + "..." : i.Name;
                b += $"{itemName,-35} {i.Quantity,-5} ${i.UnitPrice,-11:F2} ${i.Total,-11:F2}\n";
            }
            
            b += $"{new string('─', 70)}\n";
            b += $"\n{"Service Total:",-45} ${lblServiceTotal.Text.Replace("$", "")}\n";
            b += $"{"Parts Total:",-45} ${lblPartsTotal.Text.Replace("$", "")}\n";
            b += $"{"Subtotal:",-45} ${lblSubtotal.Text.Replace("$", "")}\n";
            b += $"{"Tax (10%):",-45} ${lblTax.Text.Replace("$", "")}\n";
            b += $"{new string('═', 70)}\n";
            b += $"{"GRAND TOTAL:",-45} ${lblGrandTotal.Text.Replace("$", "")}\n";
            b += $"{new string('═', 70)}\n\n";
            b += $"Payment Method: {cmbPaymentMethod.SelectedItem}\n";
            b += $"\nThank you for choosing our service!\n";
            b += $"For any queries, please contact our support team.\n";
            
            return b;
        }

        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {
            if (cmbPart.SelectedIndex >= 0)
                lblPartPreview.Text = $"Preview: ${parts[cmbPart.SelectedIndex].Price * (int)numQuantity.Value:F2}";
            else
                lblPartPreview.Text = "Preview: $0.00";
        }

        private void cmbPart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPart.SelectedIndex >= 0)
            {
                numQuantity.Value = 1;
                lblPartPreview.Text = $"Preview: ${parts[cmbPart.SelectedIndex].Price:F2}";
            }
            else
            {
                lblPartPreview.Text = "Preview: $0.00";
            }
        }

        // Helper Classes
        private class ServiceItem 
        { 
            public string ID, Name; 
            public double Price; 
            public ServiceItem(string id, string name, double price) { ID = id; Name = name; Price = price; } 
        }
        
        private class PartItem 
        { 
            public string ID, Name; 
            public double Price; 
            public PartItem(string id, string name, double price) { ID = id; Name = name; Price = price; } 
        }
        
        private class BillItem 
        { 
            public string ID, Name, Type; 
            public double UnitPrice, Total; 
            public int Quantity; 
            public BillItem(string id, string name, string type, double price, int qty, double total) 
            { 
                ID = id; Name = name; Type = type; UnitPrice = price; Quantity = qty; Total = total; 
            } 
        }
    }

    public class frmBillPreview : Form
    {
        public frmBillPreview(string content)
        {
            this.Text = "Bill Preview";
            this.Size = new Size(550, 600);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            
            var txt = new TextBox 
            { 
                Location = new Point(10, 10), 
                Size = new Size(515, 510), 
                Multiline = true, 
                ReadOnly = true, 
                Font = new Font("Courier New", 9), 
                ScrollBars = ScrollBars.Vertical, 
                Text = content,
                BackColor = Color.White
            };
            
            var btn = new Button 
            { 
                Text = "Close", 
                Location = new Point(225, 530), 
                Size = new Size(100, 35), 
                BackColor = Color.FromArgb(0, 126, 249), 
                ForeColor = Color.White, 
                FlatStyle = FlatStyle.Flat, 
                DialogResult = DialogResult.OK 
            };
            
            this.Controls.AddRange(new Control[] { txt, btn });
        }
    }
}