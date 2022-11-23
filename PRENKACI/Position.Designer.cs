namespace PRENKACI
{
    partial class Position
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
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.DgvPosition = new System.Windows.Forms.DataGridView();
            this.TbSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPosition)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Position";
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(17, 54);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 1;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(99, 53);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 23);
            this.BtnNew.TabIndex = 2;
            this.BtnNew.Text = "New";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(17, 131);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 3;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // DgvPosition
            // 
            this.DgvPosition.AllowUserToAddRows = false;
            this.DgvPosition.AllowUserToDeleteRows = false;
            this.DgvPosition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPosition.Location = new System.Drawing.Point(17, 161);
            this.DgvPosition.Name = "DgvPosition";
            this.DgvPosition.ReadOnly = true;
            this.DgvPosition.RowHeadersWidth = 51;
            this.DgvPosition.RowTemplate.Height = 24;
            this.DgvPosition.Size = new System.Drawing.Size(771, 277);
            this.DgvPosition.TabIndex = 4;
            this.DgvPosition.DoubleClick += new System.EventHandler(this.DgvPosition_DoubleClick);
            // 
            // TbSearch
            // 
            this.TbSearch.Location = new System.Drawing.Point(99, 131);
            this.TbSearch.Name = "TbSearch";
            this.TbSearch.Size = new System.Drawing.Size(291, 22);
            this.TbSearch.TabIndex = 5;
            // 
            // Position
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TbSearch);
            this.Controls.Add(this.DgvPosition);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.label1);
            this.Name = "Position";
            this.Text = "Position";
            this.Load += new System.EventHandler(this.Position_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPosition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.DataGridView DgvPosition;
        private System.Windows.Forms.TextBox TbSearch;
    }
}