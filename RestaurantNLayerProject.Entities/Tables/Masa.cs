using RestaurantNLayerProject.Entities.Base.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantNLayerProject.Entities.Tables
{
    public class Masa : EntityBase
    {
        public string Adi { get; set; }

        public bool Dolu { get; set; }

        public int Kapasite { get; set; }

        public Guid KonumId { get; set; }

        public virtual Tanim Konum { get; set; }

    }
}
