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

public partial class WEEK05_LECTURE_DEMO_ImageUploadDemo : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{

	}
	protected void Button1_Click(object sender, EventArgs e)
	{
		//获取上传文件的文件名
		string fileName = FileUpload1.FileName;
		
		//获取上传文件要在服务器上保存的文件夹的路径
		string path = Server.MapPath("images\\");
	
		try
		{
			//将上传的文件保存到服务器指定路径
			FileUpload1.PostedFile.SaveAs(path + fileName);
			
			//将Image控件显示刚上传的图片
			Image1.ImageUrl = "images/" + fileName;
		}
		catch (Exception exception)
		{
			throw new Exception(exception.Message);
		}
	}
}
