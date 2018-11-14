using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace JobSystem.Models
{
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            return userIdentity;
        }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Family { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime BirthDate { get; set; }
        [MaxLength(1)]
        public string Gender { get; set; }
        [MaxLength(200)]
        public string PhotoFilePath { get; set; }

        public virtual Resume Resume { get; set; }

    }
}