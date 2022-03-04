using MMMMedia.EF.Models;
using MMMMedia.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MMMMedia.Services
{
    public interface IEmployeeService
    {         
        Task AddEmployee(EmployeeMaster employeeMaster);
        Task RemoveEmployeRecord(int id);
        void UpdateRecord(EmployeeMaster model);
        IEnumerable<DesignationMaster> GetDesignation();
        Task<IEnumerable<EmployeeMaster>> GetEmployees();
        Task<EmployeeMaster> GetEmployeRecord(int id);
    }
    public class EmployeeService : IEmployeeService
    {
        private readonly IUnitOfWork _unitofWork;
        public EmployeeService(IUnitOfWork unitofWork)
        {
            _unitofWork = unitofWork;
        }
        public async Task AddEmployee(EmployeeMaster employeeMaster)
        {
            await _unitofWork.EmployeeRepository.AddAsync(employeeMaster);
            _unitofWork.Save();
        }
        public async Task RemoveEmployeRecord(int id)
        {
            await _unitofWork.EmployeeRepository.RemoveAsync(id);
            _unitofWork.Save();
        }
        public void UpdateRecord(EmployeeMaster model)
        {
            _unitofWork.EmployeeRepository.UdpdateAsync(model);
            _unitofWork.Save();
        }
        public IEnumerable<DesignationMaster> GetDesignation()
        {
            return _unitofWork.EmployeeRepository.GetCountryDetails();
        }
        public async Task<IEnumerable<EmployeeMaster>> GetEmployees()
        {
            var records = await _unitofWork.EmployeeRepository.GetAllAsync(includeProperties: "Designation");
            return records;
        }
        public async Task<EmployeeMaster> GetEmployeRecord(int id)
        {
            return await _unitofWork.EmployeeRepository.GetFirstOrDefaultAsync(i => i.EmployeeID == id);
        }       
    }
}
