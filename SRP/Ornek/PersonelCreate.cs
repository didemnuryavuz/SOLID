using SRP.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Ornek
{
    public class PersonelCreate
    {
        public Logger Logger { get; set; }
        public PersonelCreate()
        {
            Logger=new Logger("Personel2.txt","Personel kayit islemi basladi:"+DateTime.Now.ToString());
        }
        public void PersonelEkle(Personel personel)
        {
            string kayit = personel.Ad + " " + personel.Soyad + " " + personel.TcNo + " " + personel.Email;
            Logger.Yaz(kayit);
        }
    }
}
