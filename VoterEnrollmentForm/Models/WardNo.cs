using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VoterEnrollmentForm.Models
{
    public class WardNo
    {
        [Key]
        public int WardNumberId { get; set; }
        public int ConstituencyId { get; set; }
        public string WardNumber { get; set; }
    }
}
