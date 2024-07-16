using BusinessLogicLayer.Interface;
using BusinessLogicLayer.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace DepartmentEmployeeManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentBLL departmentBLL;
        public DepartmentController()
        {
            departmentBLL = new DepartmentBLL();
        }
        [HttpGet]
        [Route("GetDepartment/{id}")]
        public IActionResult GetDepartment(int DeptId) { 
            var department =  departmentBLL.GetEmployee(DeptId);
            return Ok(department);
        }
        [HttpGet]
        [Route("GetAllDepartmentList")]
        public IEnumerable<Department> GetAllDepartmentList() {
            return departmentBLL.GetAllEmployees();
        }
        [HttpPost]
        [Route("AddDepartment")]
        public Department AddDepartment([FromBody] Department department) {
            return null;
        }
    }
}
