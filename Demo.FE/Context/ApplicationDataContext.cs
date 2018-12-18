using Hourly.FE.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Hourly.FE.Context
{
    public class ApplicationDataContext : IdentityDbContext<AppUser>
    {
        public ApplicationDataContext()
            : base("DefaultConnection")
        { }

        public System.Data.Entity.DbSet<AppUser> AppUsers { get; set; }
    }
}