using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SendEmailUseExample : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{

	}

	protected void btnSendEmail_Click(object sender, EventArgs e)
	{
		try
		{
			
			//第三步时注释掉
			//设置 SMTP 服务器地址
			//SmtpClient client = new SmtpClient("smtp.qq.com");
			//client.Credentials = new NetworkCredential("11234387@qq.com", "ningboliuwei"); //邮箱身份验证
			//第三步时注释掉


			MailMessage mail = new MailMessage(txtFrom.Text, txtTo.Text);
			//主题
			mail.Subject = txtSubject.Text;
			//正文
			mail.Body = txtBody.Text;
			//第二步
			//附件
			mail.Attachments.Add(new Attachment(txtAttachment.Text));
			//第二步

			//第三步
			SmtpClient client = new SmtpClient(txtSMTP.Text);
			client.Credentials = new NetworkCredential(txtFrom.Text, txtPassword.Text); //邮箱身份验证

			client.Send(mail);
			Response.Write("邮件发送成功。");
		}
		catch (Exception ex)
		{
			Response.Write("邮件发送失败，错误：" + ex.Message);
		}

	}
}