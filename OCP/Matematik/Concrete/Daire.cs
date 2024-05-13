using OCP.Matematik.Abstract;

namespace OCP.Matematik.Concrete
{
    public class Daire : ISekil
    {
        public int Yaricap { get; set; }

        public double AlanHesapla()
        {
            double Alan = (Math.PI) * (Math.Pow(Yaricap, 2));
            return Alan;
        }

        public double CevreHesapla()
        {
            double Cevre = (Math.PI) * 2 * Yaricap;
            return Cevre;
        }
    }
}
