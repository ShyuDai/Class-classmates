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
namespace Maticsoft.Web.News
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsDateTime(txtAddTime.Text))
			{
				strErr+="发布时间格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			String Name=this.txtName.Text;
			int Fk_NewsType_Id=int.Parse(this.ddlFk_NewsType_Id.SelectedValue);
			String Contents=this.txtContents.Text;
			int Fk_Users_Id=int.Parse(this.ddlFk_Users_Id.SelectedValue);
			DateTime AddTime=DateTime.Parse(this.txtAddTime.Text);

			Maticsoft.Model.News model=new Maticsoft.Model.News();
			model.Name=Name;
			model.Fk_NewsType_Id=Fk_NewsType_Id;
			model.Contents=Contents;
			model.Fk_Users_Id=Fk_Users_Id;
			model.AddTime=AddTime;

			Maticsoft.BLL.News bll=new Maticsoft.BLL.News();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","Add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
