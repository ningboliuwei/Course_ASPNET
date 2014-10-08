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
    public partial class DropDownListDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDisplay_Click(object sender, EventArgs e)
        {
            string info = "";
            //info = DropDownList1.SelectedValue;
            //info = DropDownList1.SelectedItem.Value;
            //info = DropDownList1.SelectedItem.Text;
            info = DropDownList1.SelectedIndex.ToString();
            //info = DropDownList1.Items[DropDownList1.SelectedIndex].Text;

            lblInfo.Text = info;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //DropDownList1.SelectedIndex = 0;
            //DropDownList1.SelectedIndex = DropDownList1.Items.Count - 1;
            //DropDownList1.SelectedValue = "95002";
            //DropDownList1.Text = "ASP.NET程序设计"; 不行
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //DropDownList2.Items.Add(TextBox1.Text);
            ListItem item = new ListItem();
            item.Text = TextBox1.Text;
            item.Value = TextBox2.Text;

          
            DropDownList2.Items.Add(item);

            int i = 0;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int index = DropDownList1.SelectedIndex;
            //DropDownList1.Items.RemoveAt(DropDownList1.SelectedIndex);
            //DropDownList1.SelectedIndex = index;
            DropDownList1.Items.Remove(DropDownList1.SelectedItem);

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            DropDownList1.Items.Clear();
        }
    }
}
