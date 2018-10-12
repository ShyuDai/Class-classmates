using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Linq;

namespace Maticsoft.Web
{
    public partial class Left : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["UsersId"] != null)
                {
                    BLL.Users users = new BLL.Users();
                    Model.Users user = users.GetModel((int)Session["UsersId"]);
                    BLL.Roles roles =new BLL.Roles();
                    Model.Roles role = roles.GetModel(user.Fk_Roles_Id.Value);
                    BLL.PermisssionsNodes permisssionsNodes = new BLL.PermisssionsNodes();

                    List<Model.PermisssionsNodes> permisssionsNodesList = permisssionsNodes.GetModelList("Fk_Permissions_Id='" + role.Fk_Permissions_Id + "'");
                    List<Model.Nodes> nodes = new List<Model.Nodes>();
                    foreach (Model.PermisssionsNodes pn in permisssionsNodesList)
                    {
                        BLL.Nodes nodesBLL = new BLL.Nodes();
                        Model.Nodes node = nodesBLL.GetModel(pn.Fk_Nodes_Id.Value);
                        if (node != null)
                        {
                            if (node.ParentId == 0 && node.IsVisible == true)
                            {
                                nodes.Add(node);
                            }
                        }
                    }
                    Repeater1.DataSource = nodes.OrderBy(p=>p.Orders).ToList();
                    Repeater1.DataBind();
                }
            }
        }

        protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.AlternatingItem || e.Item.ItemType == ListItemType.Item)
            {
                Repeater Repeater2 = e.Item.FindControl("Repeater2") as Repeater;
                Label lblId = e.Item.FindControl("lblId") as Label;
                //BLL.Nodes nodes = new BLL.Nodes();
                //List<Model.Nodes> list = nodes.GetModelList("ParentId='" + lblId.Text + "' and IsVisible='True'").OrderBy(p => p.Orders).ToList();

                BLL.Users users = new BLL.Users();
                Model.Users user = users.GetModel((int)Session["UsersId"]);
                BLL.Roles roles = new BLL.Roles();
                Model.Roles role = roles.GetModel(user.Fk_Roles_Id.Value);
                BLL.PermisssionsNodes permisssionsNodes = new BLL.PermisssionsNodes();

                List<Model.PermisssionsNodes> permisssionsNodesList = permisssionsNodes.GetModelList("Fk_Permissions_Id='" + role.Fk_Permissions_Id + "'");
                List<Model.Nodes> nodes = new List<Model.Nodes>();
                foreach (Model.PermisssionsNodes pn in permisssionsNodesList)
                {
                    BLL.Nodes nodesBLL = new BLL.Nodes();
                    Model.Nodes node = nodesBLL.GetModel(pn.Fk_Nodes_Id.Value);
                    if (node != null)
                    {
                        if (node.ParentId == int.Parse(lblId.Text) && node.IsVisible == true)
                        {
                            nodes.Add(node);
                        }
                    }
                }

                Repeater2.DataSource = nodes.OrderBy(p => p.Orders).ToList();
                Repeater2.DataBind();
            }
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }
    }
}