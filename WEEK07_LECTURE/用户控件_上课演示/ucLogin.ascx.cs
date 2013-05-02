using System;
using System.Web.UI;

namespace 用户控件_上课演示
{
    public partial class ucLogin : UserControl
    {
        public string BackgroundColor
        {
            get { return tableLogin.BgColor; }
            set { tableLogin.BgColor = value; }
        }

        public int Width
        {
            get { return Convert.ToInt32(tableLogin.Width); }
            set { tableLogin.Width = value.ToString() + "px"; }
        }

        public string Title
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }

        public bool Validate()
        {
            bool result = false;

            if (txtUserName.Text == "admin" && txtPassword.Text == "123456")
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }


        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            bool b = Validate();

            if (b)
            {
                Title = "OK";
            }
            else
            {
                Title = "ERROR";
            }
        }
    }
}