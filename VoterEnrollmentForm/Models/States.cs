using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VoterEnrollmentForm.Models
{
    public class States
    {
        [Key]
        public int StateId { get; set; }
        public string StateName { get; set; }

        [NotMapped]
        public int CityId { get; set; }
        [NotMapped]
        public int ConstituencyId { get; set; }
        [NotMapped]
        public int WardNumberId { get; set; }
        [NotMapped]
        public string EnrollerName { get; set; }
        [NotMapped]
        public string FatherName { get; set; }
        [NotMapped]
        public DateTime DOB { get; set; }
        [NotMapped]
        public string Email { get; set; }
        [NotMapped]
        public string PhoneNumber { get; set; }
        [NotMapped]
        public DateTime DateCreated { get; set; }
        [NotMapped]
        public string EnrollmentNumber { get; set; }
    }
}
