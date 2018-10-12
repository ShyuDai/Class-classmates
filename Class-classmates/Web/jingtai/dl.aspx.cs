using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Maticsoft.Web.jingtai
{
    public partial class dl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
            txtName.Text = "";
            txtPassword.Text = "";
        }
    }
}