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

public partial class ValidatorExamples : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //验证控件的 ControlToValidate 属性也可以通过代码指定
        //if (!Page.IsPostBack)
        //{
        //    rfvAccount.ControlToValidate = txtAccount.ID;
        //}
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
       
    }
}
