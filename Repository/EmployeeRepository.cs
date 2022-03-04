using MMMMedia.EF.Data;
using MMMMedia.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MMMMedia.Repository
{
    public interface IEmployeeRepository : IGenericRepository<EmployeeMaster>
    {
        IQueryable<DesignationMaster> GetCountryDetails();
    }
    public class EmployeeRepository : GenericRepository<EmployeeMaster>, IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;
        public EmployeeRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public IQueryable<DesignationMaster> GetCountryDetails()
        {
            return _context.DesignationMaster.AsQueryable();
        }
    }
}
