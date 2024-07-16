using DataAccessLayer.Interface;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class DepartmentDAL : IDepartmentDAL
    {
        private readonly DepartmentEmployeeContext departmentEmployeeContext;
        public DepartmentDAL() 
        {
            departmentEmployeeContext = new DepartmentEmployeeContext();
        }  

        public DepartmentDAL(DepartmentEmployeeContext departmentEmployeeContext)
        {
            this.departmentEmployeeContext=departmentEmployeeContext;
        }

        public IEnumerable<Department> GetAllDepartments()
        {
            return departmentEmployeeContext.Departments.ToList();
        }

        public Department GetDepartment(int deptid)
        {
            return departmentEmployeeContext.Departments.Where(dept => dept.DepartmentId.Equals(deptid)).FirstOrDefault();
        }
    }
}
