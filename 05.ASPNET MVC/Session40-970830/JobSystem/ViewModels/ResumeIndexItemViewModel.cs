using MD.PersianDateTime;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JobSystem.ViewModels
{
    public class ResumeIndexItemViewModel
    {
        [Display(Name = "شناسه")]
        public int Id { get; set; }
        [Display(Name = "نام کاربر")]
        public string UserFullName { get; set; }
        [Display(Name = "عنوان")]
        public string Title { get; set; }
        public DateTime? ModifiedDate { get; set; }
        [Display(Name = "تاریخ آخرین ویرایش")]
        public string PersianModifiedDate
        {
            get
            {
                return (new PersianDateTime(this.ModifiedDate)).ToLongDateString();
            }
        }
        public double DownloadSize { get; set; }
    }
}