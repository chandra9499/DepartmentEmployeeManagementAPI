using System;
using System.Collections.Generic;

namespace Models
{
    public partial class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; } = null!;
        public string DepartmentLocation { get; set; } = null!;
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
