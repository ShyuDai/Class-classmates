using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

namespace Maticsoft.Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ( Session["LoginUser"] == null)
            {
                tr1.Visible = true;
                tr2.Visible = false;
            }
            else
            {
                tr1.Visible = false;
                tr2.Visible = true;
                BLL.Users bll=new BLL.Users();
                lblUsersName.Text = bll.GetModel((int)Session["LoginUser"]).TrueName;
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string password = txtPassword.Text.Trim();
            BLL.Users users = new BLL.Users();
            DataSet ds = users.GetList("Name='" + name + "' and Password='" + password + "'");
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["IsActivity"].ToString() == "True")
                {
                    Session["LoginUser"] = ds.Tables[0].Rows[0]["Id"];
                    Response.Redirect("~/Default.aspx");
                }
                else
                {
                    Maticsoft.Common.MessageBox.Show(this, "未激活用户！");
                }
            }
            else
            {
                Maticsoft.Common.MessageBox.Show(this, "用户名或密码错误！");
            }
        }

        protected void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/jingtai/zc.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/jingtai/grzlxg.aspx?id="+Session["LoginUser"]);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session["LoginUser"] = null;
            Response.Redirect("Default.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}
