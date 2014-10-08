using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Net.Mime;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class LabelDemo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //List<string> items = new List<string>(){"ASP.NET","C++","Java","Python"};

        //DropDownList1.DataSource = items;
        //DropDownList1.DataBind();

        //ListItem item = new ListItem();
        //item.Text = "李勇";
        //item.Value = "95001";

        //DropDownList1.Items.Add(item);

        //DropDownList1.Items.RemoveAt(2);

        //DropDownList1.Items.Remove(DropDownList1.Items[DropDownList1.Items.Count-1]);

        //ListBox1.Text

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        string level = "";
        //Label1.Text = "ABC";
        string s = Label1.Text;

        if (level != "管理员")
        {
            btnDelete.Enabled = false;
        }
    }

    protected void Unnamed2_DataBinding(object sender, EventArgs e)
    {
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "单击！";
    }
    protected void Radiobutton1_CheckedChanged(object sender, EventArgs e)
    {

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
      
            Label1.Text = "当前Text值为" + DropDownList1.Text + "，" + "当前Value值为" + DropDownList1.SelectedValue;
       

    }
}