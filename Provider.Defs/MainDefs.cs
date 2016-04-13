using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Provider.Defs
{
    public class MainDefs
    {
    }

    public class DataAbonent
    {
        public int AbonentId { get; set; }
        public int TarifId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string TName { get; set; }
    }

    public class DataTarif
    {
        public int TarifId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Discription { get; set; }

    }
}
