using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Provider.Defs;

namespace Provider.Web.Models
{
    public class AbonentModel 
    {
        public List<DataAbonent> Abonents { get; set; }
        public PagingInfo PagingInfo { get; set; } 
    }
}