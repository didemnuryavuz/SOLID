using ISP.KusOrnek.Abstract;

namespace ISP.KusOrnek.Concrete
{
    public class DenizKartali : IYuruyebilir, IKosabilir, IYuzebilir, IUcabilir
    {
        public void Kos()
        {
            throw new NotImplementedException();
        }

        public void Uc()
        {
            throw new NotImplementedException();
        }

        public void Yuz()
        {
            throw new NotImplementedException();
        }

        void IYuruyebilir.Yuru()
        {
            throw new NotImplementedException();
        }
    }
}
