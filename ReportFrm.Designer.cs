namespace StockProject
{
    partial class ReportFrm
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
            this.exportview = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.reportcombox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.exportview)).BeginInit();
            this.SuspendLayout();
            // 
            // exportview
            // 
            this.exportview.AllowUserToAddRows = false;
            this.exportview.AllowUserToDeleteRows = false;
            this.exportview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.exportview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.exportview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.exportview.Location = new System.Drawing.Point(59, 194);
            this.exportview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exportview.Name = "exportview";
            this.exportview.ReadOnly = true;
            this.exportview.RowTemplate.Height = 26;
            this.exportview.Size = new System.Drawing.Size(909, 343);
            this.exportview.TabIndex = 30;
            this.exportview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.exportview_CellContentClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label11.Location = new System.Drawing.Point(516, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 24);
            this.label11.TabIndex = 29;
            this.label11.Text = "today date";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // reportcombox
            // 
            this.reportcombox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reportcombox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.reportcombox.FormattingEnabled = true;
            this.reportcombox.Location = new System.Drawing.Point(176, 116);
            this.reportcombox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportcombox.Name = "reportcombox";
            this.reportcombox.Size = new System.Drawing.Size(238, 32);
            this.reportcombox.TabIndex = 26;
            this.reportcombox.SelectedIndexChanged += new System.EventHandler(this.reportcombox_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label12.Location = new System.Drawing.Point(55, 119);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 24);
            this.label12.TabIndex = 25;
            this.label12.Text = "select store";
            // 
            // ReportFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 658);
            this.Controls.Add(this.exportview);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.reportcombox);
            this.Controls.Add(this.label12);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ReportFrm";
            this.Text = "ReportFrm";
            this.Load += new System.EventHandler(this.ReportFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exportview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView exportview;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox reportcombox;
        private System.Windows.Forms.Label label12;
    }
}