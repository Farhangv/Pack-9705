namespace EFCodeFirstDemo
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CFModel : DbContext
    {
        public CFModel():
            base("CFModel")
        {
        }
        public virtual DbSet<Person> People { get; set; }
    }
}