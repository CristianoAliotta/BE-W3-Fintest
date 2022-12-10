using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BE_W3_Fintest
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Articolo.GetList().Clear();
                Articolo.GetList();
                RepeaterVape.DataSource= Articolo.Catalog;
                RepeaterVape.DataBind();

            }

        }
    }
}