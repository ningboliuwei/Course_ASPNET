using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 菜单控件
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void mnuMain_MenuItemClick(object sender, MenuEventArgs e)
        {
            //mnuMain.Items.Add();
            var item = new MenuItem();
        }
    }
}