using ISP.KusOrnek.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.KusOrnek.Concrete
{
    public class DeveKusu :IYuruyebilir,IKosabilir
    {
        public void Kos()
        {
            throw new NotImplementedException();
        }

        public void Yuru()
        {
            throw new NotImplementedException();
        }
    }
}
