namespace PRENKACI.Modal
{
    partial class Mvehicle
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
            this.BtnBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TbID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TbName = new System.Windows.Forms.TextBox();
            this.TbColor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TbPoliceNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CbMovers = new System.Windows.Forms.ComboBox();
            this.CbManufacture = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Vehicle";
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(16, 45);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 1;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID";
            // 
            // TbID
            // 
            this.TbID.Location = new System.Drawing.Point(188, 113);
            this.TbID.Name = "TbID";
            this.TbID.Size = new System.Drawing.Size(192, 22);
            this.TbID.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nama Kendaraan";
            // 
            // TbName
            // 
            this.TbName.Location = new System.Drawing.Point(188, 141);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(192, 22);
            this.TbName.TabIndex = 5;
            // 
            // TbColor
            // 
            this.TbColor.Location = new System.Drawing.Point(188, 169);
            this.TbColor.Name = "TbColor";
            this.TbColor.Size = new System.Drawing.Size(192, 22);
            this.TbColor.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Warna";
            // 
            // TbPoliceNo
            // 
            this.TbPoliceNo.Location = new System.Drawing.Point(188, 197);
            this.TbPoliceNo.Name = "TbPoliceNo";
            this.TbPoliceNo.Size = new System.Drawing.Size(192, 22);
            this.TbPoliceNo.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nomor Polisi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(410, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Roda Penggerak";
            // 
            // CbMovers
            // 
            this.CbMovers.FormattingEnabled = true;
            this.CbMovers.Items.AddRange(new object[] {
            "Depan",
            "Belakang",
            "Depan Belakang"});
            this.CbMovers.Location = new System.Drawing.Point(557, 110);
            this.CbMovers.Name = "CbMovers";
            this.CbMovers.Size = new System.Drawing.Size(176, 24);
            this.CbMovers.TabIndex = 11;
            // 
            // CbManufacture
            // 
            this.CbManufacture.FormattingEnabled = true;
            this.CbManufacture.Location = new System.Drawing.Point(557, 138);
            this.CbManufacture.Name = "CbManufacture";
            this.CbManufacture.Size = new System.Drawing.Size(437, 24);
            this.CbManufacture.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(410, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Manufacture";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(16, 241);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 14;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(97, 241);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 15;
            this.BtnClear.Text = "New";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(304, 240);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 16;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // Mvehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 300);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CbManufacture);
            this.Controls.Add(this.CbMovers);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TbPoliceNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TbColor);
            this.Controls.Add(this.TbName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.label1);
            this.Name = "Mvehicle";
            this.Text = "Form Vehicle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mvehicle_FormClosing);
            this.Load += new System.EventHandler(this.Mvehicle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbName;
        private System.Windows.Forms.TextBox TbColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbPoliceNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CbMovers;
        private System.Windows.Forms.ComboBox CbManufacture;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnDelete;
    }
}