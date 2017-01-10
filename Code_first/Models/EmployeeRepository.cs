using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Code_first.Models
{
    public class EmployeeRepository
    {
        public List<Department> GetDepartment()
        {
            EmployeeContext dbcontext = new EmployeeContext();
            return dbcontext.Departments.ToList();

        }
    }
}