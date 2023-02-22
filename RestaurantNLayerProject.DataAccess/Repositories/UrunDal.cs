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
    public class UrunDal: Repository<Urun>,IUrunDal
    {
        public UrunDal(DbContext context): base(context)
        {

        }
    }
}
