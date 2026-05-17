namespace Service_Panel
{
    partial class ucBillings
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.groupBoxServices = new System.Windows.Forms.GroupBox();
            this.btnAddService = new System.Windows.Forms.Button();
            this.cmbService = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxParts = new System.Windows.Forms.GroupBox();
            this.lblPartPreview = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddPart = new System.Windows.Forms.Button();
            this.cmbPart = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxCustomer = new System.Windows.Forms.GroupBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.groupBoxBillItems = new System.Windows.Forms.GroupBox();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.listBoxBillItems = new System.Windows.Forms.ListBox();
            this.groupBoxTotals = new System.Windows.Forms.GroupBox();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblPartsTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblServiceTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxPayment = new System.Windows.Forms.GroupBox();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnClearBill = new System.Windows.Forms.Button();
            this.btnGenerateBill = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.groupBoxServices.SuspendLayout();
            this.groupBoxParts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.groupBoxCustomer.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.groupBoxBillItems.SuspendLayout();
            this.groupBoxTotals.SuspendLayout();
            this.groupBoxPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.panelLeft);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.panelRight);
            this.splitContainer.Size = new System.Drawing.Size(534, 490);
            this.splitContainer.SplitterDistance = 240;
            this.splitContainer.TabIndex = 0;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.groupBoxServices);
            this.panelLeft.Controls.Add(this.groupBoxParts);
            this.panelLeft.Controls.Add(this.groupBoxCustomer);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(3);
            this.panelLeft.Size = new System.Drawing.Size(240, 490);
            this.panelLeft.TabIndex = 0;
            // 
            // groupBoxServices
            // 
            this.groupBoxServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.groupBoxServices.Controls.Add(this.btnAddService);
            this.groupBoxServices.Controls.Add(this.cmbService);
            this.groupBoxServices.Controls.Add(this.label1);
            this.groupBoxServices.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxServices.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxServices.ForeColor = System.Drawing.Color.White;
            this.groupBoxServices.Location = new System.Drawing.Point(3, 323);
            this.groupBoxServices.Name = "groupBoxServices";
            this.groupBoxServices.Size = new System.Drawing.Size(234, 136);
            this.groupBoxServices.TabIndex = 0;
            this.groupBoxServices.TabStop = false;
            this.groupBoxServices.Text = "Add Service";
            // 
            // btnAddService
            // 
            this.btnAddService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAddService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddService.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnAddService.ForeColor = System.Drawing.Color.White;
            this.btnAddService.Location = new System.Drawing.Point(75, 49);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(95, 35);
            this.btnAddService.TabIndex = 2;
            this.btnAddService.Text = "Add →";
            this.btnAddService.UseVisualStyleBackColor = false;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // cmbService
            // 
            this.cmbService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.cmbService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbService.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cmbService.ForeColor = System.Drawing.Color.White;
            this.cmbService.FormattingEnabled = true;
            this.cmbService.Location = new System.Drawing.Point(65, 22);
            this.cmbService.Name = "cmbService";
            this.cmbService.Size = new System.Drawing.Size(160, 21);
            this.cmbService.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Service:";
            // 
            // groupBoxParts
            // 
            this.groupBoxParts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.groupBoxParts.Controls.Add(this.lblPartPreview);
            this.groupBoxParts.Controls.Add(this.numQuantity);
            this.groupBoxParts.Controls.Add(this.label4);
            this.groupBoxParts.Controls.Add(this.btnAddPart);
            this.groupBoxParts.Controls.Add(this.cmbPart);
            this.groupBoxParts.Controls.Add(this.label3);
            this.groupBoxParts.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxParts.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxParts.ForeColor = System.Drawing.Color.White;
            this.groupBoxParts.Location = new System.Drawing.Point(3, 168);
            this.groupBoxParts.Name = "groupBoxParts";
            this.groupBoxParts.Size = new System.Drawing.Size(234, 155);
            this.groupBoxParts.TabIndex = 1;
            this.groupBoxParts.TabStop = false;
            this.groupBoxParts.Text = "Add Spare Part";
            // 
            // lblPartPreview
            // 
            this.lblPartPreview.AutoSize = true;
            this.lblPartPreview.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblPartPreview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.lblPartPreview.Location = new System.Drawing.Point(75, 125);
            this.lblPartPreview.Name = "lblPartPreview";
            this.lblPartPreview.Size = new System.Drawing.Size(81, 13);
            this.lblPartPreview.TabIndex = 5;
            this.lblPartPreview.Text = "Preview: $0.00";
            // 
            // numQuantity
            // 
            this.numQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.numQuantity.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.numQuantity.ForeColor = System.Drawing.Color.White;
            this.numQuantity.Location = new System.Drawing.Point(75, 85);
            this.numQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(80, 22);
            this.numQuantity.TabIndex = 4;
            this.numQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantity.ValueChanged += new System.EventHandler(this.numQuantity_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(10, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity:";
            // 
            // btnAddPart
            // 
            this.btnAddPart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAddPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPart.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnAddPart.ForeColor = System.Drawing.Color.White;
            this.btnAddPart.Location = new System.Drawing.Point(75, 47);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(95, 35);
            this.btnAddPart.TabIndex = 2;
            this.btnAddPart.Text = "Add →";
            this.btnAddPart.UseVisualStyleBackColor = false;
            this.btnAddPart.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // cmbPart
            // 
            this.cmbPart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.cmbPart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPart.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cmbPart.ForeColor = System.Drawing.Color.White;
            this.cmbPart.FormattingEnabled = true;
            this.cmbPart.Location = new System.Drawing.Point(75, 22);
            this.cmbPart.Name = "cmbPart";
            this.cmbPart.Size = new System.Drawing.Size(150, 21);
            this.cmbPart.TabIndex = 1;
            this.cmbPart.SelectedIndexChanged += new System.EventHandler(this.cmbPart_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(10, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Spare Part:";
            // 
            // groupBoxCustomer
            // 
            this.groupBoxCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.groupBoxCustomer.Controls.Add(this.txtPhone);
            this.groupBoxCustomer.Controls.Add(this.label6);
            this.groupBoxCustomer.Controls.Add(this.cmbCustomer);
            this.groupBoxCustomer.Controls.Add(this.label5);
            this.groupBoxCustomer.Controls.Add(this.txtCustomerName);
            this.groupBoxCustomer.Controls.Add(this.label2);
            this.groupBoxCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxCustomer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxCustomer.ForeColor = System.Drawing.Color.White;
            this.groupBoxCustomer.Location = new System.Drawing.Point(3, 3);
            this.groupBoxCustomer.Name = "groupBoxCustomer";
            this.groupBoxCustomer.Size = new System.Drawing.Size(234, 165);
            this.groupBoxCustomer.TabIndex = 2;
            this.groupBoxCustomer.TabStop = false;
            this.groupBoxCustomer.Text = "Customer Information";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtPhone.ForeColor = System.Drawing.Color.White;
            this.txtPhone.Location = new System.Drawing.Point(100, 125);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(125, 22);
            this.txtPhone.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(10, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Phone (Opt):";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCustomer.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cmbCustomer.ForeColor = System.Drawing.Color.White;
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(100, 65);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(125, 21);
            this.cmbCustomer.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(10, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Or Select Client:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerName.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtCustomerName.ForeColor = System.Drawing.Color.White;
            this.txtCustomerName.Location = new System.Drawing.Point(100, 35);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(125, 22);
            this.txtCustomerName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(10, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customer Name:";
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.groupBoxBillItems);
            this.panelRight.Controls.Add(this.groupBoxTotals);
            this.panelRight.Controls.Add(this.groupBoxPayment);
            this.panelRight.Controls.Add(this.btnClearBill);
            this.panelRight.Controls.Add(this.btnGenerateBill);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(0, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(3);
            this.panelRight.Size = new System.Drawing.Size(290, 490);
            this.panelRight.TabIndex = 0;
            // 
            // groupBoxBillItems
            // 
            this.groupBoxBillItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.groupBoxBillItems.Controls.Add(this.btnRemoveItem);
            this.groupBoxBillItems.Controls.Add(this.listBoxBillItems);
            this.groupBoxBillItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxBillItems.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxBillItems.ForeColor = System.Drawing.Color.White;
            this.groupBoxBillItems.Location = new System.Drawing.Point(3, 193);
            this.groupBoxBillItems.Name = "groupBoxBillItems";
            this.groupBoxBillItems.Size = new System.Drawing.Size(284, 190);
            this.groupBoxBillItems.TabIndex = 0;
            this.groupBoxBillItems.TabStop = false;
            this.groupBoxBillItems.Text = "Bill Items";
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItem.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnRemoveItem.ForeColor = System.Drawing.Color.White;
            this.btnRemoveItem.Location = new System.Drawing.Point(75, 145);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(139, 35);
            this.btnRemoveItem.TabIndex = 1;
            this.btnRemoveItem.Text = "Remove Selected Item";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // listBoxBillItems
            // 
            this.listBoxBillItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.listBoxBillItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxBillItems.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.listBoxBillItems.ForeColor = System.Drawing.Color.White;
            this.listBoxBillItems.FormattingEnabled = true;
            this.listBoxBillItems.Location = new System.Drawing.Point(10, 22);
            this.listBoxBillItems.Name = "listBoxBillItems";
            this.listBoxBillItems.Size = new System.Drawing.Size(264, 119);
            this.listBoxBillItems.TabIndex = 0;
            // 
            // groupBoxTotals
            // 
            this.groupBoxTotals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.groupBoxTotals.Controls.Add(this.lblGrandTotal);
            this.groupBoxTotals.Controls.Add(this.label14);
            this.groupBoxTotals.Controls.Add(this.lblTax);
            this.groupBoxTotals.Controls.Add(this.label12);
            this.groupBoxTotals.Controls.Add(this.lblSubtotal);
            this.groupBoxTotals.Controls.Add(this.label10);
            this.groupBoxTotals.Controls.Add(this.lblPartsTotal);
            this.groupBoxTotals.Controls.Add(this.label8);
            this.groupBoxTotals.Controls.Add(this.lblServiceTotal);
            this.groupBoxTotals.Controls.Add(this.label7);
            this.groupBoxTotals.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxTotals.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.groupBoxTotals.ForeColor = System.Drawing.Color.White;
            this.groupBoxTotals.Location = new System.Drawing.Point(3, 63);
            this.groupBoxTotals.Name = "groupBoxTotals";
            this.groupBoxTotals.Size = new System.Drawing.Size(284, 130);
            this.groupBoxTotals.TabIndex = 1;
            this.groupBoxTotals.TabStop = false;
            this.groupBoxTotals.Text = "Bill Summary";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblGrandTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.lblGrandTotal.Location = new System.Drawing.Point(180, 100);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(49, 20);
            this.lblGrandTotal.TabIndex = 9;
            this.lblGrandTotal.Text = "$0.00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(10, 102);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 15);
            this.label14.TabIndex = 8;
            this.label14.Text = "GRAND TOTAL:";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblTax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.lblTax.Location = new System.Drawing.Point(180, 75);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(34, 13);
            this.lblTax.TabIndex = 7;
            this.lblTax.Text = "$0.00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label12.ForeColor = System.Drawing.Color.LightGray;
            this.label12.Location = new System.Drawing.Point(10, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Tax (10%):";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSubtotal.ForeColor = System.Drawing.Color.White;
            this.lblSubtotal.Location = new System.Drawing.Point(180, 52);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(34, 13);
            this.lblSubtotal.TabIndex = 5;
            this.lblSubtotal.Text = "$0.00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label10.ForeColor = System.Drawing.Color.LightGray;
            this.label10.Location = new System.Drawing.Point(10, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Subtotal:";
            // 
            // lblPartsTotal
            // 
            this.lblPartsTotal.AutoSize = true;
            this.lblPartsTotal.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblPartsTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblPartsTotal.Location = new System.Drawing.Point(180, 32);
            this.lblPartsTotal.Name = "lblPartsTotal";
            this.lblPartsTotal.Size = new System.Drawing.Size(34, 13);
            this.lblPartsTotal.TabIndex = 3;
            this.lblPartsTotal.Text = "$0.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(10, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Parts Total:";
            // 
            // lblServiceTotal
            // 
            this.lblServiceTotal.AutoSize = true;
            this.lblServiceTotal.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblServiceTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblServiceTotal.Location = new System.Drawing.Point(180, 14);
            this.lblServiceTotal.Name = "lblServiceTotal";
            this.lblServiceTotal.Size = new System.Drawing.Size(34, 13);
            this.lblServiceTotal.TabIndex = 1;
            this.lblServiceTotal.Text = "$0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(10, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Service Total:";
            // 
            // groupBoxPayment
            // 
            this.groupBoxPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.groupBoxPayment.Controls.Add(this.cmbPaymentMethod);
            this.groupBoxPayment.Controls.Add(this.label9);
            this.groupBoxPayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxPayment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxPayment.ForeColor = System.Drawing.Color.White;
            this.groupBoxPayment.Location = new System.Drawing.Point(3, 3);
            this.groupBoxPayment.Name = "groupBoxPayment";
            this.groupBoxPayment.Size = new System.Drawing.Size(284, 60);
            this.groupBoxPayment.TabIndex = 2;
            this.groupBoxPayment.TabStop = false;
            this.groupBoxPayment.Text = "Payment";
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.cmbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cmbPaymentMethod.ForeColor = System.Drawing.Color.White;
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Items.AddRange(new object[] {
            "Cash",
            "Credit Card",
            "Debit Card",
            "Mobile Payment",
            "Bank Transfer"});
            this.cmbPaymentMethod.Location = new System.Drawing.Point(120, 25);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(150, 21);
            this.cmbPaymentMethod.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label9.ForeColor = System.Drawing.Color.LightGray;
            this.label9.Location = new System.Drawing.Point(10, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Payment Method:";
            // 
            // btnClearBill
            // 
            this.btnClearBill.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClearBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnClearBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearBill.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClearBill.ForeColor = System.Drawing.Color.White;
            this.btnClearBill.Location = new System.Drawing.Point(3, 399);
            this.btnClearBill.Name = "btnClearBill";
            this.btnClearBill.Size = new System.Drawing.Size(125, 34);
            this.btnClearBill.TabIndex = 4;
            this.btnClearBill.Text = "Clear Bill";
            this.btnClearBill.UseVisualStyleBackColor = false;
            this.btnClearBill.Click += new System.EventHandler(this.btnClearBill_Click);
            // 
            // btnGenerateBill
            // 
            this.btnGenerateBill.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGenerateBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnGenerateBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateBill.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGenerateBill.ForeColor = System.Drawing.Color.White;
            this.btnGenerateBill.Location = new System.Drawing.Point(137, 399);
            this.btnGenerateBill.Name = "btnGenerateBill";
            this.btnGenerateBill.Size = new System.Drawing.Size(140, 34);
            this.btnGenerateBill.TabIndex = 3;
            this.btnGenerateBill.Text = "Generate Bill";
            this.btnGenerateBill.UseVisualStyleBackColor = false;
            this.btnGenerateBill.Click += new System.EventHandler(this.btnGenerateBill_Click);
            // 
            // ucBillings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.splitContainer);
            this.Name = "ucBillings";
            this.Size = new System.Drawing.Size(534, 490);
            this.Load += new System.EventHandler(this.ucBillings_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.groupBoxServices.ResumeLayout(false);
            this.groupBoxServices.PerformLayout();
            this.groupBoxParts.ResumeLayout(false);
            this.groupBoxParts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.groupBoxCustomer.ResumeLayout(false);
            this.groupBoxCustomer.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.groupBoxBillItems.ResumeLayout(false);
            this.groupBoxTotals.ResumeLayout(false);
            this.groupBoxTotals.PerformLayout();
            this.groupBoxPayment.ResumeLayout(false);
            this.groupBoxPayment.PerformLayout();
            this.ResumeLayout(false);

        }

        // Control declarations
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.GroupBox groupBoxServices;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.ComboBox cmbService;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxParts;
        private System.Windows.Forms.Label lblPartPreview;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddPart;
        private System.Windows.Forms.ComboBox cmbPart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxCustomer;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.GroupBox groupBoxBillItems;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.ListBox listBoxBillItems;
        private System.Windows.Forms.GroupBox groupBoxTotals;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblPartsTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblServiceTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBoxPayment;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnClearBill;
        private System.Windows.Forms.Button btnGenerateBill;
    }
}