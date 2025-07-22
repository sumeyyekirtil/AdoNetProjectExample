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
			this.cbActive = new System.Windows.Forms.CheckBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.lblId = new System.Windows.Forms.Label();
			this.lblDepartment = new System.Windows.Forms.Label();
			this.lblUpper = new System.Windows.Forms.Label();
			this.lblLower = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.lblStock = new System.Windows.Forms.Label();
			this.lblCreateDate = new System.Windows.Forms.Label();
			this.lblDescription = new System.Windows.Forms.Label();
			this.lblActive = new System.Windows.Forms.Label();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.btnEkle = new System.Windows.Forms.Button();
			this.btnSil = new System.Windows.Forms.Button();
			this.btnGuncelle = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvUrunListesi)).BeginInit();
			this.gbProduct.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvUrunListesi
			// 
			this.dgvUrunListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUrunListesi.Location = new System.Drawing.Point(345, 31);
			this.dgvUrunListesi.Name = "dgvUrunListesi";
			this.dgvUrunListesi.RowHeadersWidth = 51;
			this.dgvUrunListesi.RowTemplate.Height = 24;
			this.dgvUrunListesi.Size = new System.Drawing.Size(610, 478);
			this.dgvUrunListesi.TabIndex = 0;
			this.dgvUrunListesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUrunListesi_CellClick);
			// 
			// gbProduct
			// 
			this.gbProduct.Controls.Add(this.btnGuncelle);
			this.gbProduct.Controls.Add(this.btnSil);
			this.gbProduct.Controls.Add(this.btnEkle);
			this.gbProduct.Controls.Add(this.richTextBox1);
			this.gbProduct.Controls.Add(this.textBox7);
			this.gbProduct.Controls.Add(this.lblActive);
			this.gbProduct.Controls.Add(this.lblDescription);
			this.gbProduct.Controls.Add(this.lblCreateDate);
			this.gbProduct.Controls.Add(this.lblStock);
			this.gbProduct.Controls.Add(this.lblName);
			this.gbProduct.Controls.Add(this.lblLower);
			this.gbProduct.Controls.Add(this.lblUpper);
			this.gbProduct.Controls.Add(this.lblDepartment);
			this.gbProduct.Controls.Add(this.lblId);
			this.gbProduct.Controls.Add(this.textBox6);
			this.gbProduct.Controls.Add(this.textBox5);
			this.gbProduct.Controls.Add(this.textBox4);
			this.gbProduct.Controls.Add(this.textBox3);
			this.gbProduct.Controls.Add(this.textBox2);
			this.gbProduct.Controls.Add(this.textBox1);
			this.gbProduct.Controls.Add(this.cbActive);
			this.gbProduct.Location = new System.Drawing.Point(29, 31);
			this.gbProduct.Name = "gbProduct";
			this.gbProduct.Size = new System.Drawing.Size(291, 478);
			this.gbProduct.TabIndex = 1;
			this.gbProduct.TabStop = false;
			this.gbProduct.Text = "Ürün Detay";
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
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(117, 31);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(141, 22);
			this.textBox1.TabIndex = 1;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(117, 63);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(141, 22);
			this.textBox2.TabIndex = 2;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(117, 94);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(141, 22);
			this.textBox3.TabIndex = 3;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(117, 126);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(141, 22);
			this.textBox4.TabIndex = 4;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(117, 158);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(141, 22);
			this.textBox5.TabIndex = 5;
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(117, 192);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(141, 22);
			this.textBox6.TabIndex = 6;
			// 
			// lblId
			// 
			this.lblId.AutoSize = true;
			this.lblId.Location = new System.Drawing.Point(13, 34);
			this.lblId.Name = "lblId";
			this.lblId.Size = new System.Drawing.Size(64, 16);
			this.lblId.TabIndex = 7;
			this.lblId.Text = "ProductId";
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
			// lblUpper
			// 
			this.lblUpper.AutoSize = true;
			this.lblUpper.Location = new System.Drawing.Point(13, 97);
			this.lblUpper.Name = "lblUpper";
			this.lblUpper.Size = new System.Drawing.Size(45, 16);
			this.lblUpper.TabIndex = 9;
			this.lblUpper.Text = "Upper";
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
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(13, 161);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(44, 16);
			this.lblName.TabIndex = 11;
			this.lblName.Text = "Name";
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
			// lblCreateDate
			// 
			this.lblCreateDate.AutoSize = true;
			this.lblCreateDate.Location = new System.Drawing.Point(13, 229);
			this.lblCreateDate.Name = "lblCreateDate";
			this.lblCreateDate.Size = new System.Drawing.Size(76, 16);
			this.lblCreateDate.TabIndex = 13;
			this.lblCreateDate.Text = "CreateDate";
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
			// lblActive
			// 
			this.lblActive.AutoSize = true;
			this.lblActive.Location = new System.Drawing.Point(13, 261);
			this.lblActive.Name = "lblActive";
			this.lblActive.Size = new System.Drawing.Size(44, 16);
			this.lblActive.TabIndex = 15;
			this.lblActive.Text = "Active";
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(117, 226);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(141, 22);
			this.textBox7.TabIndex = 16;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(117, 283);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(141, 131);
			this.richTextBox1.TabIndex = 17;
			this.richTextBox1.Text = "";
			// 
			// btnEkle
			// 
			this.btnEkle.Location = new System.Drawing.Point(16, 420);
			this.btnEkle.Name = "btnEkle";
			this.btnEkle.Size = new System.Drawing.Size(75, 42);
			this.btnEkle.TabIndex = 18;
			this.btnEkle.Text = "Ekle";
			this.btnEkle.UseVisualStyleBackColor = true;
			this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
			// 
			// btnSil
			// 
			this.btnSil.Location = new System.Drawing.Point(198, 420);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(75, 42);
			this.btnSil.TabIndex = 19;
			this.btnSil.Text = "Sil";
			this.btnSil.UseVisualStyleBackColor = true;
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.Location = new System.Drawing.Point(108, 420);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(75, 42);
			this.btnGuncelle.TabIndex = 20;
			this.btnGuncelle.Text = "Güncelle";
			this.btnGuncelle.UseVisualStyleBackColor = true;
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// ProductDetails
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(967, 543);
			this.Controls.Add(this.gbProduct);
			this.Controls.Add(this.dgvUrunListesi);
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
		private System.Windows.Forms.Label lblId;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.CheckBox cbActive;
		private System.Windows.Forms.Label lblActive;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.Label lblCreateDate;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Button btnGuncelle;
		private System.Windows.Forms.Button btnSil;
		private System.Windows.Forms.Button btnEkle;
	}
}

