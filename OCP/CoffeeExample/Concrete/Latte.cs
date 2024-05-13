using OCP.CoffeeExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.CoffeeExample.Concrete
{
    public class Latte : CoffeeBase
    {
        public override double GetTotalPrice(int Adet)
        {
            return Adet * 80;
        }
    }
}
