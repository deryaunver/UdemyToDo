using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using YSKProje.ToDo.Entities.Concrete;

namespace YSKProje.ToDo.DataAccess.Interfaces
{
    public interface IGorevDal : IGenericDal<Gorev>
    {
        List<Gorev> GetirAciliyetIleTamamlanmayan();
        List<Gorev> GetirTumTablolarla();
        List<Gorev> GetirTumTablolarla(Expression<Func<Gorev,bool>>filter);
        List<Gorev> GetirileAppUserId(int appUserId);
        Gorev GetirAciliyetIleId(int id);
        Gorev GetirRaporlarIdile(int id);
    }
}
