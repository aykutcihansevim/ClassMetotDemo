using System;

namespace ClassMetotDemo
{
    class Program
    {

        //ClassMetotDemo isimli bir proje oluşturunuz.
        //Projeniz şunu yapacak.
        //Bir bankada müşteri takibi yapmak istiyorsunuz.
        //Musteri isimli bir Class oluşturunuz. Müşteriye istediğiniz özellikleri ekleyiniz. (Id, Ad, Soyad....)
        //MusteriManager sınıfı oluşturunuz. Musteri parametresi alarak Musteri ekleme, listeleme, silme gibi metotları simule ediniz.
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Menu();

        }
    }
}
