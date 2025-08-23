using System;
namespace AdoNetProjectExample
{
	//Cannot insert the value NULL into column 'Id', table 'GiyimDB.dbo.Tmp_Category'; column does not allow nulls. INSERT fails. The statement has been terminated.  hatası çözümü : değer ataması yapılmadığı için olur - ıd not allow nulls - id Indentity Specification : yes - increment : 1
	public class Category
	{
			public int Id { get; set; }
			public string Name { get; set; }
			public string Description { get; set; }
			public bool Active { get; set; }
			public DateTime CreateDate { get; set; }
	}
}