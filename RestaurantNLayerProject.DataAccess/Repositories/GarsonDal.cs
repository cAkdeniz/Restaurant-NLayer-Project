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
    public class GarsonDal : Repository<Garson>, IGarsonDal
    {
        public GarsonDal(DbContext context) : base(context)
        {

        }
    }
}
