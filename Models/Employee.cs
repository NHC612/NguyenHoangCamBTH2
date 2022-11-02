using System.ComponentModel.DataAnnotations;
namespace NguyenHoangCamBTH2.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string? FullName { get; set; }
        public int Age { get; set; }
        public String? Sđt { get; set; }
        public string EmpID { get; internal set; }
    }
}