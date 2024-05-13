using SRP.Entity;
using SRP.Ornek;

namespace SRP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personel Ali = new Personel
            {
                Ad = "Ali",
                Soyad = "Erdem",
                Email = " ",
                TcNo = "11111111"
            };

            PersonelCreate personelCreate = new();
            personelCreate.PersonelEkle(Ali);
        }
    }
}
