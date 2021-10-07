namespace StockProject
{
    partial class StockFrm
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
            this.storeView = new System.Windows.Forms.DataGridView();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.stocknametxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.storeView)).BeginInit();
            this.SuspendLayout();
            // 
            // storeView
            // 
            this.storeView.AllowUserToAddRows = false;
            this.storeView.AllowUserToDeleteRows = false;
            this.storeView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.storeView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.storeView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storeView.Location = new System.Drawing.Point(129, 201);
            this.storeView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.storeView.Name = "storeView";
            this.storeView.ReadOnly = true;
            this.storeView.RowTemplate.Height = 26;
            this.storeView.Size = new System.Drawing.Size(614, 326);
            this.storeView.TabIndex = 11;
            this.storeView.SelectionChanged += new System.EventHandler(this.StoreView_SelectionChanged);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(783, 128);
            this.btndelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(110, 32);
            this.btndelete.TabIndex = 10;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.Btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(633, 128);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(110, 32);
            this.btnupdate.TabIndex = 9;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.Btnupdate_Click);
            // 
            // stocknametxt
            // 
            this.stocknametxt.Location = new System.Drawing.Point(206, 128);
            this.stocknametxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stocknametxt.Name = "stocknametxt";
            this.stocknametxt.Size = new System.Drawing.Size(179, 24);
            this.stocknametxt.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(78, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Stock Name";
            // 
            // btnadd
            // 
            this.btnadd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnadd.Location = new System.Drawing.Point(489, 126);
            this.btnadd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(110, 32);
            this.btnadd.TabIndex = 6;
            this.btnadd.Text = "Add new";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.Btnadd_Click);
            // 
            // StockFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1125, 658);
            this.Controls.Add(this.storeView);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.stocknametxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnadd);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StockFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " Stock";
            this.Load += new System.EventHandler(this.StockFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.storeView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView storeView;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox stocknametxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnadd;
    }
}