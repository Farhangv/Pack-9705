﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobSystem.Models
{
    [Table("Resume", Schema = "Jobs")]
    public class Resume
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        public byte[] ResumeFile { get; set; }
        [MaxLength(20)]
        public string MimeType { get; set; }
        [MaxLength(100)]
        public string OriginalFileName { get; set; }
        public int FileSize { get; set; }
        public virtual List<Job> Jobs { get; set; }

        public virtual ApplicationUser User { get; set; }

    }
}