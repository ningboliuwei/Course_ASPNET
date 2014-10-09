<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Defalut.aspx.cs" Inherits="ShopProject.Defalut" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
<link rel="stylesheet" href="css/login.css" type="text/css" media="screen" />
<link rel="stylesheet" href="css/meue.css" type="text/css" media="screen" />
<script type="text/javascript" src="js/login/meue/jquery-1.3.2.min.js"></script>
<script type=text/javascript>
    $(function() {
        $('#webmenu li').hover(function() {
            $(this).children('ul').stop(true, true).show('slow');
        }, function() {
            $(this).children('ul').stop(true, true).hide('slow');
        });

        $('#webmenu li').hover(function() {
            $(this).children('div').stop(true, true).show('slow');
        }, function() {
            $(this).children('div').stop(true, true).hide('slow');
        });
    });
</script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="box">
       <div id="nar">
          <div id="nar-top"></div>
          <div id="nar-bottom">
               <ul id="webmenu" class="first-menu">
                  
                  <li><a href="#" target="_self">建立网站</a>
                    <ul style="display: none;" id="subMusic" class="second-menu">
                      <li><a href="#" class="arrow" target="_self">域名空间</a>
                        <ul class="third-menu">
                          <li><a href="http://www.fatcow.com/">fatcow</a></li>
                          <li><a href="http://www.justhost.com/">justhost</a></li>
                          <li><a href="http://www.ipower.com/">ipower</a></li>
                          <li><a href="http://www.inmotionhosting.com/">inmotion</a></li>
                          <li><a href="http://www.ixwebhosting.com/index.php/v2/pages.dspmain">ixweb</a></li>
                          <li><a href="http://www.supergreenhosting.com/">supergreen</a></li>
                          <li><a href="http://www.hostgator.com/">hostgator</a></li>
                          <li><a href="http://www.powweb.com/">powweb</a></li>
                          <li><a href="http://www.startlogic.com/">startlogic</a></li>
                          <li><a href="http://www.greengeeks.com/">greengeeks</a></li>
                        </ul>
                      </li>
                      <li><a href="#" class="arrow" target="_self">CSS 模版</a>
                        <ul class="third-menu">
                          <li><a href="http://www.mezzoblue.com/zengarden/alldesigns/">zengerden</a></li>
                          <li><a href="http://www.freecsstemplates.org/">freecsstemplates.org</a></li>
                          <li><a href="http://www.oswd.org/">oswd.org</a></li>
                          <li><a href="http://www.opendesigns.org/">opendesigns.org</a></li>
                          <li><a href="http://www.cssplay.co.uk/">cssplay</a></li>
                          <li><a href="http://www.studiopress.com/">studiopress</a></li>
                          <li><a href="http://www.styleshout.com/">styleshout</a></li>
                        </ul>
                      </li>
                      <li><a href="#" class="arrow" target="_self">CSS 学习</a>
                        <ul class="third-menu">
                          <li><a href="http://www.x-css.cn/">ken's blog</a></li>
                          <li><a href="http://www.ndoherty.com/portfolio/">ndoherty</a></li>
                          <li><a href="http://www.inlco.cn/">andy's blog</a></li>
                          <li><a href="http://www.cssplay.co.uk/">cssplay</a></li>
                        </ul>
                      </li>
                      <li><a href="#" class="arrow" target="_self">博客制作</a>
                        <ul class="third-menu">
                        </ul>
                      </li>
                      <li><a href="#" class="arrow" target="_self">素材下载</a>
                        <ul class="third-menu">
                          <li><a href="http://flashden.net/">flashden.net</a></li>
                          <li><a href="http://www.zcool.com.cn/">站酷</a></li>
                        </ul>
                      </li>
                      <li><a href="#" class="arrow" target="_self">管理维护</a>
                        <ul class="third-menu">
                          <li><a href="http://www.chinaz.com/">中国站长</a></li>
                          <li><a href="http://www.68design.net/Web-Guide/">网页设计师联盟</a></li>
                          <li><a href="http://www.blueidea.com/">蓝色理想</a></li>
                          <li><a href="http://homepage.yesky.com/">天极网页</a></li>
                          <li><a href="http://learning.artech.cn/">前沿教室</a></li>
                        </ul>
                      </li>
                    </ul>
                  </li>
                  <li><a href="#" target="_self">工作生活</a>
                    <ul id="subNews" class="second-menu">
                      <li><a href="#" class="arrow" target="_self">搜索</a>
                        <ul class="third-menu">
                          <li><a href="http://www.baidu.com/">百度</a></li>
                          <li><a href="http://www.google.cn/">Google</a></li>
                          <li><a href="http://dir.sogou.com/">搜狐</a></li>
                        </ul>
                      </li>
                      <li><a href="#" class="arrow" target="_self">新闻</a>
                        <ul class="third-menu">
                          <li><a href="http://www.sina.com.cn/">新浪</a></li>
                          <li><a href="http://www.qq.com/">腾讯</a></li>
                          <li><a href="http://www.sohu.com/">搜狐</a></li>
                          <li><a href="http://www.163.com/">网易</a></li>
                          <li><a href="http://www.ifeng.com/">凤凰网</a></li>
                        </ul>
                      </li>
                      <li><a href="#" class="arrow" target="_self">招聘</a>
                        <ul class="third-menu">
                          <li><a href="http://www.chinahr.com/index.htm">中华英才网</a></li>
                          <li><a href="http://www.51job.com/">前程无忧</a></li>
                          <li><a href="http://www.zhaopin.com/">智联招聘</a></li>
                          <li><a href="http://www.cjol.com/">中国人才热线</a></li>
                          <li><a href="http://www.01job.cn/">上海第一招聘</a></li>
                          <li><a href="http://www.528.com.cn/">528招聘网</a></li>
                          <li><a href="http://www.1010jz.com/">1010兼职网</a></li>
                        </ul>
                      </li>
                      <li><a href="#" class="arrow" target="_self">网赚</a>
                        <ul class="third-menu">
                          <li><a href="http://www.vikecn.com/">威客中国</a></li>
                        </ul>
                      </li>
                      <li><a href="#" class="arrow" target="_self">购物</a>
                        <ul class="third-menu">
                          <li><a href="#" class="arrow" target="_self">网站</a>
                            <ul class="fourth-menu">
                              <li><a href="http://www.taobao.com/">淘宝网</a></li>
                              <li><a href="http://www.dangdang.com/">当当网</a></li>
                              <li><a href="http://www.eachnet.com/">易趣网</a></li>
                              <li><a href="http://youa.baidu.com/">百度有啊</a></li>
                              <li><a href="http://www.amazon.cn/">卓越网</a></li>
                              <li><a href="http://www.paipai.com/">拍拍网</a></li>
                              <li><a href="http://china.alibaba.com/">阿里巴巴</a></li>
                              <li><a href="http://www.360buy.com/">京东商城</a></li>
                              <li><a href="http://www.gumzzi.com/">锦上添花女装</a></li>
                            </ul>
                          </li>
                          <li><a href="#" class="arrow" target="_self">快递公司</a>
                            <ul class="fourth-menu">
                              <li><a href="http://www.sto.cn/">申通快递</a></li>
                              <li><a href="http://www.yto.net.cn/">圆通快递</a></li>
                              <li><a href="http://www.ems.com.cn/">EMS特快专递</a></li>
                              <li><a href="http://www.sf-express.com/">顺丰快递</a></li>
                              <li><a href="http://www.ttkdex.com/">天天快递</a></li>
                              <li><a href="http://www.zto.cn/">中通快递</a></li>
                              <li><a href="http://www.yundaex.com/www/index.html">韵达快运</a></li>
                            </ul>
                          </li>
                          <li><a href="#" class="arrow" target="_self">电子支付</a>
                            <ul class="fourth-menu">
                              <li><a href="https://www.alipay.com/">支付宝</a></li>
                              <li><a href="https://www.99bill.com/">快钱</a></li>
                              <li><a href="https://www.tenpay.com/">财付通</a></li>
                              <li><a href="https://www.paypal.com/c2">paypal</a></li>
                              <li><a href="https://www.baifubao.com/">百付宝</a></li>
                            </ul>
                          </li>
                        </ul>
                      </li>
                      <li><a href="#" class="arrow" target="_self">科技</a>
                        <ul class="third-menu">
                          <li><a href="http://www.patent-cn.com/">专利之家</a></li>
                        </ul>
                      </li>
                    </ul>
                  </li>
                  <li><a href="#" class="arrow" target="_self">休闲娱乐</a>
                    <ul style="display: none;" id="subMgm" class="second-menu">
                      <li><a href="#" class="arrow" target="_self">游戏</a>
                        <ul class="third-menu">
                          <li><a href="#" class="arrow" target="_self">网络游戏</a>
                            <ul class="fourth-menu">
                              <li><a href="http://wow.163.com/">魔兽世界</a></li>
                              <li><a href="http://au.9you.com/web_v5/index_top.html">劲舞团</a></li>
                              <li><a href="http://popkart.tiancity.com/homepage/">跑跑卡丁车</a></li>
                              <li><a href="http://zt.ztgame.com/">征途</a></li>
                              <li><a href="http://wd.gyyx.cn/">问道</a></li>
                              <li><a href="http://ploy.bnb.sdo.com/20070904/web/flash.htm">泡泡堂</a></li>
                              <li><a href="http://rxjh.17game.com/">热血江湖</a></li>
                              <li><a href="http://www.fsjoy.com/">街头篮球</a></li>
                              <li><a href="http://xyq.163.com/">梦幻西游</a></li>
                              <li><a href="http://speed.qq.com/index.shtml">QQ飞车</a></li>
                              <li><a href="http://mxd.sdo.com/homepage.htm">冒险岛</a></li>
                              <li><a href="http://sh.xoyo.com/">水浒Q传</a></li>
                              <li><a href="http://cf.qq.com/">穿越火线</a></li>
                              <li><a href="http://tl.changyou.com/">天龙八部</a></li>
                              <li><a href="http://zhuxian.wanmei.com/">诛仙</a></li>
                              <li><a href="http://wulin2.wanmei.com/">武林外传</a></li>
                              <li><a href="http://world2.wanmei.com/">完美世界</a></li>
                              <li><a href="http://sf.17game.com/index.php">特种部队</a></li>
                              <li><a href="http://mir2.sdo.com/web/index.html">热血传奇</a></li>
                            </ul>
                          </li>
                          <li><a href="http://www.17173.com/">17173</a></li>
                        </ul>
                      </li>
                      <li><a href="#" class="arrow" target="_self">电影</a>
                        <ul class="third-menu">
                          <li><a href="http://www.xunlei.com/">迅雷看看</a></li>
                          <li><a href="http://www.gougou.com/">狗狗搜索</a></li>
                          <li><a href="http://www.verycd.com/">电驴下载</a></li>
                          <li><a href="http://www.80s.cn/">80s手机电影</a></li>
                        </ul>
                      </li>
                      <li><a href="#" class="arrow" target="_self">视频</a>
                        <ul class="third-menu">
                          <li><a href="http://www.youku.com/">优酷</a></li>
                          <li><a href="http://www.tudou.com/">土豆</a></li>
                          <li><a href="http://www.ku6.com/">酷6</a></li>
                          <li><a href="http://6.cn/">六间房</a></li>
                          <li><a href="http://www.56.com/">56</a></li>
                        </ul>
                      </li>
                      <li><a href="#" class="arrow" target="_self">音乐</a>
                        <ul class="third-menu">
                          <li><a href="http://mp3.baidu.com/">百度-MP3</a></li>
                          <li><a href="http://www.qq163.com/">QQ163</a></li>
                          <li><a href="http://www.1ting.com/">一听音乐</a></li>
                        </ul>
                      </li>
                    </ul>
                  </li>
                  <li><a href="http://dufeng007.cn/sample.html" class="arrow" target="_blank">我的网站</a></li>
                </ul>
              
          
          
          </div>
         
       
       
       </div>
        
        
    </div>
    </form>
</body>
</html>
