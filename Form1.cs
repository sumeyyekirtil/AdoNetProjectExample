using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//camelCase e göre isimlendirme yapıyoruz.
//solution - project - sağ tık - set a startup project : buradan çalıştır
//desing için buton kodlarını göndermek için önce productdal da metot tanımlaması yapıyoruz (sql sorgusu ile) sonra buton içine kod tanımlıyoruz.

//Veritabanı işlemleri nasıl çalıştığı konu alındı
//Veri işlemleri için add - class : OrtakDAL --using System.Data; //veri işlemleri için gerekli kütüphane --using System.Data.SqlClient; //ADO.NET kütüphaneleri ekle
//ürün takibi için (ortak metotları ortak class a al) add - class : Productdal using System; using System.Collections.Generic; using System.Data; //vt işlemleri için using System.Data.SqlClient; //ADO.NET kütüphaneleri (ortak metotları ortak class a al)

/*
 * Çalışma Yapısı ->
 * Form desing yapıları create edildi.
 * Project - Class added. Class - prop yapıları oluşturulunca aynı sınıfın DAL(data access layer) sınıfı açılır.
 * DAL -> Bağlantı nesnesi (connection string) oluşturulunca Add-Update-Delete komutlarına bağlantı - sonuç adresleri yazılıp veri türleri tanımlanır.
 * Desing - form.cs sayfalarında 1- Class nesnesi oluşturulup, 2- DAL class da oluşturulan yükleme işlemleri button lara event yoluyla verilir.
 */

namespace AdoNetProjectExample
{
	public partial class ProductDetails : Form
	{
		public ProductDetails()
		{
			InitializeComponent();
		}
		ProductDAL productDal = new ProductDAL(); //nesne oluşturuldu
		private void ProductDetails_Load(object sender, EventArgs e)
		{
			dgvUrunListesi.DataSource = productDal.GetDataTable("Select * from ProductDetails");
		}

		private void btnEkle_Click(object sender, EventArgs e)
		{//hata alınca çökmemesi için try-catch
			try
			{//ürün nesnesi alındı
				var urun = new Product
				{
					Department = Convert.ToString(txtDepartment.Text),
					Upper = Convert.ToInt32(txtUpper.Text),
					Lower = Convert.ToInt32(txtLower.Text),
					CreateDate = (DateTime)dgvUrunListesi.CurrentRow.Cells[4].Value,
					Name = txtName.Text,
					Description = Convert.ToString(txtDescription.Text),
					Stock = Convert.ToInt32(txtStock.Text),
					Price = Convert.ToDecimal(txtPrice.Text),
					Active = cbActive.Checked
				};
				int sonuc = productDal.Add(urun);
				if (sonuc > 0)
				{
					dgvUrunListesi.DataSource = productDal.GetDataTable();

					btnEkle.Enabled = true;
					btnGuncelle.Enabled = false;
					btnSil.Enabled = false;

					//eklendikten sonra textbox ları boşalt
					txtName.Clear();
					txtCreateDate.Clear();
					txtDepartment.Clear();
					txtDescription.Clear();
					txtLower.Clear();
					txtPrice.Clear();
					txtStock.Clear();
					txtUpper.Clear();
					cbActive.Checked = false;
					
					MessageBox.Show("Kayıt Başarılı!");
				}
				else //kayıt başarısızsa
				{
					MessageBox.Show("Kayıt Başarısız! Lütfen Tüm Alanları Doldurunuz!");
				}
			}
			catch (Exception hata)
			{
				MessageBox.Show("Hata Oluştu! Lütfen Tüm Alanları Doldurunuz!" + hata);
			}
		}
		private void dgvUrunListesi_CellClick(object sender, DataGridViewCellEventArgs e)
		{//0. index ıd olduğu için 1 den başlatıldı
			txtDepartment.Text = dgvUrunListesi.CurrentRow.Cells[1].Value.ToString();
			txtUpper.Text = dgvUrunListesi.CurrentRow.Cells[2].Value.ToString();
			txtLower.Text = dgvUrunListesi.CurrentRow.Cells[3].Value.ToString();
			txtCreateDate.Text = dgvUrunListesi.CurrentRow.Cells[4].Value.ToString();
			txtName.Text = dgvUrunListesi.CurrentRow.Cells[5].Value.ToString();
			txtDescription.Text = dgvUrunListesi.CurrentRow.Cells[6].Value.ToString();
			txtStock.Text = dgvUrunListesi.CurrentRow.Cells[7].Value.ToString();
			txtPrice.Text = dgvUrunListesi.CurrentRow.Cells[8].Value.ToString();
			cbActive.Checked = (bool)dgvUrunListesi.CurrentRow.Cells[9].Value;

			btnEkle.Enabled = false;
			btnGuncelle.Enabled = true;
			btnSil.Enabled = true;
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{ //txt atamaları doğru yapıldığından emin olmalıyız.
			try
			{
				var urun = new Product
				{
					ProductId = (int)dgvUrunListesi.CurrentRow.Cells[0].Value,
					Department = Convert.ToString(txtDepartment.Text),
					Upper = Convert.ToInt32(txtUpper.Text),
					Lower = Convert.ToInt32(txtLower.Text),
					CreateDate = (DateTime)dgvUrunListesi.CurrentRow.Cells[4].Value,
					Name = txtName.Text,
					Description = Convert.ToString(txtDescription.Text),
					Stock = Convert.ToInt32(txtStock.Text),
					Price = Convert.ToDecimal(txtPrice.Text),
					Active = cbActive.Checked
				};
				int sonuc = productDal.Update(urun);
				if (sonuc > 0)
				{
					dgvUrunListesi.DataSource = productDal.GetDataTable();

					btnEkle.Enabled = true;
					btnGuncelle.Enabled = false;
					btnSil.Enabled = false;

					//güncelle sonra textbox ları boşalt
					txtName.Clear();
					txtCreateDate.Clear();
					txtDepartment.Clear();
					txtDescription.Clear();
					txtLower.Clear();
					txtPrice.Clear();
					txtStock.Clear();
					txtUpper.Clear();
					cbActive.Checked = false;

					MessageBox.Show("Kayıt Başarılı!");
				}
				else
				{
					MessageBox.Show("Kayıt Başarısız! Lütfen Tüm Alanları Doldurunuz!");
				}
			}
			catch (Exception hata)
			{
				MessageBox.Show("Hata Oluştu! Lütfen Tüm Alanları Doldurunuz!" + hata);
			}

		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Kaydı Silmek İstiyor Musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				try
				{
					int sonuc = productDal.Delete((int)dgvUrunListesi.CurrentRow.Cells[0].Value);
					if (sonuc > 0)
					{
						dgvUrunListesi.DataSource = productDal.GetDataTable();

						btnEkle.Enabled = true;
						btnGuncelle.Enabled = false;
						btnSil.Enabled = false;

						//sildikten sonra textbox ları boşalt
						txtName.Clear();
						txtCreateDate.Clear();
						txtDepartment.Clear();
						txtDescription.Clear();
						txtLower.Clear();
						txtPrice.Clear();
						txtStock.Clear();
						txtUpper.Clear();
						cbActive.Checked = false;

						MessageBox.Show("Kayıt Silindi!");
					}
				}
				catch (Exception)
				{
					MessageBox.Show("Hata Oluştu!");
				}
			}
		}
	}
}