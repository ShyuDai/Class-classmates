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
namespace Maticsoft.Web.Users
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
		Maticsoft.BLL.Users bll=new Maticsoft.BLL.Users();
		Maticsoft.Model.Users model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.lblName.Text=model.Name;
		this.txtPassword.Text=model.Password;
		this.txtTrueName.Text=model.TrueName;
		this.ddlSex.SelectedValue=model.Sex;
		this.txtPhone.Text=model.Phone;
		//this.txtPhoto.Text=model.Photo;
		this.txtEmail.Text=model.Email;
		this.txtBirthday.Text=model.Birthday.ToString();
		this.chkIsActivity.Checked=model.IsActivity;
		this.ddlFk_Roles_Id.SelectedValue=model.Fk_Roles_Id.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsDateTime(txtBirthday.Text))
			{
				strErr+="生日格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int Id=int.Parse(this.lblId.Text);
			string Name=this.lblName.Text;
			String Password=this.txtPassword.Text;
			String TrueName=this.txtTrueName.Text;
			String Sex=this.ddlSex.SelectedValue;
			String Phone=this.txtPhone.Text;
            //上传图片
            string path = Server.MapPath("~/");
            string Photo = "";
            string filename = "";
            string contentType = fuPhoto.PostedFile.ContentType;
            if (contentType == "image/pjpeg" || contentType == "image/bmp" || contentType == "image/gif")
            {
                string format = fuPhoto.FileName.Split('.')[1];
                Photo = "Upload/" + Guid.NewGuid() + "." + format;
                filename = path + Photo;
                fuPhoto.PostedFile.SaveAs(filename);

            }
            else
            {
                Maticsoft.Common.MessageBox.Show(this, "请上传图片文件！");
                return;
            }
            //结束上传图片
			String Email=this.txtEmail.Text;
			DateTime Birthday=DateTime.Parse(this.txtBirthday.Text);
			bool IsActivity=this.chkIsActivity.Checked;
			int Fk_Roles_Id=int.Parse(this.ddlFk_Roles_Id.SelectedValue);


			Maticsoft.Model.Users model=new Maticsoft.Model.Users();
			model.Id=Id;
			model.Name=Name;
			model.Password=Password;
			model.TrueName=TrueName;
			model.Sex=Sex;
			model.Phone=Phone;
			model.Photo=Photo;
			model.Email=Email;
			model.Birthday=Birthday;
			model.IsActivity=IsActivity;
			model.Fk_Roles_Id=Fk_Roles_Id;

			Maticsoft.BLL.Users bll=new Maticsoft.BLL.Users();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
