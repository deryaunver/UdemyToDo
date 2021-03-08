using System;
using System.Collections.Generic;
using System.Text;
using YSKProje.ToDo.Business.Interfaces;
using YSKProje.ToDo.DataAccess.Interfaces;
using YSKProje.ToDo.Entities.Concrete;

namespace YSKProje.ToDo.Business.Concrete
{
    public class AppUserManager:IAppUserService
    {
        private IAppUserDal _appUserDal;

        public AppUserManager(IAppUserDal appUserDal)
        {
            _appUserDal = appUserDal;
        }

        public List<AppUser> MemberGetir()
        {
            return _appUserDal.MemberGetir();
        }

        public List<AppUser> MemberGetir(out int toplamSayfa, string aranacakKelime, int aktifSayfa = 1)
        {
            return _appUserDal.MemberGetir(out toplamSayfa,aranacakKelime, aktifSayfa);
        }

       
    }
}
