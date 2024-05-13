using Microsoft.Extensions.DependencyInjection;

namespace IOC_MicrosoftSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceProvider serviceProvider = new ServiceCollection()
                .AddTransient<IConnection, MySqlConnection>()          //Her IConnection istendiginde MySqlConnection nesnesini yeniden inctance al.
                .AddSingleton<ICommand, MyCommand>()                   //ICommand nesnesini kac kere isterseniz isteyin isteyi hep ayni instance'i verecektir.
                .BuildServiceProvider();


            var connection1=serviceProvider.GetService<IConnection>();
            var connection2 = serviceProvider.GetService<IConnection>();

            Console.WriteLine("Connection1 HashCode "+connection1.GetHashCode()+ "\nConnection2 HashCode "+connection2.GetHashCode());

            var command1= serviceProvider.GetService<ICommand>();
            var command2 = serviceProvider.GetService<ICommand>();

            Console.WriteLine("Command1 HashCode " + command1.GetHashCode() + "\nCommand2 HashCode " + command2.GetHashCode());
        }
    }
}
