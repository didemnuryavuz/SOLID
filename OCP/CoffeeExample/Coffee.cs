using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.CoffeeExample
{
    //OCP ye uygun olmayan ornek
    public enum CoffeeType
    {
        TurkKahvesi=1,
        Latte,
        Cappuciono,
        Expresso,
        Americano

    }
    public class Coffee
    {
        public double GetTotalPrice(double adet,CoffeeType type)
        {
            double price = 0;

            switch (type)
            {
                case CoffeeType.TurkKahvesi:
                    price += adet * 50;
                    break;
                case CoffeeType.Latte:
                    price += adet * 80;
                    break;
                case CoffeeType.Cappuciono:
                    price += adet * 100;
                    break;
                case CoffeeType.Expresso:
                    price += adet * 40;
                    break;
                case CoffeeType.Americano:
                    price += adet * 60;
                    break;
                
            }
            return price;
        }
    }
}
