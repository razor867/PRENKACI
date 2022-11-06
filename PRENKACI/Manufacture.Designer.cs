namespace PRENKACI
{
    partial class Manufacture
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
            this.DgvManufacture = new System.Windows.Forms.DataGridView();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TbSearch = new System.Windows.Forms.TextBox();
            this.BtnNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvManufacture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manufacture";
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(17, 48);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 1;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // DgvManufacture
            // 
            this.DgvManufacture.AllowUserToAddRows = false;
            this.DgvManufacture.AllowUserToDeleteRows = false;
            this.DgvManufacture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvManufacture.Location = new System.Drawing.Point(17, 151);
            this.DgvManufacture.Name = "DgvManufacture";
            this.DgvManufacture.ReadOnly = true;
            this.DgvManufacture.RowHeadersWidth = 51;
            this.DgvManufacture.RowTemplate.Height = 24;
            this.DgvManufacture.Size = new System.Drawing.Size(771, 272);
            this.DgvManufacture.TabIndex = 2;
            this.DgvManufacture.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DgvManufacture_MouseDoubleClick);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(17, 115);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 3;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // TbSearch
            // 
            this.TbSearch.Location = new System.Drawing.Point(99, 115);
            this.TbSearch.Name = "TbSearch";
            this.TbSearch.Size = new System.Drawing.Size(282, 22);
            this.TbSearch.TabIndex = 4;
            this.TbSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TbSearch_KeyUp);
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(99, 48);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 23);
            this.BtnNew.TabIndex = 5;
            this.BtnNew.Text = "New";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // Manufacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.TbSearch);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.DgvManufacture);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.label1);
            this.Name = "Manufacture";
            this.Text = "Manufacture";
            this.Load += new System.EventHandler(this.Manufacture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvManufacture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.DataGridView DgvManufacture;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox TbSearch;
        private System.Windows.Forms.Button BtnNew;
    }
}