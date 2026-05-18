namespace salesexecutivepanel
{
    partial class Payment_info
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.closebtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttotalcustomer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcustomerbought = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtearnedfromcars = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtordernumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtordervalue = new System.Windows.Forms.TextBox();
            this.btnshow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // closebtn
            // 
            this.closebtn.BackColor = System.Drawing.Color.Red;
            this.closebtn.ForeColor = System.Drawing.Color.White;
            this.closebtn.Location = new System.Drawing.Point(759, 1);
            this.closebtn.Margin = new System.Windows.Forms.Padding(4);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(40, 28);
            this.closebtn.TabIndex = 3;
            this.closebtn.Text = "X";
            this.closebtn.UseVisualStyleBackColor = false;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(272, 21);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(215, 39);
            this.label8.TabIndex = 19;
            this.label8.Text = "Payment info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(121, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Total customers:";
            // 
            // txttotalcustomer
            // 
            this.txttotalcustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalcustomer.Location = new System.Drawing.Point(418, 156);
            this.txttotalcustomer.Margin = new System.Windows.Forms.Padding(4);
            this.txttotalcustomer.Name = "txttotalcustomer";
            this.txttotalcustomer.Size = new System.Drawing.Size(144, 29);
            this.txttotalcustomer.TabIndex = 21;
            this.txttotalcustomer.TextChanged += new System.EventHandler(this.txttotalcustomer_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(121, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "No. of customers bought cars:";
            // 
            // txtcustomerbought
            // 
            this.txtcustomerbought.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustomerbought.Location = new System.Drawing.Point(418, 206);
            this.txtcustomerbought.Margin = new System.Windows.Forms.Padding(4);
            this.txtcustomerbought.Name = "txtcustomerbought";
            this.txtcustomerbought.Size = new System.Drawing.Size(144, 29);
            this.txtcustomerbought.TabIndex = 23;
            this.txtcustomerbought.TextChanged += new System.EventHandler(this.txtcustomerbought_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(121, 256);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Total earned from selling cars:";
            // 
            // txtearnedfromcars
            // 
            this.txtearnedfromcars.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtearnedfromcars.Location = new System.Drawing.Point(418, 256);
            this.txtearnedfromcars.Margin = new System.Windows.Forms.Padding(4);
            this.txtearnedfromcars.Name = "txtearnedfromcars";
            this.txtearnedfromcars.Size = new System.Drawing.Size(144, 29);
            this.txtearnedfromcars.TabIndex = 25;
            this.txtearnedfromcars.TextChanged += new System.EventHandler(this.txtearnedfromcars_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(121, 316);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Orders given from company:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtordernumber
            // 
            this.txtordernumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtordernumber.Location = new System.Drawing.Point(418, 314);
            this.txtordernumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtordernumber.Name = "txtordernumber";
            this.txtordernumber.Size = new System.Drawing.Size(144, 29);
            this.txtordernumber.TabIndex = 27;
            this.txtordernumber.TextChanged += new System.EventHandler(this.txtordernumber_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(121, 369);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Order value:";
            // 
            // txtordervalue
            // 
            this.txtordervalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtordervalue.Location = new System.Drawing.Point(418, 369);
            this.txtordervalue.Margin = new System.Windows.Forms.Padding(4);
            this.txtordervalue.Name = "txtordervalue";
            this.txtordervalue.Size = new System.Drawing.Size(144, 29);
            this.txtordervalue.TabIndex = 29;
            this.txtordervalue.TextChanged += new System.EventHandler(this.txtordervalue_TextChanged);
            // 
            // btnshow
            // 
            this.btnshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshow.Location = new System.Drawing.Point(316, 451);
            this.btnshow.Margin = new System.Windows.Forms.Padding(4);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(100, 38);
            this.btnshow.TabIndex = 30;
            this.btnshow.Text = "Fetch";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // Payment_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(799, 694);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.txtordervalue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtordernumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtearnedfromcars);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcustomerbought);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttotalcustomer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.closebtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Payment_info";
            this.Text = "Payment_info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttotalcustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcustomerbought;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtearnedfromcars;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtordernumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtordervalue;
        private System.Windows.Forms.Button btnshow;
    }
}