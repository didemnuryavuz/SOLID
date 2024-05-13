using OCP.CoffeeExample.Abstract;

namespace OCP.CoffeeExample.Concrete
{
    public class Cappuccino : CoffeeBase
    {
        public override double GetTotalPrice(int Adet)
        {
            return Adet * 100;
        }
    }
}
