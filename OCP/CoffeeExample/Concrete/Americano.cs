using OCP.CoffeeExample.Abstract;

namespace OCP.CoffeeExample.Concrete
{
    public class Americano : CoffeeBase
    {
        public override double GetTotalPrice(int Adet)
        {
            return Adet * 60;
        }
    }
}
