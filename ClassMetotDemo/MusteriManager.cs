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
                    AddCustomer();
                    break;
                case "2":
                    ListCustomers();
                    break;
                case "3":
                    DeleteCustomer();
                    break;
                default:
                    Console.WriteLine(" ");
                    Console.WriteLine("Lütfen geçerli bir seçim yapınız."); 
                    Console.WriteLine(" ");
                    Menu();
                    break;
            }
        }

        public void ListCustomers()
        {
            Console.Clear();
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -GÜNCEL MÜŞTERİ LİSTESİ - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine(" ");
            foreach (var Musteri in Customers)
            {
                Console.WriteLine(Musteri.Id + " " + Musteri.Name + " " + Musteri.Surname + " " + Musteri.Tcno);
                Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                Console.WriteLine(" ");
            }


            Task.Delay(5000);
            Menu();
        }

        public void AddCustomer()
        {
            Console.Clear();
            Musteri customer = new Musteri();

            //Listede bulunan müşteri Id sayısına göre yeni Id'nin en son verilen Id+1 olmasını sağlayan kod
            customer.Id = Customers.Count > 0 ? Customers.Max(x => x.Id) + 1 : 1;


            Console.WriteLine("Müşterinin adını giriniz:");
            if(Console.ReadLine() != null)
            {
               customer.Name = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Müşteri adı boş bırakılamaz.");
                Console.WriteLine(" ");
                AddCustomer();
            }

            Console.WriteLine("Müşterinin soyadınız giriniz:");
            if (Console.ReadLine() != null)
            {
                customer.Surname = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Müşteri soyadı boş bırakılamaz.");
                Console.WriteLine(" ");
                AddCustomer();
            }

 
            Console.WriteLine("Müşterinin tcno bilgisini giriniz:");
            if (Console.ReadLine() != null)
            {
                customer.Tcno = Int64.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Tcno bilgisi boş bırakılamaz.");
                Console.WriteLine(" ");
                AddCustomer();
            }
            


            Customers.Add(customer);

            Console.WriteLine("Yeni müşteri kaydı oluşturuluyor lütfen bekleyiniz...");
            Task.Delay(5000);

            Console.WriteLine("Yeni müşteri kaydı başarı ile oluşturuldu!");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");

            Task.Delay(5000);

            ListCustomers();

        }

        public void DeleteCustomer()
        {
            Console.Clear();
            Musteri customer = new Musteri();
            Console.WriteLine("Kaydını silmek istediğiğiniz müşterinin Id'sini giriniz:");
            string userInput = Console.ReadKey().KeyChar.ToString();
            Console.WriteLine(" ");
            if(userInput != customer.Id.ToString())
            {
                Console.WriteLine("Bu Id'ye sahip bir müşteri bulunmamaktadır.");
                Task.Delay(10000);
                Console.WriteLine(" ");
                Menu();
            }
            else
            {
                customer.Id = int.Parse(Console.ReadLine());

                foreach (var m in Customers)
                {
                    if (m.Id == customer.Id)
                    {
                        List<Musteri> tmp = new List<Musteri>(Customers);
                        tmp.Remove(m);
                        Customers = tmp.ToList();
                        Console.WriteLine("Müşteri kaydı siliniyor lütfen bekleyiniz...");
                        Task.Delay(3000);
                        Console.WriteLine("Müşteri kaydı başarı ile silindi!");
                        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Bu Id'ye sahip bir müşteri bulunmamaktadır.");
                        Menu();
                    }
                }
            



            }

            Task.Delay(10000);
            Console.WriteLine(" ");
            ListCustomers();
        }
    }
}

