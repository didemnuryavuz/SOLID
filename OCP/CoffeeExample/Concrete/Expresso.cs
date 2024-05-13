using OCP.CoffeeExample.Abstract;

namespace OCP.CoffeeExample.Concrete
{
    public class Expresso : CoffeeBase
    {
        public override double GetTotalPrice(int Adet)
        {
            return Adet * 50;
        }
    }
}
