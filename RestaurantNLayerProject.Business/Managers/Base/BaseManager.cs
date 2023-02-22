using RestaurantNLayerProject.Business.Services.Base;
using RestaurantNLayerProject.DataAccess.UnitOfWork;
using RestaurantNLayerProject.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantNLayerProject.Business.Managers.Base
{
    public class BaseManager<TEntity> : IBaseService<TEntity> where TEntity : class, IEntity, new()
    {
        private IUnitOfWork _unitOfWork;

        public BaseManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public virtual void Add(TEntity entity)
        {
            _unitOfWork.Dal<TEntity>().Add(entity);
        }

        public virtual void Add(IEnumerable<TEntity> entities)
        {
            _unitOfWork.Dal<TEntity>().Add(entities);
        }

        public virtual void AddOrUpdate(TEntity entity)
        {
            _unitOfWork.Dal<TEntity>().AddOrUpdate(entity);
        }

        public virtual void AddOrUpdate(IEnumerable<TEntity> entities)
        {
            _unitOfWork.Dal<TEntity>().AddOrUpdate(entities);
        }

        public virtual BindingList<TEntity> BindingList()
        {
            return _unitOfWork.Dal<TEntity>().BindingList();
        }

        public virtual void Delete(TEntity entity)
        {
            _unitOfWork.Dal<TEntity>().Delete(entity);
        }

        public virtual void Delete(IEnumerable<TEntity> entities)
        {
            _unitOfWork.Dal<TEntity>().Delete(entities);
        }

        public virtual void Delete(Expression<Func<TEntity, bool>> filter)
        {
            _unitOfWork.Dal<TEntity>().Delete(filter);
        }

        public void EntityStateChange(Expression<Func<TEntity, bool>> filter, EntityState state)
        {
            _unitOfWork.Dal<TEntity>().EntityStateChange(filter, state);
        }

        public void EntityStateChange(TEntity entity, EntityState state)
        {
            _unitOfWork.Dal<TEntity>().EntityStateChange(entity, state);
        }

        public void EntityStateChange(IEnumerable<TEntity> entities, EntityState state)
        {
            _unitOfWork.Dal<TEntity>().EntityStateChange(entities, state);
        }

        public virtual bool Exist(Expression<Func<TEntity, bool>> filter)
        {
            return _unitOfWork.Dal<TEntity>().Exist(filter);
        }

        public virtual TEntity Get(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includes)
        {
            return _unitOfWork.Dal<TEntity>().Get(filter, includes);
        }

        public virtual IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includes)
        {
            return _unitOfWork.Dal<TEntity>().GetList(filter, includes);
        }

        public virtual bool HasChange()
        {
            return _unitOfWork.Dal<TEntity>().HasChange();
        }

        public virtual void Load(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includes)
        {
            _unitOfWork.Dal<TEntity>().Load(filter, includes);
        }

        public virtual IQueryable<TEntity> Select(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TEntity>> selector, params Expression<Func<TEntity, object>>[] includes)
        {
            return _unitOfWork.Dal<TEntity>().Select(filter, selector, includes);
        }

        public virtual IQueryable<TResult> Select<TResult>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TResult>> selector, params Expression<Func<TEntity, object>>[] includes)
        {
            return _unitOfWork.Dal<TEntity>().Select(filter, selector, includes);
        }

        public virtual void Update(TEntity entity)
        {
            _unitOfWork.Dal<TEntity>().Update(entity);
        }

        public virtual void Update(IEnumerable<TEntity> entities)
        {
            _unitOfWork.Dal<TEntity>().Update(entities);
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
        // ~BaseManager() {
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
