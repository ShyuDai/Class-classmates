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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtFK_Users_Id.Text))
			{
				strErr+="留言用户格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtAddTimes.Text))
			{
				strErr+="留言时间格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int Fk_News_Id=int.Parse(this.ddlFk_News_Id.SelectedValue);
			String Contents=this.txtContents.Text;
			int FK_Users_Id=int.Parse(this.txtFK_Users_Id.Text);
			DateTime AddTimes=DateTime.Parse(this.txtAddTimes.Text);

			Maticsoft.Model.Leaveword model=new Maticsoft.Model.Leaveword();
			model.Fk_News_Id=Fk_News_Id;
			model.Contents=Contents;
			model.FK_Users_Id=FK_Users_Id;
			model.AddTimes=AddTimes;

			Maticsoft.BLL.Leaveword bll=new Maticsoft.BLL.Leaveword();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","Add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
