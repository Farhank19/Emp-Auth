using EmpAuth.DAO;
using EmpAuth.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpAuth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeDAO employeeDAO;
        public EmployeeController(EmployeeDAO employeeDAO)
        {
            this.employeeDAO = employeeDAO;
        }
        [HttpPost]
        public IActionResult Register(Employee data)
        {
            return Ok(employeeDAO.RegisterEmp(data));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var obj = employeeDAO.GetEmp();
            return Ok(obj);
        }

        [HttpPost]
        [Route("Login")]
        public IActionResult Login(Employee data)
        {
            return Ok(employeeDAO.Login(data));
        }
        //[HttpGet("{id}")]
        //public IActionResult GetById(int Id)
        //{
        //    var obj = employeeDAO.GetStudent(Id);
        //    return Ok(obj);
        //}
        //[HttpPut]
        //public IActionResult Put(Employee data)
        //{
        //    var obj = employeeDAO.UpdateStudent(data);
        //    return Ok(obj);
        //}


    }
}
