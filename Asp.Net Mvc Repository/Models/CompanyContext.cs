using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Asp.Net_Mvc_Repository.Models
{
    public class CompanyContext : DbContext
    {
        public DbSet<Employee> Employee { get; set; }
    }
}