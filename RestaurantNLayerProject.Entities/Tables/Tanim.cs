using RestaurantNLayerProject.Entities.Base.Tables;
using RestaurantNLayerProject.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantNLayerProject.Entities.Tables
{
    public class Tanim: EntityBase
    {
        public string Adi { get; set; }

        public TanimTip TanimTip { get; set; }
    }
}
