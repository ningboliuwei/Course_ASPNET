using System;
using System.Collections;
using System.Configuration;
using System.Data;
//引入System.IO命名空间，使程序能够对磁盘文件进行操作
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class WEEK05_LAB_DEMO_ImageUploadExercise : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		//判断当前页面是否第一次刷新，如果是第一次刷新（即第一次加载当前页面），才执行下列代码
		if (!Page.IsPostBack)
		{
			//自定义函数GetPictureNames()，用于将服务器指定文件夹images下的所有图片文件以项目的形式添加到列表框中
			GetPictureNames();

			//如果当前列表框中没有任何项目（及images文件夹下还没有任何文件）
			if (lstbxImage.Items.Count == 0)
			{
				//则不显示图片框
				imgImage.Visible = false;
			}
			//如果有文件
			else
			{
				//默认选中图片框中第一项
				lstbxImage.SelectedIndex = 0;
				//通过指定图片框的ImageUrl属性，来指定图片框要显示的图片
				//因为所有的图片文件都上传到images文件夹下，所以在指定ImageUrl属性时也要在前面拼接上"images/"
				ShowImage();
				//使图片框可见
				imgImage.Visible = true;
			}
		}
	}

	private void ShowImage()
	{
		//对Image控件的ImageUrl属性赋值，使其显示图片
		imgImage.ImageUrl = "images/" + lstbxImage.SelectedItem.Text;
	}

	protected void btnRefresh_Click(object sender, EventArgs e)
	{
		//按刷新按钮后，刷新列表框的显示
		GetPictureNames();
	}

	private void GetPictureNames()
	{
		//声明一个字符串数组，用于存放images文件夹下所有的文件的完整路径（如d:\http\week05_lab\images\abc.jpg）
		string[] pictureNameList;
		
		try
		{
			//得到images文件夹在服务器磁盘上的路径
			string pictureDir = Server.MapPath("images\\");

			//利用Directory.GetFiles()方法，得到指定文件夹下所有文件的完整路径
			//并以字符串数组的形式返回
			//注意：通过GetFiles()方法得到的文件名为一个完整的路径
			//（如C:\Inetpub\wwwroot\UploadPicturesExample\images\abc.jpg），而并非单纯的abc.jpg
			pictureNameList = Directory.GetFiles(pictureDir);

			//清除列表框中所有的项目
			lstbxImage.Items.Clear();

			foreach (string currentFileName in pictureNameList)//遍历此字符串数组
			{
				//将所有文件名作为一个一个的项目添加到列表框中
				//.LastIndexOf("\\")方法的作用为得到这个这个字符串中最有一个"\"字符在整个字符串中的位置，这样可以将文件的路径与主文件名分离开来
				// 注意：LastIndexOf()方法用于得到某个字符串中最后一个指定字符串的索引值。
				// 假设字符串变量 str = "ABACDAFG"，那么str.LastIndexOf("A") 的值为5；str.LastIndexOf("AC") 的值为2。
				//.Substring()字符串的作用为从指定位置开始得到某个字符串的字串
				// Substring()方法用于得到某个字符串中从指定索引开始的一个子串。假设字符串变量 str = "ABACDAFG"，
				//那么str.Substring(3) 的值为"CDAFG"，str.Substring(5)的值为"AFG"
				//每次都将最新的项目添加到第一项的位置
				lstbxImage.Items.Add(currentFileName.Substring(currentFileName.LastIndexOf("\\") + 1));
				
			}
		}
		//若出现异常
		catch (Exception ex)
		{
			Response.Write("文件获取失败。错误信息：" + ex.Message);//则报错
		}
	}

	protected void btnUpload_Click(object sender, EventArgs e)
	{
		//得到选中要上传的文件的最后一个"\"字符的位置
		int lastIndexOfSlash = fileUpload.FileName.LastIndexOf("\\");
		//得到选中要上传的文件的文件名
		string fileName = fileUpload.FileName.Substring(lastIndexOfSlash + 1);
		//得到选中要上传的文件的最后一个"."字符的位置
		int lastIndexOfDot = fileName.LastIndexOf(".");
		//得到要上传的文件的后缀名，并变所有字符为大写
		string fileExtName = fileName.Substring(lastIndexOfDot + 1).ToUpper();

		//若后缀名不是这些格式
		if (fileExtName != "JPG" && fileExtName != "JPEG" && fileExtName != "PNG" && fileExtName != "GIF" &&
			fileExtName != "BMP")
		{
			//则报错
			Response.Write("上传的文件格式不对，请重试。只接受JPG/JPEG/PNG/GIF/BMP类型的文件");
		}
		//若要上传的文件存在
		else if (fileUpload.HasFile)
		{
			try
			{
				//得到在服务器磁盘上images所在的路径
				string uploadDir = Server.MapPath("images\\");
				//得到在服务器磁盘上上传文件要保存的路径
				string uploadFilePath = uploadDir + fileName;
				//利用SaveAs()方法，保存文件到服务器上指定路径
				fileUpload.SaveAs(uploadFilePath);
			}
			//若出现异常
			catch (Exception ex)
			{
				//则报错
				Response.Write("文件上传失败。错误信息：" + ex.Message);
			}
			//刷新列表框
			GetPictureNames();
			//自动选中户刚上传的那项
			lstbxImage.SelectedValue = fileName;
			//重新显示图片
			ShowImage();
		}
	}

	protected void lstbxImage_SelectedIndexChanged(object sender, EventArgs e)
	{
		//当列表框中选项改变时，改变图片框要显示的文件
		ShowImage();
	}
}
