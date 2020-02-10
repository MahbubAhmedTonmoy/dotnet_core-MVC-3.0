using System;

namespace Uplift.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
         ICategoryRepository Category {get;}
         void Save();
    }
}