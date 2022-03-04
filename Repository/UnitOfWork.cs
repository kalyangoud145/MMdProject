using MMMMedia.EF.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MMMMedia.Repository
{

    public interface IUnitOfWork : IDisposable
    {
       IEmployeeRepository EmployeeRepository { get; }
        void Save();
    }

    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            EmployeeRepository = new EmployeeRepository(_dbContext);
        }

        public IEmployeeRepository EmployeeRepository { get; private set; }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
