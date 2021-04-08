using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    //Musteri isimli bir Class oluşturunuz. Müşteriye istediğiniz özellikleri ekleyiniz. (Id, Ad, Soyad....)
    public class Musteri
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Int64 Tcno { get; set; }
        public int BirthDate { get; set; }
        public int Yas { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }

    }
}
