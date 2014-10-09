using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class WEEK05_LECTURE_DEMO_FileUploadDemo : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{

	}
	protected void Button1_Click(object sender, EventArgs e)
	{
		//涉及到文件操作时，建议使用异常处理
		try
		{
			//将上传的文件保存到R盘根目录
			//fileUpload1.SaveAs("R:\\" + fileUpload1.FileName);

			//得到上传文件的主文件名
			//string mainFileName = fileUpload1.FileName.Substring(0, fileUpload1.FileName.LastIndexOf("."));

			//得到上传文件的扩展名
			//string extFileName = fileUpload1.FileName.Substring(fileUpload1.FileName.LastIndexOf(".") + 1);

			//上传时将主文件名改为GUID（避免重名文件），后缀名不变
			//string newMainName = Guid.NewGuid().ToString();
			//string extFileName = fileUpload1.FileName.Substring(fileUpload1.FileName.LastIndexOf(".") + 1);

			//fileUpload1.SaveAs(Server.MapPath("\\upload\\") + newMainName + extFileName);

			//将上传的文件保存到页面所在文件夹下的upload文件夹
			//fileUpload1.SaveAs(Server.MapPath("upload\\") + fileUpload1.FileName);
		}
		catch (Exception exception)
		{
			//抛出异常
			throw new Exception(exception.Message);
		}

	}
}
