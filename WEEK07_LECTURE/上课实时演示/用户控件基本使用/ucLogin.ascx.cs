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

namespace 用户控件基本使用
{
    public partial class ucLogin : System.Web.UI.UserControl
    {
        public string BackgroundColor
        {
            get { return table1.BgColor; }
            set { table1.BgColor = value; }
        }

        public string Width
        {
            get { return table1.Width; }
            set { table1.Width = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "12345")
            {
                lblTitle.Text = "登录成功";
            }
            else
            {
                lblTitle.Text = "登录不成功";
            }
        }
    }
}