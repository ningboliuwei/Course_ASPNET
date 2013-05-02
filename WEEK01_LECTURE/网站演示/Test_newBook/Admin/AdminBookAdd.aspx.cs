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
using System.Data.SqlClient;

public partial class Admin_AdminBookAdd : System.Web.UI.Page
{


    private DataSet dataSet = new DataSet();
    private SqlDataAdapter dataAdapter = new SqlDataAdapter();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Show();
        }

    }
    SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["nd_data"].ConnectionString);
    public void Show()
    {
        string selectCommandText = @"SELECT * from booktype";

        DataSet dataSet = SqlHelper.GetDataSetBySqlCommand(selectCommandText, connection);

        DropDownList1.DataSource = dataSet.Tables[0].DefaultView;
        DropDownList1.DataValueField = dataSet.Tables[0].Columns[0].ColumnName;
        DropDownList1.DataTextField = dataSet.Tables[0].Columns[1].ColumnName; ;
        DropDownList1.DataBind();
    }
    protected void Add_Click(object sender, EventArgs e)
    {
        int lastIndexOfSlash = fileUpload.PostedFile.FileName.LastIndexOf("\\");
        string fileName = fileUpload.PostedFile.FileName.Substring(lastIndexOfSlash + 1);

        int lastIndexOfDot = fileName.LastIndexOf(".");
        string fileExtName = fileName.Substring(lastIndexOfDot + 1).ToUpper();
       // string newFileName = DateTime.Now.ToString("yyyyMMddhhmmss") + DateTime.Now.Millisecond + "." + fileExtName;

        if (fileExtName != "JPG" && fileExtName != "JPEG" && fileExtName != "PNG" && fileExtName != "GIF" && fileExtName != "BMP")
        {
            Response.Write("上传的文件格式不对，请重试。只接受jpg/jpeg/png/gif/bmp了行动文件");

        }
        else if (fileUpload.PostedFile.ContentLength > 0)
        {
            try
            {
                string uploadDir = Server.MapPath("upload\\");
                string uploadFilePath = uploadDir + fileName;

                fileUpload.PostedFile.SaveAs(uploadFilePath);

            }
            catch (Exception ex)
            {

                Response.Write("文件上传失败，错误信息：" + ex.Message);
            }
            //GetpictureNames();
            //lstbxImage.SelectedIndex = 0;
        }

        string BookName = "";
        BookName = TextBox1.Text.ToString();
        string BookPrice = TextBox2.Text.ToString();
        string BookInformation = TextBox3.Text;
        //string sex1 = "";
        string BookFare = TextBox4.Text;
        
        string department = DropDownList1.SelectedValue;
        connection.Open();


        try
        {
            string SQLString =
                @"INSERT INTO Bookinfo (BookName,BookTypeID,BookPrice,Attention,BookPhoto,BookInformation,BookFare,BookFM) VALUES('" + BookName + "','" +
                department + "','" + BookPrice + "','" + 0 + "','" + fileName + "','" + BookInformation + "','" +
                BookFare + "','" + DropDownList2.SelectedItem.Text.ToString() + "')";

            //
            //string SQLString1 = "INSERT INTO Question () VALUES()";QueNum,
            //string SQLString2 = "INSERT INTO Question () VALUES()";'" + QueTextBox4.Text.ToString() + "',
            // string SQLString3 = "INSERT INTO Question () VALUES()";,StuName " + QueTextBox1.Text.ToString() + "'
            //string SQLString = "SELECT QueNum FROM Quesition ";,'
            SqlCommand cmdd = new SqlCommand(SQLString, connection);

            if (cmdd.ExecuteScalar() == null)
            {
                Response.Redirect("AdminBook.aspx");
            }
            else
            {
                Response.Redirect("提交未成功");
            }

        }
        catch (Exception ex)
        {
            Console.Write(ex.Message); //本来应该显示错误原因的。但是没有！！
        }
        finally
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

    }
}
