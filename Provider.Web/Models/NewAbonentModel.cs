using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Provider.Defs;

namespace Provider.Web.Models
{
    public class NewAbonentModel
    {
        
        public int TarifId { get; set; }
        [Display(Name = "Имя")]
        public string Name { get; set; }
        [Display(Name = "Адрес")]
        public string Address { get; set; }
        [Display(Name = "Тарифы")]
        public List<DataTarif> Tarifs { get; set; }
    }
}