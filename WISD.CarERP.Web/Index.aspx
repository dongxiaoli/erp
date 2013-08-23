<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WISD.CarERP.Web.Index" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>汽车之友ERP系统</title>
    <link rel="stylesheet" type="text/css" href="CSS/Style.css" />
    <link rel="stylesheet" type="text/css" href="Package/jquery-ui-1.7.2/jquery-ui-1.7.2.custom.css" />
    <script language="javascript" type="text/javascript" src="JS/jquery-1.7.2.js"></script>
    <script language="javascript" type="text/javascript" src="JS/Index.js"></script>
    <script language="javascript" type="text/javascript" src="JS/MessageBox.js"></script>
    <script language="javascript" type="text/javascript" src="Package/jquery-ui-1.7.2/jquery-ui-1.7.2.custom.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <table border="0" cellpadding="0" cellspacing="0" height="100%" width="100%" style="background:#EBF5FC;">
            <tbody>
              <tr>
                <td height="70" colspan="3" style="background:url(Image/head_bg.gif);">
                <table width="100%" border="0" cellspacing="0" cellpadding="0">
                  <tr>
                    <td width="24%" height="70"><span style="font-size:26; color:White; margin-left:22px;">汽车之友ERP系统</span></td>
                    <td width="76%" valign="bottom">
	                  <!--导航菜单,与下面的相关联,修改时注意参数-->
                      <div id="tabs">
                      <ul>
			            <%= TopMenu %>
                      </ul>
                      </div>
                    </td>
                  </tr>
                </table>
                </td>
              </tr>
              <tr>
                <td height="30" colspan="3" style="padding:0px 10px;font-size:12px;background:url(Image/navsub_bg.gif) repeat-x;">
                <div style="float:right;line-height:20px;"> | 
                    <asp:LinkButton ID="lbtnExit" runat="server" onclick="lbtnExit_Click">安全退出</asp:LinkButton>
                </div>
                <div style="padding-left:20px;line-height:20px;background:url(Image/siteico.gif) 0px 0px no-repeat;">
                    当前登录用户：<font color="#FF0000"><asp:Label ID="lblUserName" runat="server" Text="Label"></asp:Label></font>您好，欢迎光临。
               </div>
                </td>
              </tr>
              <tr>
                <td align="middle" id="mainLeft" valign="top" style="background:#FFF;">
	              <div style="text-align:left;width:185px;height:100%;font-size:12px;">
                    <!--导航顶部-->
                    <div style="padding-left:10px;height:29px;line-height:29px;background:url(Image/menu_bg.gif) no-repeat;">
                      <span style="padding-left:15px;font-weight:bold;color:#039;background:url(Image/menu_dot.gif) no-repeat;">功能导航</span>
                    </div>
                    <!--导航菜单,修改时注意顺序-->
                    <%=LeftMenu %>
                  </div>
	            </td>
	            <td valign="middle" style="width:8px;background:url(Image/main_cen_bg.gif) repeat-x;">
                  <div id="sysBar" style="cursor:pointer;"><img id="barImg" src="Image/butClose.gif" alt="关闭/打开左栏" /></div>
	            </td>
	            <td style="width:100%; height:100%;" valign="top">
                  <iframe frameborder="0" id="sysMain" name="sysMain" scrolling="yes" src="" style="height:100%;visibility:inherit; width:100%;z-index:1;"></iframe>
	            </td>
              </tr>
              <tr>
                <td height="28" colspan="3" bgcolor="#EBF5FC" style="padding:0px 10px;font-size:10px;color:#2C89AD;background:url(Image/foot_bg.gif) repeat-x;" align="center">Copyright © 2010-2013 汽车之友 All Rights Reserved</td>
              </tr>
            </tbody>
        </table>
    </form>
</body>
</html>
