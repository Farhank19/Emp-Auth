using EmpAuth.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpAuth.DAO
{
    public interface EmployeeDAO
    {
        public Response RegisterEmp(Employee obj);
        public Response Login(Employee obj);
        public Response GetEmp();
        public Response GetEmpById(int id);
    }
}
