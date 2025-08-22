using System.Data; //vt işlemleri için gerekli
using System.Data.SqlClient; //ado.net kütüphaneleri

namespace AdoNetProjectExample
{//ConnectionString : Veritabanı bağlantı cümlesi - management - server name copy paste - database : copy paste - Integrated Security = True; (güvenli bağlantı aktif - kendim yöneticiyim(kullanıcı adı - şifre yazabiliriz yerine))
	public class OrtakDAL //DAL: DATA ACCESS LAYER
	{
		internal SqlConnection _connection = new SqlConnection(@"server=ASUS-PRO; database=GiyimDB; Integrated Security=True;"); //vt bulunduğu server bilgisini connection cümlesi olarak buraya tanımlıyorum.

		internal void ConnectionKontrol()//Veritabanı bağlantımızı kontrol eden metot
		{
			if (_connection.State == ConnectionState.Closed) //vt kapalı ise
			{
				_connection.Open();//Veritabanı bağlantısını aç
			}
		}
		public DataTable GetDataTable(string sqlSorgu)
		{
			DataTable dt = new DataTable();//dt sınıfından bir nesne

			ConnectionKontrol(); //Bağlantı kontrolü

			SqlCommand command = new SqlCommand(sqlSorgu, _connection);

			SqlDataReader reader = command.ExecuteReader();

			dt.Load(reader); //vt daki okunulan veriyi boş dt a yüklüyoruz

			reader.Close(); // veritabanından okuyucuyu kapat
			_connection.Close(); // veritabanı bağlantısını kapat
			command.Dispose(); // sql komut nesnesini yok et

			return dt;
		}
	}
}