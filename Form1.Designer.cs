namespace AdoNetProjectExample
{
	partial class ProductDetails
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
			this.dgvUrunListesi = new System.Windows.Forms.DataGridView();
			this.gbProduct = new System.Windows.Forms.GroupBox();
			this.btnGuncelle = new System.Windows.Forms.Button();
			this.btnSil = new System.Windows.Forms.Button();
			this.btnEkle = new System.Windows.Forms.Button();
			this.txtDescription = new System.Windows.Forms.RichTextBox();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.lblActive = new System.Windows.Forms.Label();
			this.lblDescription = new System.Windows.Forms.Label();
			this.lblPrice = new System.Windows.Forms.Label();
			this.lblStock = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.lblLower = new System.Windows.Forms.Label();
			this.lblUpper = new System.Windows.Forms.Label();
			this.lblDepartment = new System.Windows.Forms.Label();
			this.lblCreateDate = new System.Windows.Forms.Label();
			this.txtStock = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtLower = new System.Windows.Forms.TextBox();
			this.txtUpper = new System.Windows.Forms.TextBox();
			this.txtDepartment = new System.Windows.Forms.TextBox();
			this.txtCreateDate = new System.Windows.Forms.TextBox();
			this.cbActive = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvUrunListesi)).BeginInit();
			this.gbProduct.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvUrunListesi
			// 
			this.dgvUrunListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvUrunListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUrunListesi.Location = new System.Drawing.Point(345, 31);
			this.dgvUrunListesi.Name = "dgvUrunListesi";
			this.dgvUrunListesi.RowHeadersWidth = 51;
			this.dgvUrunListesi.RowTemplate.Height = 24;
			this.dgvUrunListesi.Size = new System.Drawing.Size(774, 478);
			this.dgvUrunListesi.TabIndex = 0;
			this.dgvUrunListesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUrunListesi_CellClick);
			// 
			// gbProduct
			// 
			this.gbProduct.BackColor = System.Drawing.Color.DarkGray;
			this.gbProduct.Controls.Add(this.btnGuncelle);
			this.gbProduct.Controls.Add(this.btnSil);
			this.gbProduct.Controls.Add(this.btnEkle);
			this.gbProduct.Controls.Add(this.txtDescription);
			this.gbProduct.Controls.Add(this.txtPrice);
			this.gbProduct.Controls.Add(this.lblActive);
			this.gbProduct.Controls.Add(this.lblDescription);
			this.gbProduct.Controls.Add(this.lblPrice);
			this.gbProduct.Controls.Add(this.lblStock);
			this.gbProduct.Controls.Add(this.lblName);
			this.gbProduct.Controls.Add(this.lblLower);
			this.gbProduct.Controls.Add(this.lblUpper);
			this.gbProduct.Controls.Add(this.lblDepartment);
			this.gbProduct.Controls.Add(this.lblCreateDate);
			this.gbProduct.Controls.Add(this.txtStock);
			this.gbProduct.Controls.Add(this.txtName);
			this.gbProduct.Controls.Add(this.txtLower);
			this.gbProduct.Controls.Add(this.txtUpper);
			this.gbProduct.Controls.Add(this.txtDepartment);
			this.gbProduct.Controls.Add(this.txtCreateDate);
			this.gbProduct.Controls.Add(this.cbActive);
			this.gbProduct.Location = new System.Drawing.Point(29, 31);
			this.gbProduct.Name = "gbProduct";
			this.gbProduct.Size = new System.Drawing.Size(291, 478);
			this.gbProduct.TabIndex = 1;
			this.gbProduct.TabStop = false;
			this.gbProduct.Text = "Ürün Detay";
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.btnGuncelle.Location = new System.Drawing.Point(97, 420);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(86, 42);
			this.btnGuncelle.TabIndex = 20;
			this.btnGuncelle.Text = "Güncelle";
			this.btnGuncelle.UseVisualStyleBackColor = false;
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// btnSil
			// 
			this.btnSil.BackColor = System.Drawing.Color.Coral;
			this.btnSil.Location = new System.Drawing.Point(189, 420);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(75, 42);
			this.btnSil.TabIndex = 19;
			this.btnSil.Text = "Sil";
			this.btnSil.UseVisualStyleBackColor = false;
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// btnEkle
			// 
			this.btnEkle.BackColor = System.Drawing.Color.Aquamarine;
			this.btnEkle.Location = new System.Drawing.Point(16, 420);
			this.btnEkle.Name = "btnEkle";
			this.btnEkle.Size = new System.Drawing.Size(75, 42);
			this.btnEkle.TabIndex = 18;
			this.btnEkle.Text = "Ekle";
			this.btnEkle.UseVisualStyleBackColor = false;
			this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(117, 283);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(141, 131);
			this.txtDescription.TabIndex = 17;
			this.txtDescription.Text = "";
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(117, 226);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(141, 22);
			this.txtPrice.TabIndex = 16;
			// 
			// lblActive
			// 
			this.lblActive.AutoSize = true;
			this.lblActive.Location = new System.Drawing.Point(13, 261);
			this.lblActive.Name = "lblActive";
			this.lblActive.Size = new System.Drawing.Size(44, 16);
			this.lblActive.TabIndex = 15;
			this.lblActive.Text = "Active";
			// 
			// lblDescription
			// 
			this.lblDescription.AutoSize = true;
			this.lblDescription.Location = new System.Drawing.Point(13, 291);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(75, 16);
			this.lblDescription.TabIndex = 14;
			this.lblDescription.Text = "Description";
			// 
			// lblPrice
			// 
			this.lblPrice.AutoSize = true;
			this.lblPrice.Location = new System.Drawing.Point(13, 229);
			this.lblPrice.Name = "lblPrice";
			this.lblPrice.Size = new System.Drawing.Size(38, 16);
			this.lblPrice.TabIndex = 13;
			this.lblPrice.Text = "Price";
			// 
			// lblStock
			// 
			this.lblStock.AutoSize = true;
			this.lblStock.Location = new System.Drawing.Point(13, 195);
			this.lblStock.Name = "lblStock";
			this.lblStock.Size = new System.Drawing.Size(41, 16);
			this.lblStock.TabIndex = 12;
			this.lblStock.Text = "Stock";
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(13, 161);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(44, 16);
			this.lblName.TabIndex = 11;
			this.lblName.Text = "Name";
			// 
			// lblLower
			// 
			this.lblLower.AutoSize = true;
			this.lblLower.Location = new System.Drawing.Point(13, 129);
			this.lblLower.Name = "lblLower";
			this.lblLower.Size = new System.Drawing.Size(43, 16);
			this.lblLower.TabIndex = 10;
			this.lblLower.Text = "Lower";
			// 
			// lblUpper
			// 
			this.lblUpper.AutoSize = true;
			this.lblUpper.Location = new System.Drawing.Point(13, 97);
			this.lblUpper.Name = "lblUpper";
			this.lblUpper.Size = new System.Drawing.Size(45, 16);
			this.lblUpper.TabIndex = 9;
			this.lblUpper.Text = "Upper";
			// 
			// lblDepartment
			// 
			this.lblDepartment.AutoSize = true;
			this.lblDepartment.Location = new System.Drawing.Point(13, 66);
			this.lblDepartment.Name = "lblDepartment";
			this.lblDepartment.Size = new System.Drawing.Size(77, 16);
			this.lblDepartment.TabIndex = 8;
			this.lblDepartment.Text = "Department";
			// 
			// lblCreateDate
			// 
			this.lblCreateDate.AutoSize = true;
			this.lblCreateDate.Location = new System.Drawing.Point(13, 34);
			this.lblCreateDate.Name = "lblCreateDate";
			this.lblCreateDate.Size = new System.Drawing.Size(76, 16);
			this.lblCreateDate.TabIndex = 7;
			this.lblCreateDate.Text = "CreateDate";
			// 
			// txtStock
			// 
			this.txtStock.Location = new System.Drawing.Point(117, 192);
			this.txtStock.Name = "txtStock";
			this.txtStock.Size = new System.Drawing.Size(141, 22);
			this.txtStock.TabIndex = 6;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(117, 158);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(141, 22);
			this.txtName.TabIndex = 5;
			// 
			// txtLower
			// 
			this.txtLower.Location = new System.Drawing.Point(117, 126);
			this.txtLower.Name = "txtLower";
			this.txtLower.Size = new System.Drawing.Size(141, 22);
			this.txtLower.TabIndex = 4;
			// 
			// txtUpper
			// 
			this.txtUpper.Location = new System.Drawing.Point(117, 94);
			this.txtUpper.Name = "txtUpper";
			this.txtUpper.Size = new System.Drawing.Size(141, 22);
			this.txtUpper.TabIndex = 3;
			// 
			// txtDepartment
			// 
			this.txtDepartment.Location = new System.Drawing.Point(117, 63);
			this.txtDepartment.Name = "txtDepartment";
			this.txtDepartment.Size = new System.Drawing.Size(141, 22);
			this.txtDepartment.TabIndex = 2;
			// 
			// txtCreateDate
			// 
			this.txtCreateDate.Location = new System.Drawing.Point(117, 31);
			this.txtCreateDate.Name = "txtCreateDate";
			this.txtCreateDate.Size = new System.Drawing.Size(141, 22);
			this.txtCreateDate.TabIndex = 1;
			// 
			// cbActive
			// 
			this.cbActive.AutoSize = true;
			this.cbActive.Location = new System.Drawing.Point(117, 257);
			this.cbActive.Name = "cbActive";
			this.cbActive.Size = new System.Drawing.Size(66, 20);
			this.cbActive.TabIndex = 0;
			this.cbActive.Text = "Active";
			this.cbActive.UseVisualStyleBackColor = true;
			// 
			// ProductDetails
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1131, 543);
			this.Controls.Add(this.gbProduct);
			this.Controls.Add(this.dgvUrunListesi);
			this.ForeColor = System.Drawing.Color.Navy;
			this.Name = "ProductDetails";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ürün Yönetimi";
			this.Load += new System.EventHandler(this.ProductDetails_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvUrunListesi)).EndInit();
			this.gbProduct.ResumeLayout(false);
			this.gbProduct.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvUrunListesi;
		private System.Windows.Forms.GroupBox gbProduct;
		private System.Windows.Forms.Label lblStock;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblLower;
		private System.Windows.Forms.Label lblUpper;
		private System.Windows.Forms.Label lblDepartment;
		private System.Windows.Forms.Label lblCreateDate;
		private System.Windows.Forms.TextBox txtStock;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtLower;
		private System.Windows.Forms.TextBox txtUpper;
		private System.Windows.Forms.TextBox txtDepartment;
		private System.Windows.Forms.TextBox txtCreateDate;
		private System.Windows.Forms.CheckBox cbActive;
		private System.Windows.Forms.Label lblActive;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.Label lblPrice;
		private System.Windows.Forms.RichTextBox txtDescription;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.Button btnGuncelle;
		private System.Windows.Forms.Button btnSil;
		private System.Windows.Forms.Button btnEkle;
	}
}

