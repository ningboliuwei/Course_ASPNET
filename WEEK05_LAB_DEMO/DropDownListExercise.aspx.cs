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

public partial class WEEK05_LAB_DEMO_DropDownListExercise : System.Web.UI.Page
{
	protected void Page_Load(object sender, System.EventArgs e)
	{
		// 在此处放置用户代码以初始化页面
		DisplayInfoAndSetButtonEnabled();
	}

	#region Web 窗体设计器生成的代码
	override protected void OnInit(EventArgs e)
	{
		//
		// CODEGEN: 该调用是 ASP.NET Web 窗体设计器所必需的。
		//
		InitializeComponent();
		base.OnInit(e);
	}

	/// <summary>
	/// 设计器支持所需的方法 - 不要使用代码编辑器修改
	/// 此方法的内容。
	/// </summary>
	private void InitializeComponent()
	{

	}
	#endregion

	protected void btnAdd_Click(object sender, System.EventArgs e)
	{
		//如果Text文本框输入的数据为空
		if (txtItemText.Text.Trim() == "")
		{
			//显示错误提示
			lblInfo.Text ="Text值不能为空";
		}
		//如果Value文本框输入的数据为空
		else if (txtItemValue.Text.Trim() == "")
		{
			lblInfo.Text = "Value值不能为空";
		}
		else
		{
			//创建一个新的选项
			ListItem li = new ListItem();

			li.Text = txtItemText.Text.Trim();
			li.Value = txtItemValue.Text.Trim();

			//将选项添加到下拉列表中
			dplItems.Items.Add(li);

			//选中最后一个选项（即新添加进的选项）
			dplItems.SelectedIndex = dplItems.Items.Count - 1;

			//显示信息并设置按钮可用状态
			DisplayInfoAndSetButtonEnabled();

			//清空Text与Value文本框
			txtItemText.Text = "";
			txtItemValue.Text = "";
		}
	}

	protected void dplItems_SelectedIndexChanged(object sender, System.EventArgs e)
	{
		DisplayInfoAndSetButtonEnabled();

	}

	protected void btnDelete_Click(object sender, System.EventArgs e)
	{
		//删除选中项
		dplItems.Items.RemoveAt(dplItems.SelectedIndex);
		
		DisplayInfoAndSetButtonEnabled();

	}

	protected void btnClear_Click(object sender, System.EventArgs e)
	{
		//清除所有选项
		dplItems.Items.Clear();
		
		DisplayInfoAndSetButtonEnabled();
	}

	private void DisplayInfoAndSetButtonEnabled()
	{
		//如果当前没有项目，进行错误提示
		if (dplItems.Items.Count == 0)
		{
			lblInfo.Text = "目前下拉菜单中没有任何选项";
		}
		else
		{
			//显示相应信息
			lblInfo.Text = "目前下拉菜单中共有 " + dplItems.Items.Count + " 个选项<br>"
				+ "当前选中的选项是第 " + (dplItems.SelectedIndex + 1) + " 项<br>"
				+ "当前选中的项目的Text属性值为 " + dplItems.SelectedItem.Text
				+ "， Value属性值为 " + dplItems.SelectedItem.Value;
		}

		//若当前没有项目，设置 "删除" 与 "清除" 按钮不可用
		if (dplItems.Items.Count == 0)
		{
			btnDelete.Enabled = false;
			btnClear.Enabled = false;
		}
		//否则设为可用
		else
		{
			btnDelete.Enabled = true;
			btnClear.Enabled = true;
		}

	}
}
