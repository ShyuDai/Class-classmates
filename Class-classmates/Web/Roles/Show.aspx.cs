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
namespace Maticsoft.Web.Roles
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					int Id=(Convert.ToInt32(strid));
					ShowInfo(Id);
				}
			}
		}
		
	private void ShowInfo(int Id)
	{
		Maticsoft.BLL.Roles bll=new Maticsoft.BLL.Roles();
		Maticsoft.Model.Roles model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.lblName.Text=model.Name;
		BLL.Permissions BLLPermissions = new BLL.Permissions();
		Model.Permissions ModelPermissions = BLLPermissions.GetModel((int)model.Fk_Permissions_Id);
		this.lblFk_Permissions_Id.Text = ModelPermissions.Name;

	}


    }
}
