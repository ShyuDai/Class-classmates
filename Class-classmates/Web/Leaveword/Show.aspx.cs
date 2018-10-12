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
namespace Maticsoft.Web.Leaveword
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
		Maticsoft.BLL.Leaveword bll=new Maticsoft.BLL.Leaveword();
		Maticsoft.Model.Leaveword model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		BLL.News BLLNews = new BLL.News();
		Model.News ModelNews = BLLNews.GetModel((int)model.Fk_News_Id);
		this.lblFk_News_Id.Text = ModelNews.Name;
		this.lblContents.Text=model.Contents;
		
		this.lblAddTimes.Text=model.AddTimes.ToString();

	}


    }
}
