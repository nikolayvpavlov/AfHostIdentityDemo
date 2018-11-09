using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Afdt.Models
{
    public class AfdtDbContext : IdentityDbContext<ApplicationUser> //Works if we extend DbContext
    {

        public AfdtDbContext(DbContextOptions<AfdtDbContext> options)
            : base(options)
        {
        }
    }
}
