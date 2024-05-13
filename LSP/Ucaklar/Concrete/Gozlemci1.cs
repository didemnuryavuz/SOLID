using LSP.Ucaklar.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Ucaklar.Concrete
{
    internal class Gozlemci1 : IKesifYapabilir
    {
        public bool KesifYap()
        {
            Console.WriteLine("Gozlemci1 Ucagi Kesif yapti");
            return true;
        }
    }
}
