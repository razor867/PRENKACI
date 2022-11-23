namespace PRENKACI.Modal
{
    partial class Mposition
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
            this.TbPosition = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Position";
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(17, 50);
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
            this.label2.Location = new System.Drawing.Point(17, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID";
            // 
            // TbID
            // 
            this.TbID.Location = new System.Drawing.Point(91, 109);
            this.TbID.Name = "TbID";
            this.TbID.Size = new System.Drawing.Size(272, 22);
            this.TbID.TabIndex = 3;
            // 
            // TbPosition
            // 
            this.TbPosition.Location = new System.Drawing.Point(91, 144);
            this.TbPosition.Name = "TbPosition";
            this.TbPosition.Size = new System.Drawing.Size(272, 22);
            this.TbPosition.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Position";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(17, 184);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 7;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(99, 183);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 23);
            this.BtnNew.TabIndex = 8;
            this.BtnNew.Text = "New";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(288, 184);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 9;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // Mposition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 237);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbPosition);
            this.Controls.Add(this.TbID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.label1);
            this.Name = "Mposition";
            this.Text = "Form Position";
            this.Load += new System.EventHandler(this.Mposition_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbID;
        private System.Windows.Forms.TextBox TbPosition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnDelete;
    }
}