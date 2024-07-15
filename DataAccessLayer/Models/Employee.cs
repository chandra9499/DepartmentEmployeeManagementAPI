using System;
using System.Collections.Generic;

namespace Models
{
    public partial class Employee
    {
        public int EmpId { get; set; }
        public string? EmpName { get; set; }
        public string? Gender { get; set; }
        public int? Salary { get; set; }
        public int? DepartmentId { get; set; }

        public virtual Department? Department { get; set; }
    }
}
