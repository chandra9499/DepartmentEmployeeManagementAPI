using AutoMapper;
using BusinessLogicLayer.Interface;
using DataAccessLayer.Interface;
using DataAccessLayer.Repository;
using Models;
using Models.RequestDTO;
using Models.ResponseDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Service
{
    public class DepartmentBLL : IDepartmentBLL
    {
        private readonly IDepartmentDAL departmentDAL;
        private Mapper Mapper;
        public DepartmentBLL()
        {
            departmentDAL = new DepartmentDAL();
            //bi-directional mapping
            var RequestConfigDepartment = new MapperConfiguration(cfg => cfg.CreateMap<Department,DepartmentRequestDTO>().ReverseMap());
            var ResponseConfigDepartment = new MapperConfiguration(cfg => cfg.CreateMap<Department, DepartmentResposeDTO>().ReverseMap());
            Mapper = new Mapper(RequestConfigDepartment);
        }
        public DepartmentBLL(IDepartmentDAL departmentDAL)
        {
            this.departmentDAL = departmentDAL;
        }
        public IEnumerable<Department> GetAllEmployees()
        {
            return departmentDAL.GetAllDepartments();
        }
        public  Department GetEmployee(int DeptId)
        {
            Department department = departmentDAL.GetDepartment(DeptId);

            if (department == null)
            {
                throw new Exception($"the department not found by id {DeptId}");
            }
            return department;
        }
    }
}
