using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace JobSystem.Models
{
    public class JobDbContext : IdentityDbContext<ApplicationUser>
    {
        public JobDbContext()
            : base("JobDbConnection", throwIfV1Schema: false)
        {
        }

        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<Resume> Resumes { get; set; }

        public static JobDbContext Create()
        {
            return new JobDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Job>()
                .ToTable("Job", "Jobs");

            modelBuilder.Entity<Job>()
                .HasMany(j => j.Resumes)
                .WithMany(r => r.Jobs)
                .Map(m => m.ToTable("Jobs_Resumes", "Jobs"));

            modelBuilder.Entity<Resume>()
                .HasRequired(r => r.User)//موجودیت مرجع
                .WithOptional(u => u.Resume);//موجودیت وابسته

            //modelBuilder.Entity<Job>()
            //    .Property(j => j.Title)
            //    .HasColumnType("varchar");

            //modelBuilder.Entity<Company>()
            //    .HasKey(c => c.Id)
            //    .Property(c => c.Id)
            //    .IsRequired();
        }
    }
}