namespace PRENKACI
{
    partial class Home
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PcPosition = new System.Windows.Forms.PictureBox();
            this.PcEmployee = new System.Windows.Forms.PictureBox();
            this.PcRentData = new System.Windows.Forms.PictureBox();
            this.PcCustomer = new System.Windows.Forms.PictureBox();
            this.PcVehicle = new System.Windows.Forms.PictureBox();
            this.PcManufacture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PcPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcRentData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcVehicle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcManufacture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRENKACI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "SISTEM INFORMASI RENTAL PRENKACI";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Manufacture";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(624, 14);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(125, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Vehicle";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(232, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Customer";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(337, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Rent Data";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(453, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "Employee";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(565, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "Position";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PcPosition
            // 
            this.PcPosition.Image = global::PRENKACI.Properties.Resources.position;
            this.PcPosition.Location = new System.Drawing.Point(565, 92);
            this.PcPosition.Name = "PcPosition";
            this.PcPosition.Size = new System.Drawing.Size(100, 58);
            this.PcPosition.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcPosition.TabIndex = 13;
            this.PcPosition.TabStop = false;
            this.PcPosition.Click += new System.EventHandler(this.PcPosition_Click);
            // 
            // PcEmployee
            // 
            this.PcEmployee.Image = global::PRENKACI.Properties.Resources.employee;
            this.PcEmployee.Location = new System.Drawing.Point(456, 92);
            this.PcEmployee.Name = "PcEmployee";
            this.PcEmployee.Size = new System.Drawing.Size(92, 58);
            this.PcEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcEmployee.TabIndex = 12;
            this.PcEmployee.TabStop = false;
            this.PcEmployee.Click += new System.EventHandler(this.PcEmployee_Click);
            // 
            // PcRentData
            // 
            this.PcRentData.Image = global::PRENKACI.Properties.Resources.Rent_Car;
            this.PcRentData.Location = new System.Drawing.Point(337, 92);
            this.PcRentData.Name = "PcRentData";
            this.PcRentData.Size = new System.Drawing.Size(100, 58);
            this.PcRentData.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcRentData.TabIndex = 9;
            this.PcRentData.TabStop = false;
            this.PcRentData.Click += new System.EventHandler(this.PcRentData_Click);
            // 
            // PcCustomer
            // 
            this.PcCustomer.Image = global::PRENKACI.Properties.Resources.man;
            this.PcCustomer.Location = new System.Drawing.Point(232, 92);
            this.PcCustomer.Name = "PcCustomer";
            this.PcCustomer.Size = new System.Drawing.Size(87, 58);
            this.PcCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcCustomer.TabIndex = 7;
            this.PcCustomer.TabStop = false;
            this.PcCustomer.Click += new System.EventHandler(this.PcCustomer_Click);
            // 
            // PcVehicle
            // 
            this.PcVehicle.Image = global::PRENKACI.Properties.Resources.car;
            this.PcVehicle.Location = new System.Drawing.Point(128, 92);
            this.PcVehicle.Name = "PcVehicle";
            this.PcVehicle.Size = new System.Drawing.Size(87, 58);
            this.PcVehicle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcVehicle.TabIndex = 5;
            this.PcVehicle.TabStop = false;
            this.PcVehicle.Click += new System.EventHandler(this.PcVehicle_Click);
            // 
            // PcManufacture
            // 
            this.PcManufacture.Image = global::PRENKACI.Properties.Resources.factory;
            this.PcManufacture.Location = new System.Drawing.Point(16, 92);
            this.PcManufacture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PcManufacture.Name = "PcManufacture";
            this.PcManufacture.Size = new System.Drawing.Size(96, 58);
            this.PcManufacture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcManufacture.TabIndex = 2;
            this.PcManufacture.TabStop = false;
            this.PcManufacture.Click += new System.EventHandler(this.PcManufacture_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PcPosition);
            this.Controls.Add(this.PcEmployee);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PcRentData);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PcCustomer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PcVehicle);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PcManufacture);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.PcPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcRentData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcVehicle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcManufacture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PcManufacture;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.PictureBox PcVehicle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox PcCustomer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox PcRentData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox PcEmployee;
        private System.Windows.Forms.PictureBox PcPosition;
        private System.Windows.Forms.Label label8;
    }
}

