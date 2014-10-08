<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="菜单控件._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
    <head runat="server">
        <title>无标题页</title>
    </head>
    <body>
        <form id="form1" runat="server">
            <div>
    
                <asp:Menu ID="mnuMain" runat="server" onmenuitemclick="mnuMain_MenuItemClick" 
                          Orientation="Horizontal">
                    <Items>
                        <asp:MenuItem Text="视频教程" Value="视频教程">
                            <asp:MenuItem Text="C# 2.0" Value="C# 2.0"></asp:MenuItem>
                            <asp:MenuItem Text="C# 3.5" Value="C# 3.5">
                                <asp:MenuItem Text="第一章 安装" Value="第一章 安装"></asp:MenuItem>
                                <asp:MenuItem Text="第二章 C#基础语法" Value="第二章 C#基础语法"></asp:MenuItem>
                            </asp:MenuItem>
                            <asp:MenuItem Text="ASP.NET 2.0" Value="ASP.NET 2.0"></asp:MenuItem>
                            <asp:MenuItem Text="ASP.NET 3.5" Value="ASP.NET 3.5"></asp:MenuItem>
                        </asp:MenuItem>
                        <asp:MenuItem Text="靓站欣赏" Value="靓站欣赏">
                            <asp:MenuItem Text="门户鼻祖" Value="门户鼻祖"></asp:MenuItem>
                            <asp:MenuItem Text="新奇力量" Value="新奇力量"></asp:MenuItem>
                        </asp:MenuItem>
                        <asp:MenuItem Text="业界动态" Value="业界动态">
                            <asp:MenuItem Text="IT潮流" Value="IT潮流"></asp:MenuItem>
                            <asp:MenuItem NavigateUrl="http://www.sina.com.cn" Text="IT新技术" Value="IT新技术">
                            </asp:MenuItem>
                        </asp:MenuItem>
                        <asp:MenuItem Text="E网打尽" Value="E网打尽"></asp:MenuItem>
                    </Items>
                </asp:Menu>
    
            </div>
        </form>
    </body>
</html>