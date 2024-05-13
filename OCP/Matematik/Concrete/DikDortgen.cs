using OCP.Matematik.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Matematik.Concrete
{
    public class DikDortgen : ISekil
    {
        public int UzunKenar { get; set; }
        public int KisaKenar { get; set; }

        public void AlanHesapla()
        {
            int Alan= UzunKenar * KisaKenar;
            Console.WriteLine("Dikdortgen Alan : "+Alan);
        }

        public void CevreHesapla()
        {
            int Cevre = (UzunKenar + KisaKenar) * 2;
            Console.WriteLine("Dikdortgen Cevre : "+Cevre);
        }
    }
}
