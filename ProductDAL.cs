using System;
using System.Collections.Generic;
using System.Data; //vt işlemleri için
using System.Data.SqlClient; //ADO.NET kütüphaneleri

namespace AdoNetProjectExample
{
	public class ProductDAL : OrtakDAL //kalıtım
	{
		public DataTable GetDataTable()
		{
			////public List<Product> GetAll() //tümünü getir{
			
			//Db den kayıt getirme yöntemi 1 ->
			DataTable dt = new DataTable();
			//var products = new List<Product>(); //boş nesne, vt ile doldurulacak

			ConnectionKontrol();
			//güvenlik nedeniyle kapalı gelir kullandıktan sonra kapatmamız gerekiyor.
			//açılmasını sağlamak için ortakDAL da _connection = open kullanılır

			SqlCommand command = new SqlCommand("select * from ProductDetails", _connection); //sql de çalışan komutu string olarak buraya yazıyoruz

			//kütüphaneden gelen sql komutu yazdığımız bir sınıf
			SqlDataReader reader = command.ExecuteReader(); //command daki sorguyu çalıştırıp reader doldurup kayıt okuma yapılabilir

			dt.Load(reader); //dt dan okuduğumuz kayıtları boş datatable a yüklüyoruz.

			//Db kayıt getirme yöntemi 2 ->
			//while (reader.Read()) //reader nesnesi içerisinde okunacak kayıt olduğu sürece kayıt oku (t/f)
			//{
			//	var product = new Product() //boş bi product oluşturup içindeki verileri reader dan çekiyoruz
			//	{
			//		ProductId = Convert.ToInt32(reader["ProductId"]),
			//		Name = reader["UrunAdi"].ToString(), //convert ile ekledim!
			//		Stock = Convert.ToInt32(reader["StokMiktari"]),
			//		Price = Convert.ToDecimal(reader["UrunFiyati"]),
			//		Active = Convert.ToBoolean(reader["Durum"]),
			//		Department = Convert.ToString(reader["Departman"]),
			//		Upper = Convert.ToInt32(reader["UstTakim"]),
			//		Lower = Convert.ToInt32(reader["AltTakim"]),
			//		CreateDate = Convert.ToDateTime(reader["DegiştirmeTarihi"]),
			//		Description = Convert.ToString(reader["Açiklama"])
			//	};
			//	products.Add(product); // db den okunan ürünü listeye ekle
			//}
			//kayıt bittiğinde;
			reader.Close(); // veritabanından okuyucuyu kapat
			_connection.Close(); // veritabanı bağlantısını kapat
			command.Dispose(); // sql komut nesnesini yoket

			//return products;
			return dt;
		}
		//Ekle Bağlantı
		public int Add(Product product)
		{
			int sonuc = 0;
			ConnectionKontrol();
			SqlCommand command = new SqlCommand(
				"Insert into ProductDetails values(@UrunAdi,@UrunFiyati,@StokMiktari,@Durum,@Departman,@Üst,@Alt,@Açiklama,@Tarih)", _connection);

			command.Parameters.AddWithValue("@UrunAdi", product.Name); //addWithValue metodu 2 değişken alır parametre aracılığıyla ekrana yolluyoruz (sqlInjection ile saldırıyı önlemiş oluyoruz)
			command.Parameters.AddWithValue("@UrunFiyati", product.Price);
			command.Parameters.AddWithValue("@StokMiktari", product.Stock);
			command.Parameters.AddWithValue("@Durum", product.Active);
			command.Parameters.AddWithValue("@Departman", product.Department);
			command.Parameters.AddWithValue("@Üst", product.Upper);
			command.Parameters.AddWithValue("@Alt", product.Lower);
			command.Parameters.AddWithValue("@Açiklama", product.Description);
			command.Parameters.AddWithValue("@Tarih", product.CreateDate);
			sonuc = command.ExecuteNonQuery(); //add metodu geriye değer olarak 0 dan büyük değer döndürürse işlem başarılı olup çıkış yaptırır
			command.Dispose();
			_connection.Close();
			return sonuc;
		}
		//Güncelle Bağlantı
		public int Update(Product product)
		{ //id ye göre güncelleme alacak
			int sonuc = 0;
			ConnectionKontrol();
			SqlCommand command = new SqlCommand(
				"Update ProductDetails set Name=@UrunAdi, Price=@UrunFiyati, Stock=@StokMiktari, Active=@Durum, Department=@Departman, Upper=@Ust, Lower=@Alt, Description=@Aciklama, CreateDate=@Tarih @where ProductId=@id", _connection); //tüm column lar gelecekse eklemeyedebiliriz
			command.Parameters.AddWithValue("@UrunAdi", product.Name);
			command.Parameters.AddWithValue("@UrunFiyati", product.Price);
			command.Parameters.AddWithValue("@StokMiktari", product.Stock);
			command.Parameters.AddWithValue("@Durum", product.Active);
			command.Parameters.AddWithValue("@Departman", product.Department);
			command.Parameters.AddWithValue("@Ust", product.Upper);
			command.Parameters.AddWithValue("@Alt", product.Lower);
			command.Parameters.AddWithValue("@Aciklama", product.Description);
			command.Parameters.AddWithValue("@Tarih", product.CreateDate);
			sonuc = command.ExecuteNonQuery();
			command.Dispose();
			_connection.Close();
			return sonuc;
		}
		//Sil Bağlantı
		public int Delete(int id)
		{ //id sil
			int sonuc = 0;
			ConnectionKontrol();
			SqlCommand command = new SqlCommand(
				"Delete From ProductDetails where ProductId=@id", _connection);

			command.Parameters.AddWithValue("@id", id);
			sonuc = command.ExecuteNonQuery();
			command.Dispose();
			_connection.Close();
			return sonuc;
		}
	}
}