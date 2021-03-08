using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YSKProje.ToDo.Web.Areas.Admin.Models
{
    public class AppUserRoleModel
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public string UserName { get; set; }
    }
}
