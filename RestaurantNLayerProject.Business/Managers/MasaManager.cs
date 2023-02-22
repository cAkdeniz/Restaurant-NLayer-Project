using RestaurantNLayerProject.Business.Managers.Base;
using RestaurantNLayerProject.Business.Services;
using RestaurantNLayerProject.DataAccess.UnitOfWork;
using RestaurantNLayerProject.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantNLayerProject.Business.Managers
{
    public class MasaManager : BaseManager<Masa>, IMasaService
    {
        public MasaManager(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
    }
}
