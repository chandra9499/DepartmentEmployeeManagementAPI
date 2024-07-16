using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface
{
    public interface IDepartmentDAL
    {
        Department GetDepartment(int dept_id);
        IEnumerable<Department> GetAllDepartments();
    }
}
