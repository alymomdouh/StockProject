namespace StockProject
{
    partial class ItemFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnitemimage = new System.Windows.Forms.Button();
            this.itemcatgcombox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.itemimage = new System.Windows.Forms.PictureBox();
            this.itemview = new System.Windows.Forms.DataGridView();
            this.Item_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Catg_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Catg_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Picture = new System.Windows.Forms.DataGridViewImageColumn();
            this.btndeleteitem = new System.Windows.Forms.Button();
            this.btnupdateitem = new System.Windows.Forms.Button();
            this.itemtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnadditem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.itemimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemview)).BeginInit();
            this.SuspendLayout();
            // 
            // btnitemimage
            // 
            this.btnitemimage.Location = new System.Drawing.Point(744, 197);
            this.btnitemimage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnitemimage.Name = "btnitemimage";
            this.btnitemimage.Size = new System.Drawing.Size(110, 43);
            this.btnitemimage.TabIndex = 26;
            this.btnitemimage.Text = "Select Iamge";
            this.btnitemimage.UseVisualStyleBackColor = true;
            this.btnitemimage.Click += new System.EventHandler(this.Btnitemimage_Click);
            // 
            // itemcatgcombox
            // 
            this.itemcatgcombox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemcatgcombox.FormattingEnabled = true;
            this.itemcatgcombox.Location = new System.Drawing.Point(903, 56);
            this.itemcatgcombox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemcatgcombox.Name = "itemcatgcombox";
            this.itemcatgcombox.Size = new System.Drawing.Size(150, 24);
            this.itemcatgcombox.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label13.Location = new System.Drawing.Point(748, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 24);
            this.label13.TabIndex = 24;
            this.label13.Text = "catg Name";
            // 
            // itemimage
            // 
            this.itemimage.Location = new System.Drawing.Point(877, 185);
            this.itemimage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemimage.Name = "itemimage";
            this.itemimage.Size = new System.Drawing.Size(176, 167);
            this.itemimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.itemimage.TabIndex = 23;
            this.itemimage.TabStop = false;
            // 
            // itemview
            // 
            this.itemview.AllowUserToAddRows = false;
            this.itemview.AllowUserToDeleteRows = false;
            this.itemview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item_ID,
            this.Item_Name,
            this.Catg_Name,
            this.Item_Catg_ID,
            this.Item_Image,
            this.Picture});
            this.itemview.Location = new System.Drawing.Point(2, 32);
            this.itemview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemview.MultiSelect = false;
            this.itemview.Name = "itemview";
            this.itemview.ReadOnly = true;
            this.itemview.RowTemplate.Height = 26;
            this.itemview.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.itemview.Size = new System.Drawing.Size(722, 572);
            this.itemview.TabIndex = 22;
            this.itemview.SelectionChanged += new System.EventHandler(this.Itemview_SelectionChanged);
            // 
            // Item_ID
            // 
            this.Item_ID.DataPropertyName = "Item_ID";
            this.Item_ID.FillWeight = 86.68597F;
            this.Item_ID.HeaderText = "Item ID";
            this.Item_ID.Name = "Item_ID";
            this.Item_ID.ReadOnly = true;
            // 
            // Item_Name
            // 
            this.Item_Name.DataPropertyName = "Item_Name";
            this.Item_Name.FillWeight = 117.0631F;
            this.Item_Name.HeaderText = "Item_Name";
            this.Item_Name.Name = "Item_Name";
            this.Item_Name.ReadOnly = true;
            this.Item_Name.Width = 150;
            // 
            // Catg_Name
            // 
            this.Catg_Name.DataPropertyName = "Catg_Name";
            this.Catg_Name.HeaderText = "Catg_Name";
            this.Catg_Name.Name = "Catg_Name";
            this.Catg_Name.ReadOnly = true;
            // 
            // Item_Catg_ID
            // 
            this.Item_Catg_ID.DataPropertyName = "Item_Catg_ID";
            this.Item_Catg_ID.FillWeight = 79.18782F;
            this.Item_Catg_ID.HeaderText = "Item_Catg_ID";
            this.Item_Catg_ID.Name = "Item_Catg_ID";
            this.Item_Catg_ID.ReadOnly = true;
            this.Item_Catg_ID.Visible = false;
            // 
            // Item_Image
            // 
            this.Item_Image.DataPropertyName = "Item_Image";
            this.Item_Image.HeaderText = "Item_Image";
            this.Item_Image.Name = "Item_Image";
            this.Item_Image.ReadOnly = true;
            this.Item_Image.Visible = false;
            // 
            // Picture
            // 
            this.Picture.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Picture.DataPropertyName = "Picture";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "Byte[]";
            this.Picture.DefaultCellStyle = dataGridViewCellStyle1;
            this.Picture.FillWeight = 117.0631F;
            this.Picture.HeaderText = "Picture";
            this.Picture.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Picture.Name = "Picture";
            this.Picture.ReadOnly = true;
            // 
            // btndeleteitem
            // 
            this.btndeleteitem.Location = new System.Drawing.Point(912, 409);
            this.btndeleteitem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndeleteitem.Name = "btndeleteitem";
            this.btndeleteitem.Size = new System.Drawing.Size(110, 43);
            this.btndeleteitem.TabIndex = 21;
            this.btndeleteitem.Text = "Delete";
            this.btndeleteitem.UseVisualStyleBackColor = true;
            this.btndeleteitem.Click += new System.EventHandler(this.Btndeleteitem_Click);
            // 
            // btnupdateitem
            // 
            this.btnupdateitem.Location = new System.Drawing.Point(744, 418);
            this.btnupdateitem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnupdateitem.Name = "btnupdateitem";
            this.btnupdateitem.Size = new System.Drawing.Size(110, 43);
            this.btnupdateitem.TabIndex = 20;
            this.btnupdateitem.Text = "Update";
            this.btnupdateitem.UseVisualStyleBackColor = true;
            this.btnupdateitem.Click += new System.EventHandler(this.Btnupdateitem_Click);
            // 
            // itemtxt
            // 
            this.itemtxt.Location = new System.Drawing.Point(903, 128);
            this.itemtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemtxt.Name = "itemtxt";
            this.itemtxt.Size = new System.Drawing.Size(150, 24);
            this.itemtxt.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(748, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Item Name";
            // 
            // btnadditem
            // 
            this.btnadditem.Location = new System.Drawing.Point(740, 309);
            this.btnadditem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnadditem.Name = "btnadditem";
            this.btnadditem.Size = new System.Drawing.Size(110, 43);
            this.btnadditem.TabIndex = 17;
            this.btnadditem.Text = "Add new";
            this.btnadditem.UseVisualStyleBackColor = true;
            this.btnadditem.Click += new System.EventHandler(this.Btnadditem_Click);
            // 
            // ItemFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1065, 630);
            this.Controls.Add(this.btnitemimage);
            this.Controls.Add(this.itemcatgcombox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.itemimage);
            this.Controls.Add(this.itemview);
            this.Controls.Add(this.btndeleteitem);
            this.Controls.Add(this.btnupdateitem);
            this.Controls.Add(this.itemtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnadditem);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ItemFrm";
            this.Text = "ItemFrm";
            this.Load += new System.EventHandler(this.ItemFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnitemimage;
        private System.Windows.Forms.ComboBox itemcatgcombox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox itemimage;
        private System.Windows.Forms.DataGridView itemview;
        private System.Windows.Forms.Button btndeleteitem;
        private System.Windows.Forms.Button btnupdateitem;
        private System.Windows.Forms.TextBox itemtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnadditem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Catg_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Catg_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Image;
        private System.Windows.Forms.DataGridViewImageColumn Picture;
    }
}