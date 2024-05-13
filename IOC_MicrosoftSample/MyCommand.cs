namespace IOC_MicrosoftSample
{
    public class MyCommand : ICommand
    {
        string ICommand.Command { get ; set ; }

        public void Execute()
        {
            Console.WriteLine("Execute Method Çalıştı");
        }

        public void Execute(string command)
        {
            Console.WriteLine($" {command} Execute Method Çalıştı");
        }
    }
}
