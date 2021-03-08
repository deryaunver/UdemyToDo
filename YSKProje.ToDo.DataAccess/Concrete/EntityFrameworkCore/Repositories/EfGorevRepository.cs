using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using YSKProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Contexts;
using YSKProje.ToDo.DataAccess.Interfaces;
using YSKProje.ToDo.Entities.Concrete;

namespace YSKProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfGorevRepository : EfGenericRepository<Gorev>, IGorevDal
    {
        public List<Gorev> GetirAciliyetIleTamamlanmayan()
        {
            using (var context = new TodoContext())
            {
                return context.Gorevler.Include(I => I.Aciliyet).Where(I => I.Durum == false)
                    .OrderByDescending(I => I.OlusturulmaTarih).ToList();
            }
            //Eager Loading
            //Burada Include ile Eager Loading işlemi yapılıyor
            //Bana(Gorev) Aciliyetleri görevlerin false oldugu durumlarda tarihe göre listeleyip geri döndür. 
        }

        public List<Gorev> GetirTumTablolarla()
        {
            using (var context = new TodoContext())
            {
                return context.Gorevler.Include(I => I.Aciliyet).Include(I => I.Raporlar).Include(I => I.AppUser).Where(I => !I.Durum).OrderByDescending(I => I.OlusturulmaTarih).ToList();
            }
        }

        public List<Gorev> GetirileAppUserId(int appUserId)
        {
            using var context = new TodoContext();
            return context.Gorevler.Where(I => I.AppUserId == appUserId).ToList();
        }

        public Gorev GetirAciliyetIleId(int id)
        {
            using var context = new TodoContext();
            return context.Gorevler.Include(I => I.Aciliyet).FirstOrDefault(I => !I.Durum && I.Id == id);
        }

        public Gorev GetirRaporlarIdile(int id)
        {
            using var context = new TodoContext();
            return context.Gorevler.Include(I => I.Raporlar).Include(I=>I.AppUser).
                FirstOrDefault(I=>I.Id==id);
        }
    }
}
