namespace PRENKACI.Modal
{
    partial class Mcustomer
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
            this.TbName = new System.Windows.Forms.TextBox();
            this.DtBorn = new System.Windows.Forms.DateTimePicker();
            this.TbBornPlace = new System.Windows.Forms.TextBox();
            this.TbNik = new System.Windows.Forms.TextBox();
            this.CbGender = new System.Windows.Forms.ComboBox();
            this.TbAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Customer";
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(17, 49);
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
            this.label2.Location = new System.Drawing.Point(14, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID";
            // 
            // TbID
            // 
            this.TbID.Location = new System.Drawing.Point(99, 108);
            this.TbID.Name = "TbID";
            this.TbID.Size = new System.Drawing.Size(245, 22);
            this.TbID.TabIndex = 3;
            // 
            // TbName
            // 
            this.TbName.Location = new System.Drawing.Point(99, 138);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(245, 22);
            this.TbName.TabIndex = 4;
            // 
            // DtBorn
            // 
            this.DtBorn.Location = new System.Drawing.Point(99, 167);
            this.DtBorn.Name = "DtBorn";
            this.DtBorn.Size = new System.Drawing.Size(245, 22);
            this.DtBorn.TabIndex = 5;
            // 
            // TbBornPlace
            // 
            this.TbBornPlace.Location = new System.Drawing.Point(99, 195);
            this.TbBornPlace.Name = "TbBornPlace";
            this.TbBornPlace.Size = new System.Drawing.Size(245, 22);
            this.TbBornPlace.TabIndex = 6;
            // 
            // TbNik
            // 
            this.TbNik.Location = new System.Drawing.Point(99, 224);
            this.TbNik.Name = "TbNik";
            this.TbNik.Size = new System.Drawing.Size(245, 22);
            this.TbNik.TabIndex = 7;
            // 
            // CbGender
            // 
            this.CbGender.FormattingEnabled = true;
            this.CbGender.Items.AddRange(new object[] {
            "Laki-laki",
            "Perempuan"});
            this.CbGender.Location = new System.Drawing.Point(99, 253);
            this.CbGender.Name = "CbGender";
            this.CbGender.Size = new System.Drawing.Size(158, 24);
            this.CbGender.TabIndex = 8;
            // 
            // TbAddress
            // 
            this.TbAddress.Location = new System.Drawing.Point(99, 283);
            this.TbAddress.Name = "TbAddress";
            this.TbAddress.Size = new System.Drawing.Size(245, 22);
            this.TbAddress.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Born";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Born Place";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "NIK";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Gender";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Address";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(17, 331);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 16;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(99, 330);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 23);
            this.BtnNew.TabIndex = 17;
            this.BtnNew.Text = "New";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(269, 331);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 18;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // Mcustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 450);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbAddress);
            this.Controls.Add(this.CbGender);
            this.Controls.Add(this.TbNik);
            this.Controls.Add(this.TbBornPlace);
            this.Controls.Add(this.DtBorn);
            this.Controls.Add(this.TbName);
            this.Controls.Add(this.TbID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.label1);
            this.Name = "Mcustomer";
            this.Text = "Form Customer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mcustomer_FormClosing);
            this.Load += new System.EventHandler(this.Mcustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbID;
        private System.Windows.Forms.TextBox TbName;
        private System.Windows.Forms.DateTimePicker DtBorn;
        private System.Windows.Forms.TextBox TbBornPlace;
        private System.Windows.Forms.TextBox TbNik;
        private System.Windows.Forms.ComboBox CbGender;
        private System.Windows.Forms.TextBox TbAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnDelete;
    }
}