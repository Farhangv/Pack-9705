using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace JobSystem.Models
{
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            return userIdentity;
        }
    }

    public class JobDbContext : IdentityDbContext<ApplicationUser>
    {
        public JobDbContext()
            : base("JobDbConnection", throwIfV1Schema: false)
        {
        }
        public static JobDbContext Create()
        {
            return new JobDbContext();
        }
    }
}