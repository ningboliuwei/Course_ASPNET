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

public partial class Admin_AdminBookUpdate : System.Web.UI.Page
{
    private string imageurl="";
    private DataSet dataSet = new DataSet();
    private SqlDataAdapter dataAdapter = new SqlDataAdapter();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Show();
            Bind();
            

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
    private void Bind()
    {
        string id = Request.QueryString["id"].ToString();
        try
        {

            string selectCommandText = @"SELECT  * FROM
                           Bookinfo where bookID='" + id + "'";


            DataSet dataSet = SqlHelper.GetDataSetBySqlCommand(selectCommandText, connection);
            //SqlHelper.ExecuteReaderSqlCommand(selectCommandText, connection);
            //string aa = dataSet.Tables[0].ToString();
            // string aaa = dataSet.Tables[0].ToString();
            TextBox1.Text = dataSet.Tables[0].Rows[0]["BookName"].ToString();
            TextBox2.Text = dataSet.Tables[0].Rows[0]["BookPrice"].ToString(); ;//dataSet.Tables["Name"].ToString();
            TextBox3.Text = dataSet.Tables[0].Rows[0]["BookInformation"].ToString();
            TextBox4.Text = dataSet.Tables[0].Rows[0]["BookFare"].ToString();
            Image1.ImageUrl = "upload/" + dataSet.Tables[0].Rows[0]["BookPhoto"].ToString();
            imageurl = dataSet.Tables[0].Rows[0]["BookPhoto"].ToString();

        }
        catch (Exception ex)
        {
            Console.Write(ex.Message);
            Response.End();
        }
        finally
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
    protected void update_Click(object sender, EventArgs e)
    {

        int lastIndexOfSlash = fileUpload.PostedFile.FileName.LastIndexOf("\\");
        string  fileName = fileUpload.PostedFile.FileName.Substring(lastIndexOfSlash + 1);

        int lastIndexOfDot = fileName.LastIndexOf(".");
        string fileExtName = fileName.Substring(lastIndexOfDot + 1).ToUpper();
        string newFileName = DateTime.Now.ToString("yyyyMMddhhmmss") + DateTime.Now.Millisecond + "." + fileExtName;

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
        string BookFare = TextBox4.Text;
        if(fileName=="")
        {
            string  ee=Image1.ImageUrl;
            int eee = ee.IndexOf("/");
            fileName = ee.Substring(eee + 1); ;
        }

        string department = DropDownList1.SelectedValue;
        connection.Open();


        try
        {

            string idd = Request.QueryString["id"].ToString();
            string selectCommandText = @"update Bookinfo set BookName ='" + BookName + "',BookTypeID='" + department + "',BookPrice='" + BookPrice + "'," +
                                       "Attention='" + 0 + "',BookPhoto='" + fileName + "',BookInformation='" + BookInformation + "'," +
                                       "BookFare='" + BookFare + "',BookFM='" + DropDownList2.SelectedItem.Text.ToString() + "' where bookid = '" + idd + "'";
                           
            //string SQLString =
            //    @"INSERT INTO Bookinfo (BookName,BookTypeID,BookPrice,Attention,BookPhoto,BookInformation,BookFare,BookFM) VALUES('" + BookName + "','" +
            //    department + "','" + BookPrice + "','" + 0 + "','" + fileName + "','" + BookInformation + "','" +
            //    BookFare + "','" + DropDownList2.SelectedItem.Text.ToString() + "')";

            SqlCommand cmdd = new SqlCommand(selectCommandText, connection);

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
