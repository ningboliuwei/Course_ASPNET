using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.MobileControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class WEEK05_LECTURE_DEMO_DropDownListDemo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DropDownList1.Items.Add("ASP.NET程序设计");
        DropDownList1.Items.Add("数据库原理");
        DropDownList1.Items.Add("C语言程序设计");
    }

    protected void btnDisplay_Click(object sender, EventArgs e)
    {
        //显示选中项的Text属性
        //lblInfo.Text = DropDownList1.SelectedItem.Text;
        //显示选中项的Value属性
        //lblInfo.Text = DropDownList1.SelectedItem.Value;
        
        //以上两个操作也可以这么做
        ListItem listItem = DropDownList1.SelectedItem;
        lblInfo.Text = listItem.Text + "," + listItem.Value; ;

        //DropDownList1.Text 与 DropDownList1.SelectedItem.Text 等效
        //lblInfo.Text = DropDownList1.Text;

        //DropDownList1.SelectedValue 与 DropDownList1.SelectedItem.Value 等效
        //lblInfo.Text = DropDownList1.SelectedValue;
        
        //显示选中项的下标（注意类型转换）
        lblInfo.Text = DropDownList1.SelectedIndex.ToString();
        
        //获取下标后，可通过Items属性结合下标获取选中项
        //info = DropDownList1.Items[DropDownList1.SelectedIndex].Text;

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
