namespace IOC_MicrosoftSample
{
    public interface ICommand
    {
        public string Command { get; set; }

        public void Execute();

        public void Execute(string command);


    }
}
