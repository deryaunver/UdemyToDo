using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using YSKProje.ToDo.Entities.Concrete;

namespace YSKProje.ToDo.Business.Interfaces
{
    public interface IGorevService : IGenericService<Gorev>
    {
        List<Gorev> GetirAciliyetIleTamamlanmayan();
        List<Gorev> GetirTumTablolarla();
        Gorev GetirAciliyetIleId(int id);
        List<Gorev> GetirileAppUserId(int appUserId);
        Gorev GetirRaporlarIdile(int id);
        List<Gorev> GetirTumTablolarla(Expression<Func<Gorev, bool>> filter);
    }
}
