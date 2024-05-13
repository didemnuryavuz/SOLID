namespace IOC_MicrosoftSample
{
    public interface IConnection
    {
        public bool Connection { get; set; }

        public string ConnectionString { get; set; }
    }
}
