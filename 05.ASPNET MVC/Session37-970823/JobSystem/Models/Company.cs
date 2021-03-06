﻿using System;
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
        public int Id { get; set; }
        [MaxLength(100, ErrorMessage = "حداکثر طول اسم شرکت ۱۰۰ کاراکتر است"), Required(ErrorMessage = "فیلد نام شرکت اجباری است"), Display(Name = "نام شرکت")]
        public string Name { get; set; }
        [Required, RegularExpression(@"^09\d{9}$", ErrorMessage = "شماره موبایل با فرمت صحیح وارد نشده"), Display(Name = "موبایل")]
        [Column("Phone", TypeName = "varchar")]
        [Index(IsUnique = true)]
        public string CellPhone { get; set; }
        [StringLength(100, MinimumLength = 3), Display(Name = "ایمیل")]
        public string Email { get; set; }
        [MaxLength(100), Display(Name = "وب سایت")]
        public string Website { get; set; }
        public string LogoFilePath { get; set; }
        [MaxLength(400), Display(Name = "توضیحات")]
        public string Description { get; set; }

        public virtual List<Job> Jobs { get; set; }//Lazy Loading

    }
}