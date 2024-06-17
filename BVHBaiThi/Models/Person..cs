using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BVHBaiThi.Models;
[Table("Person")]
public class Person 
{
    [Key]
    public string PersonID { get; set; }
    //BVH280Person
    public string FullName { get; set; }
    public string Address { get; set; }
}