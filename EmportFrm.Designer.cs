namespace StockProject
{
    partial class EmportFrm
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.importamounttxt = new System.Windows.Forms.TextBox();
            this.dataGridEmport = new System.Windows.Forms.DataGridView();
            this.datelabel = new System.Windows.Forms.Label();
            this.emportbtnadd = new System.Windows.Forms.Button();
            this.emportstorecombobox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmItemName = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmport)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label8.Location = new System.Drawing.Point(324, 136);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 24);
            this.label8.TabIndex = 24;
            this.label8.Text = "amount ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label7.Location = new System.Drawing.Point(40, 135);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 24);
            this.label7.TabIndex = 23;
            this.label7.Text = "item name";
            // 
            // importamounttxt
            // 
            this.importamounttxt.Location = new System.Drawing.Point(409, 133);
            this.importamounttxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.importamounttxt.Name = "importamounttxt";
            this.importamounttxt.Size = new System.Drawing.Size(134, 32);
            this.importamounttxt.TabIndex = 22;
            // 
            // dataGridEmport
            // 
            this.dataGridEmport.AllowUserToAddRows = false;
            this.dataGridEmport.AllowUserToDeleteRows = false;
            this.dataGridEmport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridEmport.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridEmport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmport.Location = new System.Drawing.Point(153, 209);
            this.dataGridEmport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridEmport.Name = "dataGridEmport";
            this.dataGridEmport.ReadOnly = true;
            this.dataGridEmport.RowTemplate.Height = 26;
            this.dataGridEmport.Size = new System.Drawing.Size(652, 239);
            this.dataGridEmport.TabIndex = 21;
            this.dataGridEmport.SelectionChanged += new System.EventHandler(this.dataGridEmport_SelectionChanged);
            // 
            // datelabel
            // 
            this.datelabel.AutoSize = true;
            this.datelabel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.datelabel.Location = new System.Drawing.Point(421, 45);
            this.datelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(229, 24);
            this.datelabel.TabIndex = 20;
            this.datelabel.Text = "today date time and day";
            // 
            // emportbtnadd
            // 
            this.emportbtnadd.Location = new System.Drawing.Point(589, 123);
            this.emportbtnadd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.emportbtnadd.Name = "emportbtnadd";
            this.emportbtnadd.Size = new System.Drawing.Size(98, 44);
            this.emportbtnadd.TabIndex = 18;
            this.emportbtnadd.Text = "Add";
            this.emportbtnadd.UseVisualStyleBackColor = true;
            this.emportbtnadd.Click += new System.EventHandler(this.emportbtnadd_Click);
            // 
            // emportstorecombobox
            // 
            this.emportstorecombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.emportstorecombobox.FormattingEnabled = true;
            this.emportstorecombobox.Location = new System.Drawing.Point(153, 42);
            this.emportstorecombobox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.emportstorecombobox.Name = "emportstorecombobox";
            this.emportstorecombobox.Size = new System.Drawing.Size(138, 32);
            this.emportstorecombobox.TabIndex = 17;
            this.emportstorecombobox.SelectedIndexChanged += new System.EventHandler(this.emportstorecombobox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label5.Location = new System.Drawing.Point(40, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "select store";
            // 
            // cmItemName
            // 
            this.cmItemName.FormattingEnabled = true;
            this.cmItemName.Location = new System.Drawing.Point(153, 131);
            this.cmItemName.Margin = new System.Windows.Forms.Padding(4);
            this.cmItemName.Name = "cmItemName";
            this.cmItemName.Size = new System.Drawing.Size(138, 32);
            this.cmItemName.TabIndex = 25;
            this.cmItemName.SelectedIndexChanged += new System.EventHandler(this.cmItemName_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // EmportFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 535);
            this.Controls.Add(this.cmItemName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.importamounttxt);
            this.Controls.Add(this.dataGridEmport);
            this.Controls.Add(this.datelabel);
            this.Controls.Add(this.emportbtnadd);
            this.Controls.Add(this.emportstorecombobox);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "EmportFrm";
            this.Text = "EmportFrm";
            this.Load += new System.EventHandler(this.EmportFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox importamounttxt;
        private System.Windows.Forms.DataGridView dataGridEmport;
        private System.Windows.Forms.Label datelabel;
        private System.Windows.Forms.Button emportbtnadd;
        private System.Windows.Forms.ComboBox emportstorecombobox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmItemName;
        private System.Windows.Forms.Timer timer1;
    }
}