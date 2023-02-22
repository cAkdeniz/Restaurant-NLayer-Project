using RestaurantNLayerProject.DataAccess.IRepositories;
using RestaurantNLayerProject.DataAccess.Repositories.Base;
using RestaurantNLayerProject.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantNLayerProject.DataAccess.Repositories
{
    public class EkMalzemeHareketDal : Repository<EkMalzemeHareket>, IEkMalzemeHareketDal
    {
        public EkMalzemeHareketDal(DbContext context) : base(context)
        {

        }
    }
}
