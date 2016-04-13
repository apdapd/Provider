namespace Provider.Data.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Abonent")]
    public partial class Abonent
    {
        public int AbonentId { get; set; }

        public int TarifId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        public virtual Tarif Tarif { get; set; }
    }
}
