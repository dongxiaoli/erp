<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WISD.CarERP.Web.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>登录</title>
    <link href="CSS/Style.css" rel="stylesheet" type="text/css" />
    <script language="javascript" type="text/javascript" >
        function refreshCode() {
            var image = document.getElementById("imgCheck");
            if (image != null) {
                image.src = image.src + "?";
            }
        }
    </script>
</head>
<body>
    <form id="Form1" runat="server">
    <div id="login_body">
        <div id="login_div">
            <div id="login_form_div">
                <table border="0" width="700">
                    <tbody>
                        <tr>
                            <td width="360">
                                <div style="float:left;"><img width="80" src="Image/lock.png" /></div>
                                <div style="float:left;font-size:30px; margin-top:26px;">汽车之友ERP系统</div>
                            </td>
                            <td>
                                <table border="0" width="340">
                                    <tbody>
                                        <tr>
                                            <td width="230">
                                                <div style="margin-top:15px;">
                                                <label>
                                                    帐&nbsp;&nbsp;&nbsp;号:
                                                    <asp:TextBox ID="txtUserName" runat="server" CssClass="login_input" ></asp:TextBox>
                                                </label>
                                                <br />
                                                <label>
                                                    密&nbsp;&nbsp;&nbsp;码:
                                                    <asp:TextBox ID="txtUserPassword" runat="server" CssClass="login_input"  TextMode="Password"></asp:TextBox>
                                                </label>
                                                <br />
                                                <label>
                                                    验证码:
                                                    <asp:TextBox ID="txtCheckCode" runat="server" CssClass="login_input_check" ></asp:TextBox>
                                                    <a style="cursor:pointer;" onclick="refreshCode()" title="点击获取新的验证码！">
                                                        <asp:Image Runat="server" ID="imgCheck" Width="65px" ImageUrl="Utility/ValidateCode.aspx"></asp:Image>
                                                    </a>
                                                </label>
                                                </div>
                                            </td>
                                            <td align="left">
                                                <asp:ImageButton ID="ibtnLogin" runat="server" CssClass="login_btn" ImageUrl="Image/login_btn.gif"
                                                    OnClick="ibtnLogin_Click" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="2" class="tipbox" style="background: url(Image/hint.gif) 0 6px no-repeat;
                                                padding-left: 15px;">
                                                提示：<asp:Label ID="lblMessage" runat="server" Text="登录失败3次，需关闭后才能重新登录"></asp:Label>
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
        <div id="login_footer">Copyright © 2010-2013 汽车之友 All Rights Reserved</div>
    </div>
    </form>
</body>
</html>