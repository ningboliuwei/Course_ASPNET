﻿using System;
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

public partial class menu_right : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
             bind();
        }
      
        
    }
    private void bind()
    {
        if(Session["Name"]==null)
        {
            Response.Redirect("../Users/Login.aspx");
        }
        Label1.Text = Session["Name"].ToString();
    }
}
