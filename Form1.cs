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
	public partial class ProductDetails : Form
	{
		public ProductDetails()
		{
			InitializeComponent();
		}
		ProductDAL productDal = new ProductDAL();
		private void ProductDetails_Load(object sender, EventArgs e)
		{
			dgvUrunListesi.DataSource = productDal.GetDataTable("select * from ProductDetails");
		}

		private void btnEkle_Click(object sender, EventArgs e)
		{
			try
			{
				var urun = new Product
				{
					Name = txtName.Text,
					Stock = Convert.ToInt32(txtStock.Text),
					Price = Convert.ToInt32(txtPrice.Text),
					Department = Convert.ToString(txtDepartment.Text),
					Upper = Convert.ToInt32(txtUpper.Text),
					Lower = Convert.ToInt32(txtLower.Text),
					Description = Convert.ToString(txtDescription.Text),
					CreateDate = Convert.ToDateTime(txtCreateDate.Text),
					Active = cbActive.Checked
				};
				int sonuc = productDal.Add(urun);
				if (sonuc > 0)
				{
					dgvUrunListesi.DataSource = productDal.GetAll();
					MessageBox.Show("Kayıt Başarılı!");
				}
				else
				{
					MessageBox.Show("Kayıt Başarısız! Lütfen Tüm Alanları Doldurunuz!");
				}
			}
			catch (Exception hata)
			{
				MessageBox.Show("Hata Oluştu! Lütfen Tüm Alanları Doldurunuz!");
			}

		}
		private void dgvUrunListesi_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			txtCreateDate.Text = dgvUrunListesi.CurrentRow.Cells[1].Value.ToString();
			txtDepartment.Text = dgvUrunListesi.CurrentRow.Cells[2].Value.ToString();
			txtUpper.Text = dgvUrunListesi.CurrentRow.Cells[3].Value.ToString();
			txtLower.Text = dgvUrunListesi.CurrentRow.Cells[4].Value.ToString();
			txtName.Text = dgvUrunListesi.CurrentRow.Cells[5].Value.ToString();
			txtStock.Text = dgvUrunListesi.CurrentRow.Cells[6].Value.ToString();
			txtPrice.Text = dgvUrunListesi.CurrentRow.Cells[7].Value.ToString();
			cbActive.Checked = (bool)dgvUrunListesi.CurrentRow.Cells[8].Value;
			txtDescription.Text = dgvUrunListesi.CurrentRow.Cells[9].Value.ToString();

			btnEkle.Enabled = false;
			btnGuncelle.Enabled = true;
			btnSil.Enabled = true;
		}
		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			try
			{
				var urun = new Product
				{
					ProductId = (int)dgvUrunListesi.CurrentRow.Cells[0].Value,
					Name = txtName.Text,
					Stock = Convert.ToInt32(txtStock.Text),
					Price = Convert.ToDecimal(txtPrice.Text),
					Department = Convert.ToString(txtPrice.Text),
					Upper = Convert.ToInt32(txtPrice.Text),
					Lower = Convert.ToInt32(txtPrice.Text),
					Description = Convert.ToString(txtPrice.Text),
					Active = cbActive.Checked
				};
				int sonuc = productDal.Update(urun);
				if (sonuc > 0)
				{
					dgvUrunListesi.DataSource = productDal.GetAll();
					btnEkle.Enabled = true;
					btnGuncelle.Enabled = false;
					btnSil.Enabled = false;
					MessageBox.Show("Kayıt Başarılı!");
				}
				else
				{
					MessageBox.Show("Kayıt Başarısız! Lütfen Tüm Alanları Doldurunuz!");
				}
			}
			catch (Exception hata)
			{
				MessageBox.Show("Hata Oluştu! Lütfen Tüm Alanları Doldurunuz!");
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
						dgvUrunListesi.DataSource = productDal.GetAll();
						btnEkle.Enabled = true;
						btnGuncelle.Enabled = false;
						btnSil.Enabled = false;
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