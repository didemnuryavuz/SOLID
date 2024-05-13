using OCP.CoffeeExample;
using OCP.Matematik.Abstract;
using OCP.Matematik.Concrete;

namespace OCP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coffee coffee = new Coffee();
            DikDortgen dikDortgen = new DikDortgen() { KisaKenar = 3, UzunKenar = 5 };
            Daire yeniDaire = new Daire() { Yaricap = 5 };
            AlanHesapla(dikDortgen);
            AlanHesapla(yeniDaire);
        }
        public static void AlanHesapla(ISekil sekil)
        {
            Console.WriteLine("Alan = " + sekil.AlanHesapla());
            Console.WriteLine("Cevre = " + sekil.CevreHesapla());

        }
    }
}
