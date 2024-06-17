using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BVHBaiThi.Models;
public class Student : Person 
{
    public string StudentID { get; set; }
    //BVH280Student
    public string FullName { get; set; }
    public string Class { get; set; }
}