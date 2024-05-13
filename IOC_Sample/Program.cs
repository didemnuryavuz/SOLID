using System.Runtime.CompilerServices;
using Unity;
using Unity.Injection;

namespace IOC_Sample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Standart Nesne Olusturulmasi
            BMW bMW = new BMW();
            Ford ford = new Ford();
            Mercedes mercedes = new Mercedes();


            Driver driver= new Driver(bMW);
            driver.RunCar();
            driver.RunCar();
            driver.RunCar();
            #endregion

            IUnityContainer container = new UnityContainer();

            #region Standart Unity Kullanimi

            //Container a register edilmesi

            container.RegisterType<ICar, BMW>("Bmw");
            container.RegisterType<ICar, Ford>("Ford");
            container.RegisterType<ICar, Mercedes>("Mercedes");

            //container.RegisterType(typeof(Driver));
            ICar BMW = container.Resolve<ICar>("Bmw");
            ICar Ford = container.Resolve<ICar>("Ford");
            ICar Mercedes = container.Resolve<ICar>("Mercedes");

            container.RegisterType<Driver>("BmwDriver", new InjectionConstructor(bmw));
            container.RegisterType<Driver>("FordDriver", new InjectionConstructor(ford));
            container.RegisterType<Driver>("MercedesDriver", new InjectionConstructor(mercedes));

            //Resolve edilmesi

            ICar car=container.Resolve<ICar>();
            Driver driver1 = container.Resolve<Driver>();
            driver1.RunCar();
            driver1.RunCar();
            driver1.RunCar();
            driver1.RunCar();
            driver1.RunCar();


            #endregion
        }
    }
    public interface ICar
    {
        int Run();
    }
    public class BMW : ICar
    {
        private int _miles = 0;
        public int Run()
        {
            return ++_miles;
        }
    }
    public class Ford : ICar
    {
        private int _miles = 0;
        public int Run()
        {
            return ++_miles;
        }
    }
    public class Mercedes : ICar
    {
        private int _miles = 0;
        public int Run()
        {
            return ++_miles;
        }
    }

    public class Driver
    {
        private readonly ICar car;
        public Driver(ICar car)
        {
            this.car = car;
        }

        public void RunCar()
        {
            Console.WriteLine($"Running {car.GetType().Name} => {car.Run()} km");
        }
    }
}
