using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobSystem.Models
{
    [Table("Company", Schema = "Jobs")]//Data Annotation
    public class Company
    {
        //[Key]//PK
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]//Identity
        public int Id { get; set; }
        [MaxLength(100), Required]
        public string Name { get; set; }
        [Required, RegularExpression(@"^09\d{9}$")]
        [Column("Phone", TypeName = "varchar")]
        [Index(IsUnique = true)]
        public string CellPhone { get; set; }
        [StringLength(100, MinimumLength = 3)]
        public string Email { get; set; }
        [MaxLength(100)]
        public string Website { get; set; }
        public string LogoFilePath { get; set; }
        [MaxLength(400)]
        public string Description { get; set; }
        public virtual List<Job> Jobs { get; set; }//Lazy Loading

    }
}