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
namespace Maticsoft.Web.News
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
		Maticsoft.BLL.News bll=new Maticsoft.BLL.News();
		Maticsoft.Model.News model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.lblName.Text=model.Name;
		BLL.NewsType BLLNewsType = new BLL.NewsType();
		Model.NewsType ModelNewsType = BLLNewsType.GetModel((int)model.Fk_NewsType_Id);
		this.lblFk_NewsType_Id.Text = ModelNewsType.Name;
		this.lblContents.Text=model.Contents;
		BLL.Users BLLUsers = new BLL.Users();
		Model.Users ModelUsers = BLLUsers.GetModel((int)model.Fk_Users_Id);
		this.lblFk_Users_Id.Text = ModelUsers.Name;
		this.lblAddTime.Text=model.AddTime.ToString();

	}


    }
}
