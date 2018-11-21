using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace JobSystem
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class MathService : System.Web.Services.WebService
    {

        [WebMethod]
        public int Sum(int x, int y)
        {
            return x + y;
        }
    }
}
