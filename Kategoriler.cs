using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetProjectExample
{
	public partial class Kategoriler : Form
	{
		public Kategoriler()
		{
			InitializeComponent();
		}

	     CategoryDAL categoriDAL = new CategoryDAL();

		private void Kategoriler_Load(object sender, EventArgs e)
		{
			dgvKategoriler.DataSource = categoriDAL.GetDataTable("select * from Category");
		}

		private void btnEkle_Click(object sender, EventArgs e)
		{
			try
			{
				var kategori = new Category()
				{
					Id = (int)dgvKategoriler.CurrentRow.Cells[0].Value,
					Name = txtKategoriAdi.Text,
					Description = txtKategoriAciklamasi.Text,
					CreateDate = DateTime.Now,
					Active = cbActive.Checked
				};
				var sonuc = categoriDAL.Add(kategori);
				if (sonuc > 0)
				{
					dgvKategoriler.DataSource = categoriDAL.GetDataTable("Select * from Category");

					//ekledikten sonra textbox ları boşalt
					txtKategoriAdi.Clear();
					txtKategoriAciklamasi.Clear();
					cbActive.Checked = false;

					MessageBox.Show("Kayıt Başarılı!");
				}
			}
			catch (Exception hata)
			{
				MessageBox.Show("Hata Oluştu!" + hata);
			}
		}

		private void dgvKategoriler_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			txtKategoriAdi.Text = dgvKategoriler.CurrentRow.Cells[1].Value.ToString();
			txtKategoriAciklamasi.Text = dgvKategoriler.CurrentRow.Cells[2].Value.ToString();
			cbActive.Checked = Convert.ToBoolean(dgvKategoriler.CurrentRow.Cells[4].Value);

			btnEkle.Enabled = false;
			btnGuncelle.Enabled = true;
			btnSil.Enabled = true;
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			try
			{
				var kategori = new Category()
				{
					Id = (int)dgvKategoriler.CurrentRow.Cells[0].Value,
					Name = txtKategoriAdi.Text,
					Description = txtKategoriAciklamasi.Text,
					CreateDate = DateTime.UtcNow,
					Active = cbActive.Checked
				};
				var sonuc = categoriDAL.Update(kategori);
				if (sonuc > 0)
				{
					dgvKategoriler.DataSource = categoriDAL.GetDataTable("Select * from Category");

					//güncelledikten sonra textbox ları boşalt
					txtKategoriAdi.Clear();
					txtKategoriAciklamasi.Clear();
					cbActive.Checked = false;

					btnEkle.Enabled = true;
					btnGuncelle.Enabled = false;
					btnSil.Enabled = false;
					MessageBox.Show("Kayıt Başarılı!");
				}
			}
			catch (Exception hata)
			{
				MessageBox.Show("Hata Oluştu!" + hata);
			}
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Kaydı Silmek İstiyor Musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				try
				{
					int sonuc = categoriDAL.Delete((int)dgvKategoriler.CurrentRow.Cells[0].Value);
					if (sonuc > 0)
					{
						dgvKategoriler.DataSource = categoriDAL.GetDataTable("select * from Category");
						btnEkle.Enabled = true;
						btnGuncelle.Enabled = false;
						btnSil.Enabled = false;

						//sildikten sonra textbox ları boşalt
						txtKategoriAdi.Clear();
						txtKategoriAciklamasi.Clear();
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