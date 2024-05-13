using LSP.Ucaklar.Abstract;

namespace LSP.Ucaklar.Concrete
{
    internal class YeniSavas
    {
        private readonly List<IVurabilir> vurabilenUcaklar;
        private readonly List<IKesifYapabilir> kesifYapabilirUcaklar;

        public YeniSavas(List<IVurabilir> vurabilenUcaklar, List<IKesifYapabilir> kesifYapabilirUcaklar)
        {
            this.vurabilenUcaklar = vurabilenUcaklar;
            this.kesifYapabilirUcaklar = kesifYapabilirUcaklar;
        }

        public void KesifYap()
        {
            kesifYapabilirUcaklar.ForEach(x => x.KesifYap());
        }

        public void HEdefVur()
        {
            vurabilenUcaklar.ForEach(p => p.HedefVur());
        }
    }
}
