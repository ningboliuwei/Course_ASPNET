using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DataListExample : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		if (!Page.IsPostBack)
		{
			BindDataList();
		}
	}

	protected void BindDataList()
	{
		string commandText =
			@"SELECT StudentID, Student.Name, Department.Name AS DepartmentName, Photo, Gender, Address, DayOfBirth 
					FROM Student INNER JOIN Department ON Student.DepartmentID = Department.DepartmentID";
		DataSet dataSet = SqlHelper.GetDataSetBySqlCommand(commandText, SqlHelper.GetConnection());
		DataList1.DataSource = dataSet;
		DataList1.DataBind();
	}
	protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
	{
		
	}
	protected void DataList1_DeleteCommand(object source, DataListCommandEventArgs e)
	{
		//当将某个按钮的 CommandName 属性设置为 Delete，且点击了这个按钮时，就会触发 DataList 的 DeleteCommand 事件
		string commandText = string.Format("DELETE FROM Student WHERE StudentID='{0}'", e.CommandArgument);
		SqlHelper.ExecuteNonQuerySqlCommand(commandText, SqlHelper.GetConnection());
		BindDataList();
	}
	protected void DataList1_EditCommand(object source, DataListCommandEventArgs e)
	{
		//当将某个按钮的 CommandName 属性设置为 Edit，且点击了这个按钮时，就会触发 DataList 的 EditCommand 事件
		
		//将点击的那项设为编辑模式（样式由 DataList 的 EditItemTemplate 控制）
		DataList1.EditItemIndex = e.Item.ItemIndex;
		BindDataList();

		//注意，这里并没有实际实现修改数据的功能。实现代码可以参考 GridView 中的例子
	}
}