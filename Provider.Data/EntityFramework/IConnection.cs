using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Provider.Defs;

namespace Provider.Data.EntityFramework
{
    public interface IConnection
    {
        List<DataTarif> GetTarifs();
        List<DataAbonent> GetAbonents();
        //List<object> GetAbonents();

    }
}
