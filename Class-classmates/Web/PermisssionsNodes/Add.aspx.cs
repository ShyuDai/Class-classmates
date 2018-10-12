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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int Fk_Permissions_Id=int.Parse(this.ddlFk_Permissions_Id.SelectedValue);
			int Fk_Nodes_Id=int.Parse(this.ddlFk_Nodes_Id.SelectedValue);

			Maticsoft.Model.PermisssionsNodes model=new Maticsoft.Model.PermisssionsNodes();
			model.Fk_Permissions_Id=Fk_Permissions_Id;
			model.Fk_Nodes_Id=Fk_Nodes_Id;

			Maticsoft.BLL.PermisssionsNodes bll=new Maticsoft.BLL.PermisssionsNodes();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","Add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
