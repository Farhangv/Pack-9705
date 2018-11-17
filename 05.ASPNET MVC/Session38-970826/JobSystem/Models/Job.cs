using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobSystem.Models
{
    public class Job
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Title { get; set; }
        [MaxLength(1000)]
        public string Description { get; set; }
        public DateTime ValidDate { get; set; }
        [MaxLength(50)]
        public string Location { get; set; }
        public int Count { get; set; }
        public int Wage { get; set; }

        public Company Company { get; set; } //Eager Loading
        public int CompanyId { get; set; }

        public virtual List<Resume> Resumes { get; set; }

    }
}