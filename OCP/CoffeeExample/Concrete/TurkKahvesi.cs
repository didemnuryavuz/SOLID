using OCP.CoffeeExample.Abstract;

namespace OCP.CoffeeExample.Concrete
{
    public class TurkKahvesi : CoffeeBase
    {
        public override double GetTotalPrice(int Adet)
        {
            return Adet * 50;
        }
    }
}
