using MMMMedia.EF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MMMMedia.ViewModels
{
    public class EmployeeViewModel
    {

        [Required]
        public int EmployeeID { get; set; }
        [MaxLength(8)]
        public string EmployeeNo { get; set; }
        [Required]
        [MaxLength(100)]
        public string EmployeeName { get; set; }
        public int DesignationId { get; set; } 
        [Required]
        [MaxLength(15)]
        public string Mobile { get; set; }
        [Required]
        [MaxLength(100)]
        public string Email { get; set; }
        [MaxLength(1000)]
        public string Address { get; set; }
        public IEnumerable<DesignationMaster> DesignationList { get; set; }
        public IEnumerable<EmployeeMaster> EmployeeMasterData { get; set; }
    }
}
