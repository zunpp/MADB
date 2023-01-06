using Data.Models;
using Data.Repository.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Repository
{
    public class UnitOfWork:IUnitOfWork
    {
        public readonly MADBSolutionContext _context;
        public bool disposed = false;
        public IGenericRepository<TbUserLogin> _tbUserRepository;
        public UnitOfWork(MADBSolutionContext context)
        {
            _context = context;
        }

        #region [Repository Initializatiion]

        public IGenericRepository<TbUserLogin> TbUserRepository
        {
            get
            {
                return _tbUserRepository = _tbUserRepository ?? new GenericRepository<TbUserLogin>(_context);
            }

        }

      

        #endregion

        #region [Dispose and Commit]
        public void Commit()
        {
            try
            {
                _context.SaveChanges();

            }
            catch (ValidationException vexp)
            {
                foreach (var exp in vexp.Data.Values)
                {
                    string error = exp.ToString();
                    Console.WriteLine(error);
                }
            }
        }
        #endregion

        #region [Begin, Commit and Rollback Transaction]

        public void BeginTransaction()
        {
            _context.Database.BeginTransaction();
        }

        public void CommitTransaction()
        {
            _context.Database.CommitTransaction();
        }

        public void RollbackTransaction()
        {
            _context.Database.RollbackTransaction();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        #endregion
    }
}
