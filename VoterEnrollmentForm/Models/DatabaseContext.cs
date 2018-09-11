using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VoterEnrollmentForm.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }
        public DbSet<States> States { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Constituency> Constituency { get; set; }
        public DbSet<WardNo> WardNo { get; set; }
        public DbSet<VoterEnrollment> VoterEnrollment { get; set; }
    }
}
