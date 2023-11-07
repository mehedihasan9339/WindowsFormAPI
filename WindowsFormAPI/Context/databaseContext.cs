using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WindowsFormAPI.Data.Auth;
using WindowsFormAPI.Data.Employee;

namespace WindowsFormAPI.Context
{
    public class databaseContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public databaseContext(DbContextOptions<databaseContext> options) : base(options)
        {

        }

        public DbSet<EmployeeInfo> EmployeeInfo { get; set; }
    }
}
