using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsPrimjer
{
    public partial class Pozdravna_poruka : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Lblrezulatat.Text = Txtime.Text;
        }

        protected void Txtime_TextChanged(object sender, EventArgs e)
        {

        }
    }
}