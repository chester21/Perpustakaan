using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SoFTLibrary.Framework.UI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
            }
        }

        protected void BtnLogin_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx",false);
        }
    }
}