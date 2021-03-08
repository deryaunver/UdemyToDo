using System;
using System.Collections.Generic;
using System.Text;
using YSKProje.ToDo.Entities.Concrete;

namespace YSKProje.ToDo.Business.Interfaces
{
    public interface IAppUserService
    {
        List<AppUser> MemberGetir();
        List<AppUser> MemberGetir(out int toplamSayfa, string aranacakKelime, int aktifSayfa = 1);
    }
}
