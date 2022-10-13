using NguyenHoangCamBTH2.Models;
using Microsoft.EntityFrameworkCore;
using LeAnhTuanBTH2.Models;

namespace NguyenHoangCamBTH2.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Student> Students {get; set;}
        public DbSet<LeAnhTuanBTH2.Models.Customer>? Customer { get; set; }
        public DbSet<NguyenHoangCamBTH2.Models.Person>? Person { get; set; }
        public DbSet<NguyenHoangCamBTH2.Models.Employee>? Employee { get; set; }
        
    }
}