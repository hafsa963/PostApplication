using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PostApplication.Models
{
    public class DbCnx : IdentityDbContext<AppUser>
    {
        public DbCnx(DbContextOptions<DbCnx> options) : base(options)
        {

        }
        

    }
}