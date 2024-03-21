using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EmployeeInfo.Models
{
    [Table("Employee")]
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmpName { get; set; }
        public string Gender { get; set; }
        public string EmpLocation { get; set; }
        public int DepId { get; set; }
    }
}