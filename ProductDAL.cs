using System;
using System.Collections.Generic;
using System.Data; //vt işlemleri için gerekli
using System.Data.SqlClient; //ado.net kütüphaneleri

namespace AdoNetProjectExample
{
	public class ProductDal : OrtakDAL
	{
		public List<Product> GetAll()
		{
			var products = new List<Product>();

			ConnectionKontrol();

			SqlCommand command = new SqlCommand("select * from ProductDetails", _connection);

			SqlDataReader reader = command.ExecuteReader();

			while (reader.Read()) // reader nesnesi içerisinde okunacak kayıt olduğu sürece
			{
				var product = new Product()
				{
					ProductId = Convert.ToInt32(reader["Id"]),
					Name = Convert.ToString(reader["UrunAdi"]), //convert ile ekledim!
					Stock = Convert.ToInt32(reader["StokMiktari"]),
					Price = Convert.ToDecimal(reader["UrunFiyati"]),
					Active = Convert.ToBoolean(reader["Durum"]),
					Department = Convert.ToString(reader["Departman"]),
					Upper = Convert.ToInt32(reader["ÜstTakım"]),
					Lower = Convert.ToInt32(reader["AltTakım"]),
					CreateDate = Convert.ToDateTime(reader["DeğiştirmeTarihi"]),
					Description = Convert.ToString(reader["Açıklama"])
				};
				products.Add(product); // db den okunan ürünü listeye ekle
			}
			reader.Close(); // veritabanından okuyucuyu kapat
			_connection.Close(); // veritabanı bağlantısını kapat
			command.Dispose(); // sql komut nesnesini yoket

			return products;
		}
		public int Add(Product product)
		{
			int sonuc = 0;
			ConnectionKontrol();
			SqlCommand command = new SqlCommand(
				"Insert into ProductDetails values(@UrunAdi,@UrunFiyati,@StokMiktari,@Durum,@Departman,@Üst,@Alt,@Açıklama,@Tarih)", _connection);

			command.Parameters.AddWithValue("@UrunAdi", product.Name);
			command.Parameters.AddWithValue("@UrunFiyati", product.Price);
			command.Parameters.AddWithValue("@StokMiktari", product.Stock);
			command.Parameters.AddWithValue("@Durum", product.Active);
			command.Parameters.AddWithValue("@Departman", product.Department);
			command.Parameters.AddWithValue("@Üst", product.Upper);
			command.Parameters.AddWithValue("@Alt", product.Lower);
			command.Parameters.AddWithValue("@Açıklama", product.Description);
			command.Parameters.AddWithValue("@Tarih", product.CreateDate);
			sonuc = command.ExecuteNonQuery();
			command.Dispose();
			_connection.Close();
			return sonuc;
		}
		public int Update(Product product)
		{
			int sonuc = 0;
			ConnectionKontrol();
			SqlCommand command = new SqlCommand(
				"Update ProductDetails set Name=@UAdi, Price=@UrunFiyati, Stock=@StokMiktari, Active=@Durum where ProductId=@id", _connection);
			command.Parameters.AddWithValue("@UrunAdi", product.Name);
			command.Parameters.AddWithValue("@UrunFiyati", product.Price);
			command.Parameters.AddWithValue("@StokMiktari", product.Stock);
			command.Parameters.AddWithValue("@Durum", product.Active);
			command.Parameters.AddWithValue("@UrunAdi", product.Department);
			command.Parameters.AddWithValue("@UrunFiyati", product.Upper);
			command.Parameters.AddWithValue("@StokMiktari", product.Lower);
			command.Parameters.AddWithValue("@Durum", product.Description);
			command.Parameters.AddWithValue("@Durum", product.CreateDate);
			sonuc = command.ExecuteNonQuery();
			command.Dispose();
			_connection.Close();
			return sonuc;
		}

		public int Delete(int id)
		{
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