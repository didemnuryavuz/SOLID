using DIP.Loglama.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Loglama
{
    internal class Loglayici 
    {
        private readonly ILogger logger;


        //public void TextdosyayaYaz(string text)
        //{

        //}

        //public void EmailGonder(string text)
        //{

        //}
        #region Metod bazinda
        //public void SmsGonder(string text)
        //{
        //    SmsLogger logger = new SmsLogger();
        //    logger.Logla(text);

        //}
        //public void SmsGonder(SmsLogger logger  ,string text)
        //{

        //    logger.Logla(text);

        //}
        //public void DbYaz(DatabaseLogger logger, string text)
        //{
        //    logger.Logla(text);
        //}
        //public void Logla(ILogger logger, string message)
        //{
        //    logger.Logla(message);
        //} 
        #endregion

        public Loglayici(ILogger logger)
        {
            this.logger = logger;
        }
    }
}
