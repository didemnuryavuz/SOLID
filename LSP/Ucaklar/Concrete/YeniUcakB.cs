using LSP.Ucaklar.Abstract;

namespace LSP.Ucaklar.Concrete
{
    internal class YeniUcakB : IVurabilir, IKesifYapabilir
    {
        public bool HedefVur()
        {
            Console.WriteLine("B Ucagi Hedefi Vurdu");

            return true;
        }

        public bool KesifYap()
        {
            Console.WriteLine("B Ucagi Kesif Yapti");
            return true;
        }
    }
}
