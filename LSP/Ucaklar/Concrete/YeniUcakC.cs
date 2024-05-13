using LSP.Ucaklar.Abstract;

namespace LSP.Ucaklar.Concrete
{
    internal class YeniUcakC : IVurabilir, IKesifYapabilir
    {
        public bool HedefVur()
        {
            Console.WriteLine("C Ucagi Hedefi Vurdu");
            return true;
        }

        public bool KesifYap()
        {
            Console.WriteLine("C Ucagi Kesif Yapti");

            return true;
        }
    }
}
