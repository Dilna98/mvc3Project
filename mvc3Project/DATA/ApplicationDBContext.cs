using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using Microsoft.Data;
using mvc3Project.Models;
namespace mvc3Project.DATA
{
    public class ApplicationDBContext:DbContext
    {
        

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        public DbSet<Register> Register { get; set; }
    }
}
