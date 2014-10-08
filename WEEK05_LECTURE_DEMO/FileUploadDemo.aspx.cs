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

public partial class WEEK05_LECTURE_DEMO_FileUploadDemo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
	protected void Button1_Click(object sender, EventArgs e)
	{
		//将上传的文件保存到R盘根目录
		try
		{
			string newMainName = Guid.NewGuid().ToString();
			string extFileName = fileUpload1.FileName.Substring(fileUpload1.FileName.LastIndexOf(".") + 1);
			
			fileUpload1.SaveAs(Server.MapPath("\\upload\\") + newMainName + extFileName);

			//得到上传文件的主文件名
			//string mainFileName = fileUpload1.FileName.Substring(0, fileUpload1.FileName.LastIndexOf("."));

			//得到上传文件的扩展名
			//string extFileName = fileUpload1.FileName.Substring(fileUpload1.FileName.LastIndexOf(".") + 1);

			string uploadPath = Server.MapPath("upload\\");
			Response.Write(uploadPath);
		}
		catch (Exception exception)
		{

			throw new Exception(exception.Message);
		}
			
	}
}
