using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class FontChanger : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    
    protected void btnChangeTestText_Click(object sender, EventArgs e)
    {
        lblTestText.Text = txtTestText.Text;
    }
    protected void drpFontSize_SelectedIndexChanged(object sender, EventArgs e)
    {
        //if (drpFontSize.SelectedIndex == 0)
        //{
        //    lblTestText.Font.Size = 10;
        //}
        //else if (drpFontSize.SelectedIndex == 1)
        //{
        //    lblTestText.Font.Size = 20;
        //}
        //else if (drpFontSize.SelectedIndex == 2)
        //{
        //    lblTestText.Font.Size = 30;
        //}
        //else if (drpFontSize.SelectedIndex == 3)
        //{
        //    lblTestText.Font.Size = 40;
        //}
        //else if (drpFontSize.SelectedIndex == 4)
        //{
        //    lblTestText.Font.Size = 50;
        //}
        //else
        //{
            
        //}

        lblTestText.Font.Size = Convert.ToInt32(drpFontSize.SelectedValue);
    }
    protected void chkBold_CheckedChanged(object sender, EventArgs e)
    {
        if (chkBold.Checked)
        {
            lblTestText.Font.Bold = true;
        }
        else
        {
            lblTestText.Font.Bold = false;
        }
    }
    protected void chkItalic_CheckedChanged(object sender, EventArgs e)
    {
        if (chkItalic.Checked)
        {
            lblTestText.Font.Italic = true;
        }
        else
        {
            lblTestText.Font.Italic = false;
        }
    }
    protected void rdoSong_CheckedChanged(object sender, EventArgs e)
    {
        if (rdoSong.Checked)
        {
            lblTestText.Font.Name="宋体";
        }
        
    }
    protected void rdoHei_CheckedChanged(object sender, EventArgs e)
    {
        if (rdoHei.Checked)
        {
            lblTestText.Font.Name = "黑体";
        }
    }
    protected void rdoLishu_CheckedChanged(object sender, EventArgs e)
    {
        if (rdoLishu.Checked)
        {
            lblTestText.Font.Name = "隶书";
        }
    }
    protected void chkFontStyle_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (chkFontStyle.Items[0].Selected)
        {
            lblTestText.Font.Underline = true;
        }
        else
        {
            lblTestText.Font.Underline = false;
        }

        if (chkFontStyle.Items[1].Selected)
        {
            lblTestText.Font.Strikeout = true;
        }
        else
        {
            lblTestText.Font.Strikeout = false;
        }

        if (chkFontStyle.Items[2].Selected)
        {
            lblTestText.Font.Overline = true;
        }
        else
        {
            lblTestText.Font.Overline = false;
        }
    }
    protected void rdoColorRed_CheckedChanged(object sender, EventArgs e)
    {
        if (rdoColorRed.Checked)
        {
            lblTestText.ForeColor = Color.Red;
        }
    }
    protected void rdoColorYellow_CheckedChanged(object sender, EventArgs e)
    {
        if (rdoColorYellow.Checked)
        {
            lblTestText.ForeColor = Color.Yellow;
        }
    }
    protected void rdoColorBlue_CheckedChanged(object sender, EventArgs e)
    {
        if (rdoColorBlue.Checked)
        {
            lblTestText.ForeColor = Color.Blue;

        }
    }
   
}
