using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    //MusteriManager sınıfı oluşturunuz. Musteri parametresi alarak Musteri ekleme, listeleme, silme gibi metotları simule ediniz.
    public class MusteriManager
    {
        public List<Musteri> Customers = new List<Musteri>();

        public void Menu()
        {
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz:");
            Console.WriteLine("1-)Yeni Müşteri Eklemek");
            Console.WriteLine("2-)Müşterileri Listelemek");
            Console.WriteLine("3-)Müşteri Silmek");

            string userInput = Console.ReadKey().KeyChar.ToString();

            switch (userInput)
            {
                case "1":
                    Console.Clear();
                    AddCustomer();
                    break;
                case "2":
                    Console.Clear();
                    ListCustomers();
                    break;
                case "3":
                    Console.Clear();
                    DeleteCustomer();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("\n");
                    Console.WriteLine("Lütfen geçerli bir seçim yapınız.\n"); 
                    Menu();
                    break;
            }
        }

        public void ListCustomers()
        {
            Console.Clear();
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -GÜNCEL MÜŞTERİ LİSTESİ - - - - - - - - - - - - - - - - - - - - - - - -\n");
            foreach (var Musteri in Customers)
            {
                Console.WriteLine(Musteri.Id + "-) " + "Müşteri Adı: " + Musteri.Name + "\n" + " " + "Müşteri Soyadı: " + Musteri.Surname + "\n" + " " + "Müşteri TC: " + Musteri.Tcno);
                Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -\n");
            }

            Console.WriteLine("Ana menüye dönmek için bir tuşa basınız.");
            Console.ReadKey();
            Console.Clear();
            Menu();
        }

        public void AddCustomer()
        {
            Musteri customer = new Musteri();
            Console.WriteLine("Müşterinin adını giriniz:");
            customer.Name = Console.ReadLine();
            Console.WriteLine("Müşterinin soyadınız giriniz:");
            customer.Surname = Console.ReadLine();
            Console.WriteLine("Müşterinin TcNo bilgisini giriniz:");
            customer.Tcno = Console.ReadLine();
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -\n");
            Console.WriteLine("Yeni müşteri kaydı oluşturuluyor lütfen bekleyiniz...");
            Console.WriteLine(".");
            Console.WriteLine("..");
            Console.WriteLine("...");

            //Listede bulunan müşteri Id sayısına göre yeni Id'nin en son verilen Id+1 olmasını sağlayan kod
            customer.Id = Customers.Count > 0 ? Customers.Max(x => x.Id) + 1 : 1;

            Customers.Add(customer);
            Console.WriteLine("Yeni müşteri kaydı başarı ile oluşturuldu!");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -\n");
            Task.Delay(3000);
            Console.WriteLine("Güncel müşteri listesini görmek için bir tuşa basınız.");
            Console.ReadKey();
            ListCustomers();
            Console.WriteLine("\n");
            Console.WriteLine("Ana menüye dönmek için bir tuşa basınız.");
            Console.ReadLine();
            Console.Clear();
            Menu();

        }

        public void DeleteCustomer()
        {
            Console.Clear();


            Console.WriteLine("Kaydını silmek istediğiğiniz müşterinin Id'sini giriniz:\n");
            string userInput = Console.ReadKey().KeyChar.ToString();

            foreach (var m in Customers)
            {
                if (userInput != m.Id.ToString())
                {
                    Console.WriteLine("Bu Id'ye sahip bir müşteri bulunmamaktadır.");
                    Console.WriteLine("\n");
                    Console.WriteLine("Ana menüye dönmek için bir tuşa basınız.");
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                }
                else
                {
                    foreach (var n in Customers)
                    {
                        if (n.Id == m.Id)
                        {
                            List<Musteri> tmp = new List<Musteri>(Customers);
                            tmp.Remove(n);
                            Customers = tmp.ToList();
                            Console.WriteLine("Müşteri kaydı siliniyor lütfen bekleyiniz...");
                            Task.Delay(3000);
                            Console.WriteLine("Müşteri kaydı başarı ile silindi!");
                            Console.WriteLine("\n");
                            break;
                        }
                    }
                    Task.Delay(3000);
                    Console.WriteLine("\n");
                    ListCustomers();

                }

            }
            
           

        }
    }
}

