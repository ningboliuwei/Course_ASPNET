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
using System.Web.UI.MobileControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class WEEK05_LECTURE_DEMO_DropDownListDemo : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		//判断页面是否是第一次加载，只有第一次加载时才添加项目
		//if (!Page.IsPostBack)
		//{
		//    DropDownList1.Items.Add("ASP.NET程序设计");
		//    DropDownList1.Items.Add("数据库原理");
		//    DropDownList1.Items.Add("C语言程序设计");
		//}


		//通过绑定数组来显示项目
		//string[] courses = { "ASP.NET程序设计", "数据库原理", "C语言程序设计" };

		//DropDownList1.DataSource = courses;
		//DropDownList1.DataBind();


		//通过绑定ArrayList来显示项目
		//ArrayList courses = new ArrayList(){};
		
		//courses.Add("ASP.NET程序设计");
		//courses.Add("数据库原理");
		//courses.Add("C语言程序设计");

		//DropDownList1.DataSource = courses;
		//DropDownList1.DataBind();

		//通过绑定List<T>来显示项目，每个项目由一个Course类型的对象来表示
		//List<Course> courses = new List<Course>();

		//courses.Add(new Course("ASP.NET程序设计", "95001"));
		//courses.Add(new Course("数据库原理", "95002"));
		//courses.Add(new Course("C语言程序设计", "95003"));


		//DropDownList1.DataTextField = "Name";
		//DropDownList1.DataValueField = "No";
		//DropDownList1.DataSource = courses;
		//DropDownList1.DataBind();
	}

	//以下演示绑定List<T>时使用到
	//class Course
	//{
	//    public string Name { get; set; }
	//    public string No { get; set; }

	//    public Course(string name, string no)
	//    {
	//        Name = name;
	//        No = no;
	//    }
	//}

	protected void btnDisplay_Click(object sender, EventArgs e)
	{
		//显示选中项的Text属性
		//lblInfo.Text = DropDownList1.SelectedItem.Text;
		//显示选中项的Value属性
		//lblInfo.Text = DropDownList1.SelectedItem.Value;

		//以上两个操作也可以这么做
		//ListItem listItem = DropDownList1.SelectedItem;
		//lblInfo.Text = listItem.Text + "," + listItem.Value; ;

		//DropDownList1.Text 与 DropDownList1.SelectedItem.Text 等效
		//lblInfo.Text = DropDownList1.Text;

		//DropDownList1.SelectedValue 与 DropDownList1.SelectedItem.Value 等效
		//lblInfo.Text = DropDownList1.SelectedValue;

		//显示选中项的下标（注意类型转换）
		//lblInfo.Text = DropDownList1.SelectedIndex.ToString();

		//获取下标后，可通过Items属性结合下标获取选中项
		//info = DropDownList1.Items[DropDownList1.SelectedIndex].Text;

	}

	protected void Button1_Click(object sender, EventArgs e)
	{
		//选中第一项
		//DropDownList1.SelectedIndex = 0;

		//选中最后一项
		//DropDownList1.SelectedIndex = DropDownList1.Items.Count - 1;

		//选中Value属性为95002的选项
		//DropDownList1.SelectedValue = "95002";

		//以下代码不起作用
		//DropDownList1.Text = "C语言程序设计";
	}

	protected void Button2_Click(object sender, EventArgs e)
	{
		//将用户输入的文本作为选项添加
		//DropDownList2.Items.Add(TextBox1.Text);
		
		//需要添加同时有Text与Value属性的选项（默认Value值与Text值保持一致）
		//ListItem item = new ListItem();
		//item.Text = TextBox1.Text;
		//item.Value = TextBox2.Text;

		//DropDownList2.Items.Add(item);

	}

	protected void Button3_Click(object sender, EventArgs e)
	{
		//删除当前选中项
		//DropDownList2.Items.RemoveAt(DropDownList2.SelectedIndex);

		//删除当前选中项的另一种方法
		//DropDownList2.Items.Remove(DropDownList2.SelectedItem);

	}

	protected void Button4_Click(object sender, EventArgs e)
	{
		//清空所有选项
		//DropDownList2.Items.Clear();
	}
}
