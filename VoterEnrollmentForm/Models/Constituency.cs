using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VoterEnrollmentForm.Models
{
    public class Constituency
    {
        [Key]
        public int ConstituencyId { get; set; }
        public int CityId { get; set; }
        public string ConstituencyName { get; set; }
    }
}
