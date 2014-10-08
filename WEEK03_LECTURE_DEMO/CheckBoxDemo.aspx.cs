using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace WEEK03_LECTURE_DEMO
{
    public partial class CheckBoxDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
          

           

        }

        protected void chxFootball_CheckedChanged(object sender, EventArgs e)
        {
            DisplayInfo();
        }

        protected void chxBasketball_CheckedChanged(object sender, EventArgs e)
        {
            DisplayInfo();
        }

        private void DisplayInfo()
        {
            lblInfo.Text = "";

            if (chxFootball.Checked == true)
            {
                lblInfo.Text += "足球";
            }

            if (chxBasketball.Checked == true)
            {
                lblInfo.Text += "篮球";
            }


        }
    }
}
