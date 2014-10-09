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

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnOK_Click(object sender, EventArgs e)
    {
        string strName = "";
        string strPassword = "";
        string strResume = "";
        string strJob = "";
        string strSex = "";
        string strHobby = "";

        if (rdoMale.Checked == true)
        {
            strSex = "男";
        }
        else if (rdoFemale.Checked == true)
        {
            strSex = "女";
        }
        strName += txtName.Text;
        strPassword += txtPassword.Text;
        strJob += dplJob.Text;

        if (chkReading.Checked == true)
        {
            strHobby += "阅读";
        }
        if (chkSing.Checked == true)
        {
            strHobby += "唱歌";
        }
        if (chkDance.Checked == true)
        {
            strHobby += "跳舞";
        }
        strResume += txtResume.Text;
        Response.Redirect(String.Format("ShowInfo.aspx?name={0}&sex={1}&pwd={2}&job={3}&hobby={4}&resume={5}",
            strName, strSex, strPassword, strJob, strHobby, strResume));
    }
}
