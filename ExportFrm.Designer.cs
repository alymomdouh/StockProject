namespace StockProject
{
    partial class ExportFrm
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
            this.components = new System.ComponentModel.Container();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.exportamounttxt = new System.Windows.Forms.TextBox();
            this.exportview = new System.Windows.Forms.DataGridView();
            this.exportbtnadd = new System.Windows.Forms.Button();
            this.exportstorecombox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmboxitemexport = new System.Windows.Forms.ComboBox();
            this.TimerExport = new System.Windows.Forms.Timer(this.components);
            this.datelabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.exportview)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label9.Location = new System.Drawing.Point(454, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 24);
            this.label9.TabIndex = 33;
            this.label9.Text = "amount ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label10.Location = new System.Drawing.Point(55, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 24);
            this.label10.TabIndex = 32;
            this.label10.Text = "item name";
            // 
            // exportamounttxt
            // 
            this.exportamounttxt.Location = new System.Drawing.Point(562, 146);
            this.exportamounttxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exportamounttxt.Name = "exportamounttxt";
            this.exportamounttxt.Size = new System.Drawing.Size(158, 24);
            this.exportamounttxt.TabIndex = 31;
            // 
            // exportview
            // 
            this.exportview.AllowUserToAddRows = false;
            this.exportview.AllowUserToDeleteRows = false;
            this.exportview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.exportview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.exportview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.exportview.Location = new System.Drawing.Point(59, 219);
            this.exportview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exportview.MultiSelect = false;
            this.exportview.Name = "exportview";
            this.exportview.ReadOnly = true;
            this.exportview.RowTemplate.Height = 26;
            this.exportview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.exportview.Size = new System.Drawing.Size(847, 347);
            this.exportview.TabIndex = 30;
            this.exportview.SelectionChanged += new System.EventHandler(this.exportview_SelectionChanged);
            // 
            // exportbtnadd
            // 
            this.exportbtnadd.Location = new System.Drawing.Point(780, 144);
            this.exportbtnadd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exportbtnadd.Name = "exportbtnadd";
            this.exportbtnadd.Size = new System.Drawing.Size(75, 39);
            this.exportbtnadd.TabIndex = 27;
            this.exportbtnadd.Text = "Add";
            this.exportbtnadd.UseVisualStyleBackColor = true;
            this.exportbtnadd.Click += new System.EventHandler(this.exportbtnadd_Click);
            // 
            // exportstorecombox
            // 
            this.exportstorecombox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.exportstorecombox.FormattingEnabled = true;
            this.exportstorecombox.Location = new System.Drawing.Point(190, 58);
            this.exportstorecombox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exportstorecombox.Name = "exportstorecombox";
            this.exportstorecombox.Size = new System.Drawing.Size(164, 24);
            this.exportstorecombox.TabIndex = 26;
            this.exportstorecombox.SelectedIndexChanged += new System.EventHandler(this.exportstorecombox_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label12.Location = new System.Drawing.Point(55, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 24);
            this.label12.TabIndex = 25;
            this.label12.Text = "select store";
            // 
            // cmboxitemexport
            // 
            this.cmboxitemexport.FormattingEnabled = true;
            this.cmboxitemexport.Location = new System.Drawing.Point(190, 142);
            this.cmboxitemexport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmboxitemexport.Name = "cmboxitemexport";
            this.cmboxitemexport.Size = new System.Drawing.Size(164, 24);
            this.cmboxitemexport.TabIndex = 34;
            // 
            // TimerExport
            // 
            this.TimerExport.Enabled = true;
            this.TimerExport.Interval = 1000;
            this.TimerExport.Tick += new System.EventHandler(this.TimerExport_Tick);
            // 
            // datelabel
            // 
            this.datelabel.AutoSize = true;
            this.datelabel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.datelabel.Location = new System.Drawing.Point(442, 58);
            this.datelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(229, 24);
            this.datelabel.TabIndex = 35;
            this.datelabel.Text = "today date time and day";
            // 
            // ExportFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 658);
            this.Controls.Add(this.datelabel);
            this.Controls.Add(this.cmboxitemexport);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.exportamounttxt);
            this.Controls.Add(this.exportview);
            this.Controls.Add(this.exportbtnadd);
            this.Controls.Add(this.exportstorecombox);
            this.Controls.Add(this.label12);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ExportFrm";
            this.Text = "ExportFrm";
            this.Load += new System.EventHandler(this.ExportFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exportview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox exportamounttxt;
        private System.Windows.Forms.DataGridView exportview;
        private System.Windows.Forms.Button exportbtnadd;
        private System.Windows.Forms.ComboBox exportstorecombox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmboxitemexport;
        private System.Windows.Forms.Timer TimerExport;
        private System.Windows.Forms.Label datelabel;
    }
}