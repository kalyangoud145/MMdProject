using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MMMMedia.EF.Models
{
    public class DesignationMaster
    {
        [Key]
        public int DesignationID { get; set; }
        [MaxLength(75)]
        public string DesignationName { get; set; }
    }
}
