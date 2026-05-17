namespace Service_Panel
{
    partial class ucAppointment
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
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblServiceType = new System.Windows.Forms.Label();
            this.cmbServiceType = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblTime = new System.Windows.Forms.Label();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblVehicleModel = new System.Windows.Forms.Label();
            this.txtVehicleModel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblCustomerName.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblCustomerName.Location = new System.Drawing.Point(20, 34);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(141, 18);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "Customer Name :";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtCustomerName.ForeColor = System.Drawing.Color.White;
            this.txtCustomerName.Location = new System.Drawing.Point(170, 31);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(320, 24);
            this.txtCustomerName.TabIndex = 2;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblPhone.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblPhone.Location = new System.Drawing.Point(31, 71);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(130, 18);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Text = "Phone Number :";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtPhone.ForeColor = System.Drawing.Color.White;
            this.txtPhone.Location = new System.Drawing.Point(170, 71);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(320, 24);
            this.txtPhone.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblEmail.Location = new System.Drawing.Point(101, 111);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 18);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email :";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(170, 111);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(320, 24);
            this.txtEmail.TabIndex = 6;
            // 
            // lblServiceType
            // 
            this.lblServiceType.AutoSize = true;
            this.lblServiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblServiceType.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblServiceType.Location = new System.Drawing.Point(46, 191);
            this.lblServiceType.Name = "lblServiceType";
            this.lblServiceType.Size = new System.Drawing.Size(115, 18);
            this.lblServiceType.TabIndex = 9;
            this.lblServiceType.Text = "Service Type :";
            // 
            // cmbServiceType
            // 
            this.cmbServiceType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbServiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbServiceType.ForeColor = System.Drawing.Color.White;
            this.cmbServiceType.FormattingEnabled = true;
            this.cmbServiceType.Items.AddRange(new object[] {
            "Basic Service - $89",
            "Full Service - $199",
            "Oil Change - $49",
            "Tire Rotation - $39",
            "Engine Diagnosis - $129",
            "Brake Repair - $159",
            "AC Service - $99",
            "Battery Replacement - $79",
            "Transmission Service - $299",
            "Coolant Flush - $89"});
            this.cmbServiceType.Location = new System.Drawing.Point(170, 191);
            this.cmbServiceType.Name = "cmbServiceType";
            this.cmbServiceType.Size = new System.Drawing.Size(320, 26);
            this.cmbServiceType.TabIndex = 10;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblDate.Location = new System.Drawing.Point(56, 231);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(105, 18);
            this.lblDate.TabIndex = 11;
            this.lblDate.Text = "Select Date :";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(170, 231);
            this.dtpDate.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(150, 24);
            this.dtpDate.TabIndex = 12;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblTime.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblTime.Location = new System.Drawing.Point(49, 271);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(112, 18);
            this.lblTime.TabIndex = 13;
            this.lblTime.Text = "Select Time : ";
            // 
            // dtpTime
            // 
            this.dtpTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(170, 271);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(150, 24);
            this.dtpTime.TabIndex = 14;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblNotes.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblNotes.Location = new System.Drawing.Point(98, 311);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(63, 18);
            this.lblNotes.TabIndex = 15;
            this.lblNotes.Text = "Notes :";
            // 
            // txtNotes
            // 
            this.txtNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtNotes.ForeColor = System.Drawing.Color.White;
            this.txtNotes.Location = new System.Drawing.Point(170, 311);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(320, 80);
            this.txtNotes.TabIndex = 16;
            this.txtNotes.Text = "Enter additional notes...";
            this.txtNotes.Enter += new System.EventHandler(this.txtNotes_Enter);
            this.txtNotes.Leave += new System.EventHandler(this.txtNotes_Leave);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(201, 414);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(119, 33);
            this.btnSubmit.TabIndex = 17;
            this.btnSubmit.Text = "BOOK APPOINTMENT";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(340, 414);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(129, 33);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblVehicleModel
            // 
            this.lblVehicleModel.AutoSize = true;
            this.lblVehicleModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblVehicleModel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblVehicleModel.Location = new System.Drawing.Point(38, 151);
            this.lblVehicleModel.Name = "lblVehicleModel";
            this.lblVehicleModel.Size = new System.Drawing.Size(123, 18);
            this.lblVehicleModel.TabIndex = 7;
            this.lblVehicleModel.Text = "Vehicle Model :";
            // 
            // txtVehicleModel
            // 
            this.txtVehicleModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtVehicleModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtVehicleModel.ForeColor = System.Drawing.Color.White;
            this.txtVehicleModel.Location = new System.Drawing.Point(170, 151);
            this.txtVehicleModel.Name = "txtVehicleModel";
            this.txtVehicleModel.Size = new System.Drawing.Size(320, 24);
            this.txtVehicleModel.TabIndex = 8;
            // 
            // ucAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.cmbServiceType);
            this.Controls.Add(this.lblServiceType);
            this.Controls.Add(this.txtVehicleModel);
            this.Controls.Add(this.lblVehicleModel);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblCustomerName);
            this.Name = "ucAppointment";
            this.Size = new System.Drawing.Size(534, 490);
            this.Load += new System.EventHandler(this.ucAppointment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblVehicleModel;
        private System.Windows.Forms.TextBox txtVehicleModel;
        private System.Windows.Forms.Label lblServiceType;
        private System.Windows.Forms.ComboBox cmbServiceType;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
    }
}