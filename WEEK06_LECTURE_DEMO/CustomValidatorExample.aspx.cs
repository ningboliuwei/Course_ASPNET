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

public partial class CustomValidatorExample : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
	protected void cvEvenNumber_ServerValidate(object source, ServerValidateEventArgs args)
	{
		if (Convert.ToInt32(txtEvenNumber.Text)%2 == 0)
		{
			args.IsValid = true;
		}
		else
		{
			args.IsValid = false;
		}
	}
}
