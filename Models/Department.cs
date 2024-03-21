using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EmployeeInfo.Models
{
    [Table("Department")]   
    public class Department
    {

        public int DepId { get; set; }
        public string DepName { get; set; }
        public List<Employee> Employees  { get; set; }
}
}