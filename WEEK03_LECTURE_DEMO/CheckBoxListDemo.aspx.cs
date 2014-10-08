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
    public partial class CheckBoxListDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                List<string> items = new List<string>();

                items.Add("足球");
                items.Add("篮球");
                items.Add("网球");
                items.Add("乒乓球");
                items.Add("羽毛球");
                items.Add("水球");

                CheckBoxList2.DataSource = items;
                CheckBoxList2.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
        }

        protected void CheckBoxList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label1.Text = "";
            //for (int i =0; i < CheckBoxList2.Items.Count;i++)
            //{
            //    if(CheckBoxList2.Items[i].Selected == true)
            //    {
            //        Label1.Text += CheckBoxList2.Items[i].Text;
            //    }
            //}

            foreach (ListItem item in CheckBoxList2.Items)
            {
                if (item.Selected == true)
                {
                    Label1.Text += item.Text;
                }
            }
        }
    }
}