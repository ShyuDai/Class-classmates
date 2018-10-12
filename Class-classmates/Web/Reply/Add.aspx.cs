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
namespace Maticsoft.Web.Reply
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsDateTime(txtAddTimes.Text))
			{
				strErr+="回复时间格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int Fk_Leaveword_Id=int.Parse(this.ddlFk_Leaveword_Id.SelectedValue);
			String Contents=this.txtContents.Text;
			int Fk_Users_Id=int.Parse(this.ddlFk_Users_Id.SelectedValue);
			DateTime AddTimes=DateTime.Parse(this.txtAddTimes.Text);

			Maticsoft.Model.Reply model=new Maticsoft.Model.Reply();
			model.Fk_Leaveword_Id=Fk_Leaveword_Id;
			model.Contents=Contents;
			model.Fk_Users_Id=Fk_Users_Id;
			model.AddTimes=AddTimes;

			Maticsoft.BLL.Reply bll=new Maticsoft.BLL.Reply();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","Add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
