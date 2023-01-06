using Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repository.Base
{
   public interface IUnitOfWork:IDisposable
    {
        #region [Repository Declaration]
   
        IGenericRepository<TbUserLogin> TbUserRepository { get; }

        #endregion

        void Commit();
        void BeginTransaction();

        void CommitTransaction();

        void RollbackTransaction();

    }
}
