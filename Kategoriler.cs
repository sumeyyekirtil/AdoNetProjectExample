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
		KategoriDAL kategoriDAL = new KategoriDAL();
		private void Kategoriler_Load(object sender, EventArgs e)
		{
			dgvKategoriler.DataSource = kategoriDAL.GetDataTable("select * from Kategoriler");
		}
	}
}
