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

public partial class ShowInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string strSex = Request.QueryString["sex"];
        string strHobby = Request.QueryString["hobby"];
        string strJob = Request.QueryString["job"];
        string strName = Request.QueryString["name"];
        string strPassword = Request.QueryString["password"];
        string strResume = Request.QueryString["resume"];
        string strOutput = "";

        strOutput += "注册成功！你好，" + strName;

        if (strSex == "男")
        {
            strOutput += "性别为男";
        }
        else if (strSex == "女")
        {
            strOutput += "性别为女";
        }

        strOutput += "<br>你的密码为" + strPassword;
        strOutput += "<br>你的职业为" + strJob;
        strOutput += "<br>你的爱好为" + strHobby;
        strOutput += "<br>你的个人简介为" + strResume;
        Response.Write(strOutput);
    }
}
