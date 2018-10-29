using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppDemo
{
    public partial class AjaxAction : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //result.InnerHtml = "اطلاعات با موفقیت ثبت شد";

            var name = Request.Form["name"];
            var family = Request.Form["family"];

            using (StreamWriter sw = new StreamWriter(Server.MapPath("~/SubmittedData/Users.txt"),true))
            {
                sw.WriteLine($"{name},{family}");
            }

            Thread.Sleep(3000);
            //Response.Write(Server.MapPath("~/SubmittedData/Users.dat"));
            Response.Write("اطلاعات با موفقیت ثبت شد");
            //Response.StatusCode = 503; 
            //Response.End();

        }
    }
}