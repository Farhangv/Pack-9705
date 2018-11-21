using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobSystem.ViewModels
{
    public class JobIndexItemViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string CompanyName { get; set; }
        public string CompanyLogoPath { get; set; }
    }
}