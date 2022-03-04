using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MMMMedia.EF.Models
{
    public class EmployeeMaster
    {
        [Key]
        public int EmployeeID { get; set; }
        [MaxLength(8)]
        public string EmployeeNo { get; set; }
        [Required]
        [MaxLength(100)]
        public string EmployeeName { get; set; }  
        public int DesignationId { get; set; }
        public virtual DesignationMaster Designation { get; set; }
        [Required]
        [MaxLength(15)]
        public string Mobile { get; set; }
        [Required]
        [MaxLength(100)]
        public string Email { get; set; }            
        [MaxLength(1000)]
        public string Address { get; set; }        
  
    }
}
