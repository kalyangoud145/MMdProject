using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MMMMedia.EF.Models;
using MMMMedia.Services;
using MMMMedia.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MMMMedia.Controllers
{
    public class EmployeeController : Controller
    {

        private readonly IEmployeeService _employeeService;
        private readonly IMapper _mapper;
        //private string apiBaseUrl;
        public EmployeeController(IEmployeeService employeeService, IMapper mapper)
        {
            _employeeService = employeeService;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreateEmployee(EmployeeViewModel employeeViewModel)
        {
            employeeViewModel.DesignationList = _employeeService.GetDesignation();
            ModelState.Clear();
            return View(employeeViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> CreateEmployeePost(EmployeeViewModel response)
        {
            var model = _mapper.Map<EmployeeMaster>(response);
            if (response.EmployeeID == 0)
            {
                await _employeeService.AddEmployee(model);
            }
            else
            {
                 _employeeService.UpdateRecord(model);
            }
            return RedirectToAction("ViewRecords");
        }
        public async Task<IActionResult> ViewRecords()
        {           
            EmployeeViewModel response = new EmployeeViewModel();
            response.EmployeeMasterData = await _employeeService.GetEmployees();        
            return View(response);
        }
        public async Task<IActionResult> GetRecord(int userId)
        {
            EmployeeViewModel response = new EmployeeViewModel();
            var data = await _employeeService.GetEmployeRecord(userId);
            response = _mapper.Map<EmployeeViewModel>(data);
            return RedirectToAction("CreateEmployee", response);
        }
        public async Task<IActionResult> RemoveRecord(int userId)
        {
            await _employeeService.RemoveEmployeRecord(userId);
            return RedirectToAction("ViewRecords");
        }
    }
}
