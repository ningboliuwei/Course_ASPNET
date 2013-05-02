using System;
using System.Web.UI;

namespace 用户控件_用户登录
{
    public partial class ucLogin : UserControl
    {
        public ucLogin()
        {
            Width = 300;
            Title = "用户登录";
            BackgroundColor = "lightblue";
        }

        public string BackgroundColor { get; set; }
        public int Width { get; set; }
        public string Title { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                tableLogin.Width = Width + "px";
                tableLogin.BgColor = BackgroundColor;
                lblTitle.Text = Title;
            }
        }

        public bool ValidateUser()
        {
            bool isValid = false;

            if (txtUserName.Text == "admin" && txtPassword.Text == "123456")
            {
                isValid = true;
            }
            else
            {
                isValid = false;
            }

            return isValid;
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            bool isValid = false;

            isValid = ValidateUser();

            if (isValid)
            {
                lblInfo.Text = "您已登录成功";
            }
            else
            {
                lblInfo.Text = "您的用户名或者密码不正确";
            }
        }
    }
}