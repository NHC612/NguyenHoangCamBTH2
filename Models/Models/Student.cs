using System.ComponentModel.DataAnnotations;

namespace NguyenHoangCamBTH2.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public int Age { get; set; }
        public String? Sđt { get; set; }
    }
}