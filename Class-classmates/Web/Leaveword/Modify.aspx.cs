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
namespace Maticsoft.Web.Leaveword
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
		Maticsoft.BLL.Leaveword bll=new Maticsoft.BLL.Leaveword();
		Maticsoft.Model.Leaveword model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.ddlFk_News_Id.SelectedValue=model.Fk_News_Id.ToString();
		this.txtContents.Text=model.Contents;
		
		this.txtAddTimes.Text=model.AddTimes.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			
			if(!PageValidate.IsDateTime(txtAddTimes.Text))
			{
				strErr+="留言时间格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int Id=int.Parse(this.lblId.Text);
			int Fk_News_Id=int.Parse(this.ddlFk_News_Id.SelectedValue);
			String Contents=this.txtContents.Text;
            int FK_Users_Id =int.Parse( Session["UsersId"].ToString());
			DateTime AddTimes=DateTime.Parse(this.txtAddTimes.Text);


			Maticsoft.Model.Leaveword model=new Maticsoft.Model.Leaveword();
			model.Id=Id;
			model.Fk_News_Id=Fk_News_Id;
			model.Contents=Contents;
			model.FK_Users_Id=FK_Users_Id;
			model.AddTimes=AddTimes;

			Maticsoft.BLL.Leaveword bll=new Maticsoft.BLL.Leaveword();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
