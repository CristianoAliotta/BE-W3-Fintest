using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BE_W3_Fintest
{
    public partial class Detail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Id = Request.QueryString["id"];
            foreach (Articolo item in Articolo.Catalog)
            {
                if(item.Id == Convert.ToInt32(Id))
                {
                    ImgProd.Src = item.Img;
                    ArtName.InnerHtml = item.Name;
                    ArtPrice.InnerHtml = Convert.ToString(item.Price + "$");
                    ArtDesc.InnerHtml = item.Description;
                }
            };
            

        }
        protected void AddToCart(object sender, EventArgs e)
        {
            string Id = Request.QueryString["id"];
            foreach (Articolo item in Articolo.Catalog)
            {
                if(item.Id == Convert.ToInt32(Id))
                {
                    Articolo.Cart.Add(item);
                }
            }
        }
    }
}