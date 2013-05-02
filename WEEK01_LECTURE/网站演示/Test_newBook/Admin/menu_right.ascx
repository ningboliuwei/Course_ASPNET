<%@ Control Language="C#" AutoEventWireup="true" CodeFile="menu_right.ascx.cs" Inherits="menu_right" %>
<html>
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Admin Template</title>
    <link href="../styles/layout.css" rel="stylesheet" type="text/css" />
    <!-- Theme Start -->
    <link href="../themes/blue/styles.css" rel="stylesheet" type="text/css" />
    <!-- Theme End -->
</head>
<body id="homepage" style="background-color: silver;">
    <!-- Top Breadcrumb Start -->
    <!-- Top Breadcrumb End -->
    <!-- Right Side/Main Content Start -->
    <!-- Right Side/Main Content End -->
    <!-- Left Dark Bar Start -->
    <h1 style="margin-top: 20px; margin-left: 30px; width: 132px; height: 56px;">
        后台管理</h1>
    <div id="leftside">
        <div class="user">
            <img src="../img/psu.jpg" width="44" height="44" class="hoverimg" alt="Avatar" />
            <p style="margin-top: 15px">
                hello,你好~</p>
            <p class="username">
                &nbsp;<asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            </p>
            <p class="username">
                adminstrater</p>
            <p class="userbtn">
                <a href="/Test_newBook/Index.aspx" title="">首页</a></p>
            <p class="userbtn">
                <a href="../Users/Login.aspx" title="">退出</a></p>
        </div>
        <div class="notifications">
            <p class="notifycount">
                <a href="" title="" class="notifypop">10</a></p>
            <p>
                <a href="" title="" class="notifypop">后台首页</a></p>
            <p class="smltxt">
                (点击打开订单)</p>
        </div>
        <ul id="nav">
            <li>
                <ul class="navigation">
                    <li class="heading selected">管理后台</li>
                    <li><a href="Admininfo.aspx" title="">个人中心</a></li>
                    <li><a href="Admin_Pwd.aspx" title="">修改密码</a></li>
                </ul>
            </li>
            <li><a class="collapsed heading">商品管理</a>
                <ul class="navigation">
                    <li><a href="AdminBook.aspx" title="">商品操作</a></li>
                    <li><a href="AdminBook_order.aspx" title="">订单管理</a></li>
                    <li><a href="AdminBook_type.aspx" title="">类别管理</a></li>
                </ul>
            </li>
            <li><a class="expanded heading">人员管理</a>
                <ul class="navigation">
                    <li><a href="Admin_Control.aspx" title="" class="likelogin">管理员管理</a></li>
                    <li><a href="User_Control.aspx" title="">用户管理</a></li>
                    <li><a href="Admin_Addperson.aspx" title="">用户添加</a></li>
                </ul>
            </li>
        </ul>
    </div>
    <!-- Left Dark Bar End -->
    <!-- Notifications Box/Pop-Up Start -->
    <div id="notificationsbox">
        <h4>
            Notifications</h4>
        <ul>
            <li><a href="#" title="">
                <img src="../img/icons/icon_square_close.png" alt="Close" class="closenot" /></a>
                <h5>
                    <a href="#" title="">New member registration</a></h5>
                <p>
                    Admin eve joined on 18.12.2010</p>
            </li>
            <li><a href="#" title="">
                <img src="../img/icons/icon_square_close.png" alt="Close" class="closenot" /></a>
                <h5>
                    <a href="#" title="">New member registration</a></h5>
                <p>
                    Jackson Michael joined on 16.12.2010</p>
            </li>
            <li><a href="#" title="">
                <img src="../img/icons/icon_square_close.png" alt="Close" class="closenot" /></a>
                <h5>
                    <a href="#" title="">New blog post created</a></h5>
                <p>
                    New post created on 15.12.2010</p>
            </li>
            <li><a href="#" title="">
                <img src="../img/icons/icon_square_close.png" alt="Close" class="closenot" /></a>
                <h5>
                    <a href="#" title="">New group created</a></h5>
                <p>
                    “Web Design” group created on 12.12.2010</p>
            </li>
            <li><a href="#" title="">
                <img src="../img/icons/icon_square_close.png" alt="Close" class="closenot" /></a>
                <h5>
                    <a href="#" title="">1 new private message</a></h5>
                <p>
                    New message from Joe sent on 21.11.2010</p>
            </li>
            <li><a href="#" title="">
                <img src="../img/icons/icon_square_close.png" alt="Close" class="closenot" /></a>
                <h5>
                    <a href="#" title="">New member registration</a></h5>
                <p>
                    Graham joined on 20.11.2010</p>
            </li>
        </ul>
    </div>

    <script type='text/javascript' src='../scripts/enhance.js'></script>

    <script type='text/javascript' src='../scripts/excanvas.js'></script>

    <script type="text/javascript" src='../scripts/jquery.min.js'></script>

    <script type="text/javascript" src='../scripts/jquery-ui.min.js'></script>

    <script type='text/javascript' src='../scripts/jquery.wysiwyg.js'></script>

    <script type='text/javascript' src='../scripts/visualize.jQuery.js'></script>

    <script type="text/javascript" src='../scripts/functions.js'></script>

</body>
</html>
