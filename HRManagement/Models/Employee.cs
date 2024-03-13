using System;
using System.Collections.Generic;

namespace HRManagement.Models;

public partial class Employee
{
    public int EmpId { get; set; }

    public string? EmpName { get; set; }

    public int? Age { get; set; }

    public string? Gender { get; set; }

    public string? Mobile { get; set; }

    public int? Salary { get; set; }

    public int? DeptId { get; set; }

    public string? Department {  get; set; }

    public virtual Department? Dept { get; set; }
}
