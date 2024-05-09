using SRP.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Ornek
{
    public class PersonelOlusturucu
    {
        public void PersonelEkle(Personel personel)
        {
            string kayit=personel.Ad+" "+personel.Soyad+" "+personel.TcNo+" "+personel.Email;
            File.WriteAllText(@"Personel.csv",kayit);


        }
    }
}
