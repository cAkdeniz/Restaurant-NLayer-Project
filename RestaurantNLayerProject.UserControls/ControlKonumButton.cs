using DevExpress.XtraEditors;
using RestaurantNLayerProject.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantNLayerProject.UserControls
{
    public class ControlKonumButton: CheckButton
    {
        public IEnumerable<Masa> Masalar { get; set; }
    }
}
