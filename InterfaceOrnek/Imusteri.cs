using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek
{
	public interface Imusteri
	{
		//abstarct ile interface arasıdaki fark interface in tamamen şablon yapısına sahip olmasıdır
		//abstarctda nesne örneklenemiyor ama içeride method oluşturabiliyorum.iNTERFACe içerisinde yapıcı metot kullanılmaz ve nesne örneği alınmaz
		//abstarct da kalıtım yoluyla nesne örneği alınabilir
		// interface de hiçbir methodun bodysi bulunmaz 

		int Id { get; set; }
		string Name { get; set; }
		string Soyisim { get; set; }

		//metot
		int yeniKayit(string isim, string soyisim);
		int kayitDuzenle(int id ,string soyisim , string isim);

		int kayitSil(int id);
	}
}
