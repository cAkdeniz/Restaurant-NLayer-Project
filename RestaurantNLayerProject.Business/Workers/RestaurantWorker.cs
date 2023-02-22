using RestaurantNLayerProject.Business.Managers;
using RestaurantNLayerProject.Business.Services;
using RestaurantNLayerProject.DataAccess.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantNLayerProject.Business.Workers
{
    public class RestaurantWorker : IWorker
    {
        private IUnitOfWork _unitOfWork;

        public IUrunService UrunService { get; set; }
        public IPorsiyonService PorsiyonService { get; set; }
        public ITanimService TanimService { get; set; }
        public IEkMalzemeService EkMalzemeService { get; set; }
        public IMusteriService MusteriService { get; set; }
        public ITelefonService TelefonService { get; set; }
        public IAdresService AdresService { get; set; }
        public IAdisyonService AdisyonService { get; set; }
        public IMasaService MasaService { get; set; }
        public IEkMalzemeHareketService EkMalzemeHareketService { get; set; }
        public IGarsonService GarsonService { get; set; }
        public IUrunHareketService UrunHareketService { get; set; }

        public RestaurantWorker(string connectionString=null)
        {
            _unitOfWork = new RestaurantUnitOfWork(connectionString);

            UrunService = new UrunManager(_unitOfWork);
            PorsiyonService = new PorsiyonManager(_unitOfWork);
            TanimService = new TanimManager(_unitOfWork);
            EkMalzemeService = new EkMalzemeManager(_unitOfWork);
            MusteriService = new MusteriManager(_unitOfWork);
            TelefonService = new TelefonManager(_unitOfWork);
            AdresService = new AdresManager(_unitOfWork);
            AdisyonService = new AdisyonManager(_unitOfWork);
            MasaService = new MasaManager(_unitOfWork);
            EkMalzemeHareketService = new EkMalzemeHareketManager(_unitOfWork);
            GarsonService = new GarsonManager(_unitOfWork);
            UrunHareketService = new UrunHareketManager(_unitOfWork);
        }

        public bool Commit()
        {
            return _unitOfWork.Commit();
        }

        public void DetectChanges()
        {
            _unitOfWork.DetectChanges();
        }

        public bool HasChanges()
        {
            return _unitOfWork.HasChanges();
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
        // ~RestaurantWorker() {
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
