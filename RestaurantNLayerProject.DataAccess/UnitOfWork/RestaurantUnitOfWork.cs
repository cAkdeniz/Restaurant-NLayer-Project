using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantNLayerProject.Core.Functions;
using RestaurantNLayerProject.DataAccess.Contexts.Restaurant;
using RestaurantNLayerProject.DataAccess.Functions;
using RestaurantNLayerProject.DataAccess.IRepositories;
using RestaurantNLayerProject.DataAccess.IRepositories.Base;
using RestaurantNLayerProject.DataAccess.Repositories;
using RestaurantNLayerProject.DataAccess.Repositories.Base;

namespace RestaurantNLayerProject.DataAccess.UnitOfWork
{
    public class RestaurantUnitOfWork : IUnitOfWork
    {
        private readonly RestaurantContext _context;

        public IUrunDal UrunDal { get; set; }
        public IPorsiyonDal PorsiyonDal { get; set; }
        public ITanimDal TanimDal { get; set; }
        public IEkMalzemeDal EkMalzemeDal { get; set; }
        public IMusteriDal MusteriDal { get; set; }
        public ITelefonDal TelefonDal { get; set; }
        public IAdresDal AdresDal { get; set; }
        public IAdisyonDal AdisyonDal { get; set; }
        public IMasaDal MasaDal { get; set; }
        public IGarsonDal GarsonDal { get; set; }
        public IEkMalzemeHareketDal EkMalzemeHareketDal { get; set; }
        public IUrunHareketDal UrunHareketDal { get; set; }

        public RestaurantUnitOfWork(string connectionString = null)
        {
            if (connectionString == null)
            {
                _context = new RestaurantContext(ConnectionStringInfo.Get());
            }
            else
            {
                _context = new RestaurantContext(connectionString);
            }

            UrunDal = new UrunDal(_context);
            PorsiyonDal = new PorsiyonDal(_context);
            TanimDal = new TanimDal(_context);
            EkMalzemeDal = new EkMalzemeDal(_context);
            MusteriDal = new MusteriDal(_context);
            TelefonDal = new TelefonDal(_context);
            AdresDal = new AdresDal(_context);
            AdisyonDal = new AdisyonDal(_context);
            MasaDal = new MasaDal(_context);
            GarsonDal = new GarsonDal(_context);
            EkMalzemeHareketDal = new EkMalzemeHareketDal(_context);
            UrunHareketDal = new UrunHareketDal(_context);
        }

        public bool Commit()
        {
            EntityBaseInfo.Add(_context);
            try
            {
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                throw e;  
            }
        }

        public void DetectChanges()
        {
            _context.ChangeTracker.DetectChanges();
        }

        public bool HasChanges()
        {
            return _context.ChangeTracker.HasChanges();
        }

        IRepository<TEntity> IUnitOfWork.Dal<TEntity>()
        {
            return new Repository<TEntity>(_context);
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~RestaurantUnitOfWork() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
