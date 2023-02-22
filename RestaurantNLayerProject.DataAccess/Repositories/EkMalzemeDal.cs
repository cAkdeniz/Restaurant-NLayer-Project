﻿using RestaurantNLayerProject.DataAccess.IRepositories;
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
    public class EkMalzemeDal: Repository<EkMalzeme>, IEkMalzemeDal
    {
        public EkMalzemeDal(DbContext context): base(context)
        {

        }
    }
}
