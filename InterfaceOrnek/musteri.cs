using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek
{
	public class musteri : Imusteri
	{
		int _id;
		string _name;
		string _soyisim;
		public int Id { get { return _id; }  set { _id = value; }}
		public string Name { get { return _name; } set { _name	 = value; } }
		public string Soyisim { get { return _soyisim; } set { _soyisim = value; } }

		public int kayitDuzenle(int id, string soyisim, string isim)
		{
			Console.WriteLine("kayıt düzenlendi");
			return 1;
		}

		public int kayitSil(int id)
		{
			Console.WriteLine("kayıt silindi");
			return 1;
		}

		public int yeniKayit(string isim, string soyisim)
		{
			Console.WriteLine(" yenikayıt eklendi");
			return 1;
		}
	}
}
