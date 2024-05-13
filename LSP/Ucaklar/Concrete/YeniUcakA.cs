using LSP.Ucaklar.Abstract;

namespace LSP.Ucaklar.Concrete
{
    internal class YeniUcakA : IKesifYapabilir, IVurabilir
    {
        public bool HedefVur()
        {
            Console.WriteLine("A Ucagi Hedefi Vurdu");
            return true;
        }

        public bool KesifYap()
        {
            Console.WriteLine("A Ucagi Kesif Yapti");

            return true;
        }
    }
}
