using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Asp.Net_Mvc_Repository.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public Department Department { get; set; }
        public string Phone { get; set; }
        public bool IsActive { get; set; }
    }

    public enum Department
    {
        Sales,Management,Security
    }

    public enum Gender
    {
        Male,Female
    }
}