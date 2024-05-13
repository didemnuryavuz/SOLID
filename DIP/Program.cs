using DIP.Loglama;
using DIP.Loglama.Concrete;

namespace DIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DatabaseLogger databaseLogger = new DatabaseLogger();
            FileLogger fileLogger = new FileLogger();
            SmsLogger smsLogger = new SmsLogger();
            //Loglayici loglayici = new Loglayici();
            //loglayici.DbYaz(databaseLogger, "afdasf");
            //loglayici.SmsGonder("lsdjf");
            //loglayici.SmsGonder(smsLogger, "sefsdf");

            //loglayici.Logla(smsLogger, "sdfsdfs");
            //loglayici.Logla(fileLogger, "sdfsdfs");
        }
    }
}
