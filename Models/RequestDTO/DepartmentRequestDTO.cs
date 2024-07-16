using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RequestDTO
{
    public class DepartmentRequestDTO
    {
        public DepartmentRequestDTO()
        {
            
        }
        public string DepartmentName { get; set; } = null!;
        public string DepartmentLocation { get; set; } = null!;
    }
}
