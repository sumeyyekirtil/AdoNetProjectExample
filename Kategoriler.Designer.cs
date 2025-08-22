namespace AdoNetProjectExample
{
	partial class Kategoriler
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
			this.dgvKategoriler = new System.Windows.Forms.DataGridView();
			this.gbKategori = new System.Windows.Forms.GroupBox();
			this.btnSil = new System.Windows.Forms.Button();
			this.btnGuncelle = new System.Windows.Forms.Button();
			this.btnEkle = new System.Windows.Forms.Button();
			this.txtKategoriAciklamasi = new System.Windows.Forms.RichTextBox();
			this.txtKategoriAdi = new System.Windows.Forms.TextBox();
			this.cbActive = new System.Windows.Forms.CheckBox();
			this.lblKategoriAciklamasi = new System.Windows.Forms.Label();
			this.lblActive = new System.Windows.Forms.Label();
			this.lblKategoriAdi = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvKategoriler)).BeginInit();
			this.gbKategori.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvKategoriler
			// 
			this.dgvKategoriler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvKategoriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvKategoriler.Location = new System.Drawing.Point(12, 22);
			this.dgvKategoriler.Name = "dgvKategoriler";
			this.dgvKategoriler.RowHeadersWidth = 51;
			this.dgvKategoriler.RowTemplate.Height = 24;
			this.dgvKategoriler.Size = new System.Drawing.Size(702, 416);
			this.dgvKategoriler.TabIndex = 0;
			this.dgvKategoriler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKategoriler_CellClick);
			// 
			// gbKategori
			// 
			this.gbKategori.BackColor = System.Drawing.Color.MediumOrchid;
			this.gbKategori.Controls.Add(this.btnSil);
			this.gbKategori.Controls.Add(this.btnGuncelle);
			this.gbKategori.Controls.Add(this.btnEkle);
			this.gbKategori.Controls.Add(this.txtKategoriAciklamasi);
			this.gbKategori.Controls.Add(this.txtKategoriAdi);
			this.gbKategori.Controls.Add(this.cbActive);
			this.gbKategori.Controls.Add(this.lblKategoriAciklamasi);
			this.gbKategori.Controls.Add(this.lblActive);
			this.gbKategori.Controls.Add(this.lblKategoriAdi);
			this.gbKategori.Location = new System.Drawing.Point(720, 22);
			this.gbKategori.Name = "gbKategori";
			this.gbKategori.Size = new System.Drawing.Size(308, 323);
			this.gbKategori.TabIndex = 1;
			this.gbKategori.TabStop = false;
			this.gbKategori.Text = "Kategori Bilgileri";
			// 
			// btnSil
			// 
			this.btnSil.BackColor = System.Drawing.Color.Red;
			this.btnSil.Location = new System.Drawing.Point(209, 257);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(75, 42);
			this.btnSil.TabIndex = 22;
			this.btnSil.Text = "Sil";
			this.btnSil.UseVisualStyleBackColor = false;
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.BackColor = System.Drawing.Color.Yellow;
			this.btnGuncelle.Location = new System.Drawing.Point(122, 257);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(75, 42);
			this.btnGuncelle.TabIndex = 21;
			this.btnGuncelle.Text = "Güncelle";
			this.btnGuncelle.UseVisualStyleBackColor = false;
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// btnEkle
			// 
			this.btnEkle.BackColor = System.Drawing.Color.Lime;
			this.btnEkle.Location = new System.Drawing.Point(37, 257);
			this.btnEkle.Name = "btnEkle";
			this.btnEkle.Size = new System.Drawing.Size(75, 42);
			this.btnEkle.TabIndex = 19;
			this.btnEkle.Text = "Ekle";
			this.btnEkle.UseVisualStyleBackColor = false;
			this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
			// 
			// txtKategoriAciklamasi
			// 
			this.txtKategoriAciklamasi.Location = new System.Drawing.Point(37, 117);
			this.txtKategoriAciklamasi.Name = "txtKategoriAciklamasi";
			this.txtKategoriAciklamasi.Size = new System.Drawing.Size(247, 112);
			this.txtKategoriAciklamasi.TabIndex = 5;
			this.txtKategoriAciklamasi.Text = "";
			// 
			// txtKategoriAdi
			// 
			this.txtKategoriAdi.Location = new System.Drawing.Point(181, 19);
			this.txtKategoriAdi.Name = "txtKategoriAdi";
			this.txtKategoriAdi.Size = new System.Drawing.Size(103, 22);
			this.txtKategoriAdi.TabIndex = 4;
			// 
			// cbActive
			// 
			this.cbActive.AutoSize = true;
			this.cbActive.Location = new System.Drawing.Point(181, 62);
			this.cbActive.Name = "cbActive";
			this.cbActive.Size = new System.Drawing.Size(66, 20);
			this.cbActive.TabIndex = 3;
			this.cbActive.Text = "Active";
			this.cbActive.UseVisualStyleBackColor = true;
			// 
			// lblKategoriAciklamasi
			// 
			this.lblKategoriAciklamasi.AutoSize = true;
			this.lblKategoriAciklamasi.Location = new System.Drawing.Point(34, 98);
			this.lblKategoriAciklamasi.Name = "lblKategoriAciklamasi";
			this.lblKategoriAciklamasi.Size = new System.Drawing.Size(126, 16);
			this.lblKategoriAciklamasi.TabIndex = 2;
			this.lblKategoriAciklamasi.Text = "Kategori Açıklaması";
			// 
			// lblActive
			// 
			this.lblActive.AutoSize = true;
			this.lblActive.Location = new System.Drawing.Point(34, 62);
			this.lblActive.Name = "lblActive";
			this.lblActive.Size = new System.Drawing.Size(44, 16);
			this.lblActive.TabIndex = 1;
			this.lblActive.Text = "Active";
			// 
			// lblKategoriAdi
			// 
			this.lblKategoriAdi.AutoSize = true;
			this.lblKategoriAdi.Location = new System.Drawing.Point(34, 25);
			this.lblKategoriAdi.Name = "lblKategoriAdi";
			this.lblKategoriAdi.Size = new System.Drawing.Size(80, 16);
			this.lblKategoriAdi.TabIndex = 0;
			this.lblKategoriAdi.Text = "Kategori Adı";
			// 
			// Kategoriler
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1054, 450);
			this.Controls.Add(this.gbKategori);
			this.Controls.Add(this.dgvKategoriler);
			this.Name = "Kategoriler";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Kategoriler";
			this.Load += new System.EventHandler(this.Kategoriler_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvKategoriler)).EndInit();
			this.gbKategori.ResumeLayout(false);
			this.gbKategori.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvKategoriler;
		private System.Windows.Forms.GroupBox gbKategori;
		private System.Windows.Forms.RichTextBox txtKategoriAciklamasi;
		private System.Windows.Forms.TextBox txtKategoriAdi;
		private System.Windows.Forms.CheckBox cbActive;
		private System.Windows.Forms.Label lblKategoriAciklamasi;
		private System.Windows.Forms.Label lblActive;
		private System.Windows.Forms.Label lblKategoriAdi;
		private System.Windows.Forms.Button btnEkle;
		private System.Windows.Forms.Button btnGuncelle;
		private System.Windows.Forms.Button btnSil;
	}
}