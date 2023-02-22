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
    public class AdresManager: BaseManager<Adres>, IAdresService
    {
        public AdresManager(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
    }
}
