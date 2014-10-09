<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="left.ascx.cs" Inherits="ShopProject.Back.admin.left" %>
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
			
			<div id="profile-links">			   <div class="user">			    
                <asp:Image ID="Image1" runat="server"  Width="44px"/>
				Hello, <a href="#" title="Edit your profile">
                    <asp:Label ID="Label1" runat="server" Text=""></asp:Label></a><br />                    
                <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
				<br />
				<a href="/BookLogin.aspx" title="View the Site">首页</a> | <a href="/Back/logout.aspx" title="Sign Out">退出</a>				</div>
			</div>        
			<ul id="main-nav">  
								<li> 
					<a href="#" class="nav-top-item current">					管理中心					</a>					<ul>
						<li ><a  href="/Back/admin/OneUserInfo.aspx" target="right">个人信息</a></li>
						<li ><a  href="/Back/admin/AddUser.aspx" target="right">添加用户</a></li>
						<li><a  href="/Back/admin/User_Guan.aspx" target="right">管理用户</a></li> 
   					    <li ><a href="/Back/admin/changepwd.aspx" target="right">修改密码</a></li>											</ul>				</li>				<li>					<a href="#" class="nav-top-item">					商品管理					</a>					<ul>						<li><a href="/Back/admin/addShop.aspx" target="right">添加商品</a></li>						<li><a href="/Back/admin/ShopList.aspx" target="right">商品查看</a></li>											</ul>				</li>				<li>
					<a href="#" class="nav-top-item">					类别管理
					</a>
   				    <ul>
						<li><a href="/Back/admin/addSort.aspx" target="right">添加类别</a></li>
						<li><a href="/Back/admin/showSort.aspx" target="right">管理类别</a></li>
						
					</ul>
				</li>				<li>					<a href="#" class="nav-top-item">						订单管理					</a>					<ul>						<li><a href="/Back/admin/showOrders.aspx" target="right">查看订单</a></li>
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
