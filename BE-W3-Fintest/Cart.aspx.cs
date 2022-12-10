using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BE_W3_Fintest
{
    public partial class Cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if(Articolo.Cart.Count !=0)
                {
                    GridContainer.Visible= true;
                    Empty.Visible = false;
                    double tot = 0;
                    foreach(Articolo item in Articolo.Cart) 
                    {
                        tot += item.Price;
                    }
                    ArtsSum.Text = tot.ToString() + "$";
                } else
                {
                    GridContainer.Visible = false;
                    Empty.Visible = true;
                    Empty.Text = "Opss! Your cart seems to be empty";
                }
                CartGrid.DataSource= Articolo.Cart;
                CartGrid.DataBind();
            }

        }
        protected void DeleteCart(object sender, EventArgs e)
        {
            Articolo.Cart.Clear();
            GridContainer.Visible = false;
            Empty.Visible = true;
            Empty.Text = "Opss! Your cart seems to be empty";
        }
    }
}