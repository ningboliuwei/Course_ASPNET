using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MemberAndRoleControl_Manager : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
	protected void btnCreateUser_Click(object sender, EventArgs e)
	{
		try
		{
			Membership.CreateUser(txtUserName.Text.Trim(), txtPassword.Text.Trim(), txtEmail.Text.Trim());
			Response.Write("成功创建用户");
		}
		catch (Exception ex)
		{
			Response.Write(ex.Message);
		}
			

	}

	protected void btnDeleteUser_OnClick(object sender, EventArgs e)
	{
		try
		{
			Membership.DeleteUser(txtUserNameToDelete.Text.Trim());
			Response.Write("成功删除用户");
		}
		catch (Exception ex)
		{
			Response.Write(ex.Message);
		}
	}

	protected void btnCreateRole_OnClick(object sender, EventArgs e)
	{
		try
		{
			Roles.CreateRole(txtRoleName.Text.Trim());
			Response.Write("成功创建角色");
		}
		catch (Exception ex)
		{
			Response.Write(ex.Message);
		}
	}

	protected void btnDeleteRole_OnClick(object sender, EventArgs e)
	{
		try
		{
			Roles.DeleteRole(txtRoleNameToDelete.Text.Trim());
			Response.Write("成功删除角色");
		}
		catch (Exception ex)
		{
			Response.Write(ex.Message);
		}
	}

	protected void btnDisplayUsersInRole_OnClick(object sender, EventArgs e)
	{
		try
		{
			string[] users = Roles.GetUsersInRole(txtRoleNameForUserDisplay.Text.Trim());
			foreach (string user in users)
			{
				Response.Write(user + "<br/>");
			}
		}
		catch (Exception ex)
		{
			Response.Write(ex.Message);
		}
	}

	protected void btnAddUserToRole_OnClick(object sender, EventArgs e)
	{
		try
		{
			Roles.AddUserToRole(txtAddUserToRoleUserName.Text.Trim(), txtAddUserToRoleRoleName.Text.Trim());
			Response.Write("成功将用户加入角色");
		}
		catch (Exception ex)
		{
			Response.Write(ex.Message);
		}
	}

	protected void btnRemoveUserFromRole_OnClick(object sender, EventArgs e)
	{
		try
		{
			Roles.RemoveUserFromRole(txtRemoveUserFromRoleUserName.Text.Trim(), txtRemoveUserFromRoleRoleName.Text.Trim());
			Response.Write("成功将用户从角色中移除");
		}
		catch (Exception ex)
		{
			Response.Write(ex.Message);
		}
	}
}