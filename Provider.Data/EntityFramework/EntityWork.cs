using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Dynamic;
using DynamicLINQ;
using Provider.Data.EntityFramework.Repository;
using Provider.Defs;

namespace Provider.Data.EntityFramework
{
    public class EntityWork : IConnection
    {
        private readonly GenericUnitOfWork _uow;

        public EntityWork()
        {
            _uow = new GenericUnitOfWork();
        }
        public EntityWork(GenericUnitOfWork uow)
        {
            _uow = uow;
        }

        public List<DataTarif> GetTarifs()
        {
            var tarifList = _uow.Repository<Tarif>().GetAll()
                .Select(a => new DataTarif { TarifId = a.TarifId, Name = a.Name, Discription = a.Discription, Price = a.Price })
                .ToList();
            return tarifList;
        }
        public List<DataAbonent> GetAbonents()
        {
            var abonentList = _uow.Repository<Abonent>().GetAll()
//                .Select(a => new DataAbonent { TarifId = a.TarifId, Name = a.Name, AbonentId = a.AbonentId, Address = a.Address })
                .Select(a => new DataAbonent { AbonentId = a.AbonentId, Name = a.Name, Address = a.Address, TarifId = a.TarifId, TName = a.Tarif.Name })
                .ToList();

            return abonentList;
        }

        private string[] Names = new[] { "AbonentId", "TarifId", "Name", "Address", "TName" };
        public List<DataAbonent> GetAbonents(int nSelect, int nSkip, int nOrder=0)
        {
            string sName = Names[nOrder];
            var abonentList = _uow.Repository<Abonent>().GetAll()
                //                .Select(a => new DataAbonent { TarifId = a.TarifId, Name = a.Name, AbonentId = a.AbonentId, Address = a.Address })
                .Select(a => new DataAbonent { AbonentId = a.AbonentId, Name = a.Name, Address = a.Address, TarifId = a.TarifId, TName = a.Tarif.Name })
                .OrderBy(sName)
                .Skip(nSkip)
                .Take(nSelect)
                .ToList();

            return abonentList;
        }

        //        public List<DataAbonent> GetAbonents()
//        {
//            //var abonentList = _uow.Repository<Abonent>().GetAll()
//            //    .Select(a => new DataAbonent { TarifId = a.TarifId, Name = a.Name, AbonentId = a.AbonentId, Address = a.Address })
//            //    .ToList();
//            var abonentList = _uow.Repository<Abonent>().GetAll()
//                .Join(_uow.Repository<Tarif>().GetAll(), a => a.TarifId, t => t.TarifId, (a, t) => new { a.AbonentId, AName = a.Name, a.Address, a.TarifId, TName = t.Name })

//    .ToList();

//            return abonentList;
//        }

        public async Task<bool> AddAbonentAsync(DataAbonent dataAbonent)
        {
            var abonent = new Abonent
            {
                TarifId = dataAbonent.TarifId,
                Address = dataAbonent.Address,
                Name = dataAbonent.Name
            };
            _uow.Repository<Abonent>().Create(abonent);
            await _uow.SaveChangesAsync();

            return true;
        }


    
    }
}
