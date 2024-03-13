using HRManagement.Data;
using HRManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace HRManagement.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly HrdbContext db;
        public EmployeeController(HrdbContext context)
        {
            db = context;            
        }
        public IActionResult Index()
        {
            try
            {
                var empList = from e in db.Employees
                              join d in db.Departments
                              on e.DeptId equals d.DeptId
                              into Dept
                              from d in Dept.DefaultIfEmpty()

                              select new Employee
                              {
                                  EmpId = e.EmpId,
                                  EmpName = e.EmpName,
                                  Age = e.Age,
                                  Gender = e.Gender,
                                  Mobile = e.Mobile,
                                  Salary = e.Salary,
                                  DeptId = e.DeptId,
                                  Department = d == null ? "" : d.Department1
                              };

                return View(empList);
            }
            catch (Exception)
            {

                return View();
            }

            
        }
    }
}
