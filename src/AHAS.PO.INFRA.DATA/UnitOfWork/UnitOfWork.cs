using AHAS.PO.INFRA.DATA.Context;
using AHAS.PO.LOGIC.DOMAIN.Interfaces.UnitOfWork;
using System;

namespace AHAS.PO.INFRA.DATA.UnitOfWork
{
    public class UnitOfWork : IUnitOfWorkRepository
    {
        private readonly DataBaseContext _dataBaseContext;
        private bool _disposed;

        public UnitOfWork(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }

        public void Commit()
        {
            _dataBaseContext.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _dataBaseContext.Dispose();
                }
            }
            _disposed = true;
        }
    }
}
