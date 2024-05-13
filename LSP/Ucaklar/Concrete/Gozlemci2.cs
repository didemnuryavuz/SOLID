using LSP.Ucaklar.Abstract;

namespace LSP.Ucaklar.Concrete
{
    internal class Gozlemci2 : IKesifYapabilir
    {
        public bool KesifYap()
        {
            Console.WriteLine("Gozlemci2 Kesif yapti");
            return true;
        }
    }
}
