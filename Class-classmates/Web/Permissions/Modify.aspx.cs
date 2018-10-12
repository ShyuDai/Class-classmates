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
using System.Text;
using Maticsoft.Common;
//using LTP.Accounts.Bus;
namespace Maticsoft.Web.Permissions
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int Id=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(Id);
				}
			}
		}
			
	private void ShowInfo(int Id)
	{
		Maticsoft.BLL.Permissions bll=new Maticsoft.BLL.Permissions();
		Maticsoft.Model.Permissions model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.txtName.Text=model.Name;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int Id=int.Parse(this.lblId.Text);
			String Name=this.txtName.Text;


			Maticsoft.Model.Permissions model=new Maticsoft.Model.Permissions();
			model.Id=Id;
			model.Name=Name;

			Maticsoft.BLL.Permissions bll=new Maticsoft.BLL.Permissions();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
