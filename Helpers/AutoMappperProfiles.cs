using AutoMapper;
using MMMMedia.EF.Models;
using MMMMedia.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MMMMedia.Helpers
{
    public class AutoMappperProfiles : Profile
    {
        public AutoMappperProfiles()
        {
            CreateMap<EmployeeViewModel, EmployeeMaster>();
            CreateMap<EmployeeMaster, EmployeeViewModel>();
        }
    }
}
