using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using YSKProje.ToDo.Business.Interfaces;
using YSKProje.ToDo.Entities.Concrete;
using YSKProje.ToDo.Web.Areas.Admin.Models;

namespace YSKProje.ToDo.Web.Areas.Member.Controllers
{
    [Area("Member")]
    [Authorize(Roles = "Member")]
    public class IsEmriController : Controller
    {
        private readonly IGorevService _gorevService;
        private readonly UserManager<AppUser> _userManager;
        private readonly IRaporService _raporService;
        public IsEmriController(IGorevService gorevService, UserManager<AppUser> userManager, IRaporService raporService)
        {
            _gorevService = gorevService;
            _userManager = userManager;
            _raporService = raporService;
        }
        public async Task<IActionResult> Index()
        {
            TempData["Active"] = "isemri";
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            //var gorevler = _gorevService.GetirTumTablolarla(I => I.AppUserId == id && I.Durum==false);
            var gorevler = _gorevService.GetirTumTablolarla(I => I.AppUserId == user.Id && I.Durum == false);
            List<GorevListAllViewModel> models = new List<GorevListAllViewModel>();
            foreach (var item in gorevler)
            {
                GorevListAllViewModel model = new GorevListAllViewModel();

                model.Id = item.Id;
                model.Ad = item.Ad;
                model.Aciklama = item.Aciklama;
                model.Aciliyet = item.Aciliyet;
                model.OlusturulmaTarih = item.OlusturulmaTarih;
                model.Raporlar = item.Raporlar;
                model.AppUser = item.AppUser;
                models.Add(model);
            }
            return View(models);
        }

        public IActionResult EkleRapor(int id)
        {
            TempData["Active"] = "isemri";
            var gorev = _gorevService.GetirAciliyetIleId(id);
            RaporAddViewModel model = new RaporAddViewModel();
            model.GorevId = id;
            model.Gorev = gorev;
            return View(model);
        }
    }
}
