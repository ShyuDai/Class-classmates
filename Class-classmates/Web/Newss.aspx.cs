using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web
{
    public partial class Newss : System.Web.UI.Page
    {
        public string strid = ""; 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
                {
                    strid = Request.Params["id"];
                    int Id = (Convert.ToInt32(strid));
                    ShowInfo(Id);
                }
            }
        }

        private void ShowInfo(int Id)
        {
            Maticsoft.BLL.News bll = new Maticsoft.BLL.News();
            Maticsoft.Model.News model = bll.GetModel(Id);
            
            this.lblName.Text = model.Name;
            BLL.NewsType BLLNewsType = new BLL.NewsType();
            Model.NewsType ModelNewsType = BLLNewsType.GetModel((int)model.Fk_NewsType_Id);
            
            this.lblContents.Text = model.Contents;
            BLL.Users BLLUsers = new BLL.Users();
            Model.Users ModelUsers = BLLUsers.GetModel((int)model.Fk_Users_Id);
            this.lblFk_Users_Id.Text = ModelUsers.Name;
            this.lblAddTime.Text = model.AddTime.ToString();
            if (Session["LoginUser"] == null)
            {
                lblUser.Text = "匿名";
            }
            else
            { 
                BLL.Users bllleaveuser=new BLL.Users();
                Model.Users modelleaveuser = bllleaveuser.GetModel((int)Session["LoginUser"]);
                lblUser.Text = modelleaveuser.TrueName;
            }
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["Id"]);
            BLL.Leaveword bll = new BLL.Leaveword();
            Model.Leaveword model = new Model.Leaveword();
            model.Fk_News_Id = id;
            if (Session["LoginUser"] != null)
            {
                model.FK_Users_Id = (int)Session["LoginUser"];
            }
            else
            {
                model.FK_Users_Id = -1;
            }
            
            model.Contents = txtContent.Text;
            model.AddTimes = DateTime.Now;
            try
            {
                bll.Add(model);

                Maticsoft.Common.MessageBox.ShowAndRedirect(this, "留言成功！", "Newss.aspx?id="+Request["id"]);
            }
            catch
            {
                Maticsoft.Common.MessageBox.Show(this, "留言失败！");
            }
        }

        protected void rptList_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                Label lblleaveusername = e.Item.FindControl("lblleaveusername") as Label;
                string userid = lblleaveusername.Text;
                if (userid == "-1")
                {
                    lblleaveusername.Text = "匿名";
                }
                else
                {
                    BLL.Users bll = new BLL.Users();
                    lblleaveusername.Text = bll.GetModel(int.Parse(lblleaveusername.Text)).TrueName;
                }

            }
        }
    }
}