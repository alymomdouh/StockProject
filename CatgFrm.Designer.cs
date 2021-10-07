namespace StockProject
{
    partial class CatgFrm
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
            this.catgview = new System.Windows.Forms.DataGridView();
            this.btndeletecatg = new System.Windows.Forms.Button();
            this.btnupdatecatg = new System.Windows.Forms.Button();
            this.catgnametxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnaddcatg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.catgview)).BeginInit();
            this.SuspendLayout();
            // 
            // catgview
            // 
            this.catgview.AllowUserToAddRows = false;
            this.catgview.AllowUserToDeleteRows = false;
            this.catgview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.catgview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.catgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.catgview.Location = new System.Drawing.Point(121, 154);
            this.catgview.Name = "catgview";
            this.catgview.ReadOnly = true;
            this.catgview.RowTemplate.Height = 26;
            this.catgview.Size = new System.Drawing.Size(397, 260);
            this.catgview.TabIndex = 17;
            this.catgview.SelectionChanged += new System.EventHandler(this.Catgview_SelectionChanged);
            // 
            // btndeletecatg
            // 
            this.btndeletecatg.Location = new System.Drawing.Point(596, 85);
            this.btndeletecatg.Name = "btndeletecatg";
            this.btndeletecatg.Size = new System.Drawing.Size(110, 32);
            this.btndeletecatg.TabIndex = 16;
            this.btndeletecatg.Text = "Delete";
            this.btndeletecatg.UseVisualStyleBackColor = true;
            this.btndeletecatg.Click += new System.EventHandler(this.Btndeletecatg_Click);
            // 
            // btnupdatecatg
            // 
            this.btnupdatecatg.Location = new System.Drawing.Point(432, 85);
            this.btnupdatecatg.Name = "btnupdatecatg";
            this.btnupdatecatg.Size = new System.Drawing.Size(110, 32);
            this.btnupdatecatg.TabIndex = 15;
            this.btnupdatecatg.Text = "Update";
            this.btnupdatecatg.UseVisualStyleBackColor = true;
            this.btnupdatecatg.Click += new System.EventHandler(this.Btnupdatecatg_Click);
            // 
            // catgnametxt
            // 
            this.catgnametxt.Location = new System.Drawing.Point(42, 90);
            this.catgnametxt.Name = "catgnametxt";
            this.catgnametxt.Size = new System.Drawing.Size(100, 24);
            this.catgnametxt.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Catg Name";
            // 
            // btnaddcatg
            // 
            this.btnaddcatg.Location = new System.Drawing.Point(258, 85);
            this.btnaddcatg.Name = "btnaddcatg";
            this.btnaddcatg.Size = new System.Drawing.Size(110, 32);
            this.btnaddcatg.TabIndex = 12;
            this.btnaddcatg.Text = "Add new";
            this.btnaddcatg.UseVisualStyleBackColor = true;
            this.btnaddcatg.Click += new System.EventHandler(this.Btnaddcatg_Click);
            // 
            // CatgFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.catgview);
            this.Controls.Add(this.btndeletecatg);
            this.Controls.Add(this.btnupdatecatg);
            this.Controls.Add(this.catgnametxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnaddcatg);
            this.Name = "CatgFrm";
            this.Text = "CatgFrm";
            this.Load += new System.EventHandler(this.CatgFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.catgview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView catgview;
        private System.Windows.Forms.Button btndeletecatg;
        private System.Windows.Forms.Button btnupdatecatg;
        private System.Windows.Forms.TextBox catgnametxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnaddcatg;
    }
}