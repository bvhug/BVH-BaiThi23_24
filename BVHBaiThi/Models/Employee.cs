using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BVHBaiThi.Models;
public class Employee : Person 
{
    public string EmployeeID { get; set; }
    //BVH280Emp
    public string FullName { get; set; }
    public string Address { get; set; }
}

