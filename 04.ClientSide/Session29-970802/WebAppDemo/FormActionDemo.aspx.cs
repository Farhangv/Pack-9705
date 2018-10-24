using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppDemo
{
    public partial class FormActionDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            name.InnerHtml = Request.QueryString["name"];
            family.InnerHtml = Request.QueryString["family"];
        }
    }
}