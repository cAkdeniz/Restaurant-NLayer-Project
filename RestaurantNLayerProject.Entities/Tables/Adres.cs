using RestaurantNLayerProject.Entities.Base.Tables;
using RestaurantNLayerProject.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantNLayerProject.Entities.Tables
{
    public class Adres: EntityBase
    {
        public TelefonAdresTip AdresTip { get; set; }

        public string Il { get; set; }

        public string Ilce { get; set; }

        public string Semt { get; set; }

        public string Adresi { get; set; }

        public Guid MusteriId { get; set; }

        public virtual Musteri Musteri { get; set; }
    }
}
