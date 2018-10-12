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
namespace Maticsoft.Web.Users
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
		Maticsoft.BLL.Users bll=new Maticsoft.BLL.Users();
		Maticsoft.Model.Users model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.lblName.Text=model.Name;
		this.lblPassword.Text=model.Password;
		this.lblTrueName.Text=model.TrueName;
		this.lblSex.Text=model.Sex;
		this.lblPhone.Text=model.Phone;
        //图片
		this.iPhoto.ImageUrl="~/"+model.Photo;
		this.lblEmail.Text=model.Email;
		this.lblBirthday.Text=model.Birthday.ToString();
		this.lblIsActivity.Text=model.IsActivity?"是":"否";
		BLL.Roles BLLRoles = new BLL.Roles();
		Model.Roles ModelRoles = BLLRoles.GetModel((int)model.Fk_Roles_Id);
		this.lblFk_Roles_Id.Text = ModelRoles.Name;

	}


    }
}
