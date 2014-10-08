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

public partial class Common : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        for (int i = 0; i < 10; i++)
        {
            CheckBoxList1.Items.Add((i+1).ToString());
        }

      



    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label2.Text = "";

        //if (CheckBox1.Checked == true)
        //{
        //    Label2.Text = "你喜欢足球";
        //}

        //if (CheckBox2.Checked == true)
        //{
        //    Label2.Text += "你喜欢篮球";
        //}

        //if (CheckBox3.Checked == true)
        //{
        //    Label2.Text += "你喜欢游泳";
        //}

        for (int i = 0; i < 10; i++)
        {
            if (CheckBoxList1.Items[i].Selected == true)
            {
                Label2.Text += "第" + (i + 1).ToString() + "被选中";
            }
        }
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {

    }
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox1.Checked == false)
        {
            Label2.Text = "没选足球";
        }
        else
        {
            Label2.Text = "选了足球";
        }
    }
}
