using RestaurantNLayerProject.Entities.Base.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantNLayerProject.DataAccess.Functions
{
    public static class EntityBaseInfo
    {
        public static void Add(DbContext context)
        {
            foreach (var entry in context.ChangeTracker.Entries())
            {
                EntityBase changeEntity = (EntityBase)entry.Entity;

                switch (entry.State)
                {
                    case EntityState.Added:
                        if (changeEntity.Id == Guid.Empty)
                        {
                            changeEntity.Id = Guid.NewGuid();
                        }
                        changeEntity.Ekleyen = "Çağatay Akdeniz";
                        changeEntity.EklenmeTarihi = DateTime.Now;
                        break;

                    case EntityState.Modified:
                        changeEntity.Duzenleyen = "Ayaz Akdeniz";
                        changeEntity.DuzenlenmeTarihi = DateTime.Now;
                        break;
                }
            }
        }
    }
}
