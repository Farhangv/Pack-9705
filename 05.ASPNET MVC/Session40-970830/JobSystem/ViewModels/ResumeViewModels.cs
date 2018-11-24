using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobSystem.ViewModels
{
    public class ResumesEditViewModel
    {
        public string Title { get; set; }

        public HttpPostedFileBase UploadedResumeFile { get; set; }
    }
}