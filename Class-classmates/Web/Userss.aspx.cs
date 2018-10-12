using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web
{
    public partial class Userss : System.Web.UI.Page
    {
        public string strid = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
                {
                    strid = Request.Params["id"];
                    int Id = (Convert.ToInt32(strid));
                    ShowInfo(Id);
                }
            }
        }

        private void ShowInfo(int Id)
        {
            Maticsoft.BLL.Users bll = new Maticsoft.BLL.Users();
            Maticsoft.Model.Users model = bll.GetModel(Id);
            this.lblId.Text = model.Id.ToString();
            this.lblName.Text = model.Name;
            
            this.lblTrueName.Text = model.TrueName;
            this.lblSex.Text = model.Sex;
            this.lblPhone.Text = model.Phone;
            this.iPhoto.ImageUrl = "~/" + model.Photo;
            this.lblEmail.Text = model.Email;
            this.lblBirthday.Text = model.Birthday.ToString();

            BLL.Roles BLLRoles = new BLL.Roles();
            Model.Roles ModelRoles = BLLRoles.GetModel((int)model.Fk_Roles_Id);
            this.lblFk_Roles_Id.Text = ModelRoles.Name;

        }
    }
}