using RestaurantNLayerProject.Entities.Base.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantNLayerProject.Entities.Tables
{
    public class Porsiyon: EntityBase
    {
        public string Adi { get; set; }

        public decimal Fiyat { get; set; }

        public decimal EkMalzemeCarpan { get; set; }

        public Guid UrunId { get; set; }

        public virtual Urun Urun { get; set; }

        public Guid BirimId { get; set; }

        public virtual Tanim Birim { get; set; }
    }
}
