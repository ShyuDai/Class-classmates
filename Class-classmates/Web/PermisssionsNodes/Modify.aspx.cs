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
namespace Maticsoft.Web.PermisssionsNodes
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
		Maticsoft.BLL.PermisssionsNodes bll=new Maticsoft.BLL.PermisssionsNodes();
		Maticsoft.Model.PermisssionsNodes model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.ddlFk_Permissions_Id.SelectedValue=model.Fk_Permissions_Id.ToString();
		this.ddlFk_Nodes_Id.SelectedValue=model.Fk_Nodes_Id.ToString();

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
			int Fk_Permissions_Id=int.Parse(this.ddlFk_Permissions_Id.SelectedValue);
			int Fk_Nodes_Id=int.Parse(this.ddlFk_Nodes_Id.SelectedValue);


			Maticsoft.Model.PermisssionsNodes model=new Maticsoft.Model.PermisssionsNodes();
			model.Id=Id;
			model.Fk_Permissions_Id=Fk_Permissions_Id;
			model.Fk_Nodes_Id=Fk_Nodes_Id;

			Maticsoft.BLL.PermisssionsNodes bll=new Maticsoft.BLL.PermisssionsNodes();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
