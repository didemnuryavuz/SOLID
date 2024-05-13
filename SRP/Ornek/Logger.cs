using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Ornek
{
    public class Logger
    {
        private string _dosyaAdi { get; set; }
        private string _message { get; set; }
        public Logger(string DosyaAdi,string Message)
        {
            _dosyaAdi = DosyaAdi;
            _message = Message;
            
        }
        public bool Yaz(string Message)
        {
            File.WriteAllText(_dosyaAdi, _message);
            return true;
        }
    }
}
