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
    public class PorsiyonDal: Repository<Porsiyon>, IPorsiyonDal
    {
        public PorsiyonDal(DbContext context): base(context)
        {

        }
    }
}
