using RestaurantNLayerProject.Entities.Base.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantNLayerProject.Entities.Tables
{
    public class Musteri: EntityBase
    {
        public string Adi { get; set; }

        public string Soyadi { get; set; }

        public string Sirket { get; set; }

        public string KartNo { get; set; }

        public ICollection<Telefon> Telefonlar { get; set; }

        public ICollection<Adres> Adresler { get; set; }
    }
}
