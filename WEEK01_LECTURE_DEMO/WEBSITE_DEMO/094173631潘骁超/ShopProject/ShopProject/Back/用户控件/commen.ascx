<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="commen.ascx.cs" Inherits="ShopProject.Back.用户控件.commen" %>
<html>
<head>
<link rel="stylesheet" href="../../css/left.css" type="text/css" media="screen" />
<script type="text/javascript" src="/js/left/jquery-1.3.2.min.js"></script>
</head>
<body>

    <div id="body-wrapper">                                        
		<div id="sidebar">
		  <div id="sidebar-wrapper"> 
			<h1 id="sidebar-title"><a href="#">Simpla Admin</a></h1>
			
			<img id="logo" src="../../images/left/logo.png" alt="Simpla Admin logo" />
			
			<div id="profile-links">			   <div class="user">			    <asp:Image ID="Image1" runat="server"  Width="44px"/>
				Hello, <a href="#" title="Edit your profile">
                    <asp:Label ID="Label1" runat="server" Text=""></asp:Label></a><br />                    
                <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
				<br />
				<a href="/BookLogin.aspx" title="View the Site">首页</a> | <a href="/Back/logout.aspx" title="Sign Out">退出</a>				</div>
			</div>        
			<ul id="main-nav">  
								<li> 
					<a href="#" class="nav-top-item current">					个人中心					</a>					<ul>
						<li ><a  href="/Back/commen/OneComUser.aspx" target="right">个人信息</a></li>
					
					 
   					    <li ><a href="/Back/admin/changepwd.aspx" target="right">修改密码</a></li>											</ul>				</li>								<li>					<a href="#" class="nav-top-item">						我的订单					</a>					<ul>						<li><a href="/Back/commen/myOrders.aspx" target="right">已有订单</a></li>					
					</ul>
				</li>
				<li>
					<a href="#" class="nav-top-item">						待定中
					</a>
   				    <ul>
						<li><a href="#">********</a></li>
						<li><a href="#">********</a></li>
						<li><a href="#">********</a></li>
						<li><a href="#">********</a></li>
					</ul>
				</li>
				<li>
					<a href="#" class="nav-top-item">						待定中
					</a>
   				    <ul>
						<li><a href="#">********</a></li>
						<li><a href="#">********</a></li>
						<li><a href="#">********</a></li>
						<li><a href="#">********</a></li>
					</ul>
				</li>  
			</ul> 		</div>				   </div>   </div>
</body>
</html>
