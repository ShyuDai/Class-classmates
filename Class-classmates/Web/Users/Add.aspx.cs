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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
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
			String Name=this.txtName.Text;
			String Password=this.txtPassword.Text;
			String TrueName=this.txtTrueName.Text;
			String Sex=this.ddlSex.SelectedValue;
			String Phone=this.txtPhone.Text;
            //上传图片
            string path = Server.MapPath("~/");
            string Photo = "";
            string filename = "";
            string contentType = fuPhoto.PostedFile.ContentType;
            if (contentType == "image/pjpeg" || contentType== "image/bmp" || contentType == "image/gif")
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
            try
            {
                bll.Add(model);
                Maticsoft.Common.MessageBox.ShowAndRedirect(this, "注册成功！", "List.aspx");
            }
            catch
            {
                Maticsoft.Common.MessageBox.ShowAndRedirect(this, "已存在该用户！", "Add.aspx");
            }

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
