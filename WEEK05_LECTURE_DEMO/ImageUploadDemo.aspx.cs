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
		string fileName = FileUpload1.FileName;
		string path = Server.MapPath("images\\");
	
		try
		{
			FileUpload1.PostedFile.SaveAs(path + fileName);
			Image1.ImageUrl = "images/" + fileName;
		}
		catch (Exception exception)
		{
			Response.Write(exception.Message);
			//throw new Exception(exception.Message);
		}
	}
}
