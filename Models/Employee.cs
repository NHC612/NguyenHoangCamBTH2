using System.ComponentModel.DataAnnotations;

namespace NguyenHoangCamBTH2.Models

{
    public class Employee
    {
        [Key]
        public string? EmpID { get; set; }
        public string? EmpName { get; set; }
        public String? Address { get; set; }
    }
}