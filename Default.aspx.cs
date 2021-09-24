using RestApp.Controllers;
using RestApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RestApp
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Controller c = new Controller();
            
            c.GetApiTest();
            c.GetApiTest(2);
            c.PostApiTest(new TestModelClass(1, "example"));
            c.PutApiTest(new TestModelClass(2, "example2"));
            c.DeleteApiTest(2);
            
        }
    }
}