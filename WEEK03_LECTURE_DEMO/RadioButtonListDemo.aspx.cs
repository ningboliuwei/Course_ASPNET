using System;
using System.Collections;
using System.Collections.Generic;
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
    public partial class RadioButtonListDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!Page.IsPostBack)
            //{
            //    List<string> items = new List<string>();

            //    items.Add("足球");
            //    items.Add("篮球");
            //    items.Add("网球");
            //    items.Add("乒乓球");
            //    items.Add("羽毛球");
            //    items.Add("水球");

            //    RadioButtonList1.DataSource = items;
            //    RadioButtonList1.DataBind();
            //}

            //if (!Page.IsPostBack)
            //{
            //    List<string> items = new List<string>("足球");

            //    items.Add("足球");
            //    items.Add("篮球");
            //    items.Add("网球");
            //    items.Add("乒乓球");
            //    items.Add("羽毛球");
            //    items.Add("水球");

            //    RadioButtonList1.DataSource = items;
            //    RadioButtonList1.DataBind();
            //}
        }
    }
}
