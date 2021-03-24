﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using YSKProje.ToDo.Entities.Concrete;

namespace YSKProje.ToDo.Web.Areas.Admin.Models
{
    public class RaporAddViewModel
    {
        [Display(Name = "Tanım:")]
        [Required(ErrorMessage = "Tanım Alanı Zorunludur **")]
        public string Tanim { get; set; }
        [Display(Name = "Detay:")]
        [Required(ErrorMessage = "Detay Alanı Zorunludur **")]
        public string Detay { get; set; }
        public  Gorev Gorev { get; set; }
        public int GorevId { get; set; }
    }
}
