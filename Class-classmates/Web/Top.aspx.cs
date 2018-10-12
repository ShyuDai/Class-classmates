using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web
{
    public partial class Top : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            { 
                if(Session["UsersId"]!=null)
                {
                    int UsersId = (int)Session["UsersId"];
                    BLL.Users users =new BLL.Users();
                    lblUsersId.Text = users.GetModel(UsersId).TrueName;
                }
                
            }
        }
    }
}