namespace IOC_MicrosoftSample
{
    public class MySqlConnection : IConnection
    {
        public bool Connection { get ; set ; }
        public string ConnectionString { get ; set; }
       
    }
}
