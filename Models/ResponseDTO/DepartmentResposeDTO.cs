using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ResponseDTO
{
    public class DepartmentResposeDTO
    {
        public int EmpId { get; set; }
        public string? EmpName { get; set; }
        public string? Gender { get; set; }
        public int? Salary { get; set; }
        public int? DepartmentId { get; set; }
    }
}
