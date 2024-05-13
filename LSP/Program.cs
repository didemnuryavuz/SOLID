using LSP.Ucaklar.Abstract;
using LSP.Ucaklar.Concrete;

namespace LSP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IVurabilir> vurabilirs = new List<IVurabilir>();
            List<IKesifYapabilir> kesifYapabilirs = new();
            YeniUcakA yeniUcakA = new YeniUcakA();
            YeniUcakB yeniUcakB = new YeniUcakB();
            YeniUcakC yeniUcakC = new YeniUcakC();
            vurabilirs.Add(yeniUcakA);
            vurabilirs.Add(yeniUcakB);
            vurabilirs.Add(yeniUcakC);

            Gozlemci1 gozlemci1 = new Gozlemci1();
            Gozlemci2 gozlemc2 = new Gozlemci2();
            kesifYapabilirs.Add(gozlemc2);
            kesifYapabilirs.Add(gozlemci1);
            YeniSavas yeniSavas = new YeniSavas(vurabilirs, kesifYapabilirs);

            yeniSavas.HEdefVur();
            yeniSavas.KesifYap();
        }
    }
}
