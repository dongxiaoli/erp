<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CompanyManageEdit.aspx.cs"
    Inherits="WISD.CarERP.Web.Module.SystemManage.CompanyManage.CompanyManageEdit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../../../CSS/Style.css" rel="stylesheet" type="text/css" />
    <script src="../../../JS/jquery-1.7.2.js" type="text/javascript"></script>
    <script src="../../../JS/jquery.validate.min.js" type="text/javascript"></script>
    <script src="../../../JS/cursorfocus.js" type="text/javascript"></script>
    <script src="../../../JS/messages_cn.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function () {
            //表单验证JS
            $("#form1").validate({
                //出错时添加的标签
                errorElement: "span",
                success: function (label) {
                    //正确时的样式
                    label.text(" ").addClass("success");
                }
            });
        });
    </script>
</head>
<body style="padding: 10px;">
    <form id="form1" runat="server">
    <div class="navigation">
        <span class="back"><a href="CompanyManageList.aspx">返回列表</a></span><b>您当前的位置：首页 &gt;
            公司管理 &gt; 修改公司</b>
    </div>
    <div style="padding-bottom: 10px;">
    </div>
    <table width="100%" border="0" cellspacing="0" cellpadding="0" class="msgtable">
        <tr>
            <th colspan="2" align="left">
                修改公司
            </th>
        </tr>
        <tr>
            <td width="25%" align="right">
                公司名称：
            </td>
            <td width="75%">
                <asp:TextBox ID="txtCompanyName" runat="server" CssClass="input required" size="50"
                    MaxLength="200" minlength="1" HintTitle="公司名称" HintInfo="公司名称。"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right">
                联系人：
            </td>
            <td>
                <asp:TextBox ID="txtContacter" runat="server" CssClass="input required" size="25"
                    MaxLength="50" HintTitle="联系人" HintInfo="联系人"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right">
                联系人电话：
            </td>
            <td>
                <asp:TextBox ID="txtContacterPhone" runat="server" CssClass="input required" size="25"
                    MaxLength="50"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td width="25%" align="right">
                公司地址：
            </td>
            <td width="75%">
                <asp:TextBox ID="txtCompanyAddress" runat="server" CssClass="input required" size="50"
                    MaxLength="500"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right">
                父公司：
            </td>
            <td>
                <asp:DropDownList ID="ddlParent" runat="server">
                    <asp:ListItem Value="0">父公司</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td align="right">
                排序：
            </td>
            <td>
                <asp:TextBox ID="txtSort" runat="server" CssClass="input required" size="25" MaxLength="4"></asp:TextBox>
            </td>
        </tr>
    </table>
    <div style="margin-top: 10px; text-align: center;">
        <asp:Button ID="btnSave" runat="server" Text="确认保存" CssClass="submit" OnClick="btnSave_Click" />&nbsp;
        <input name="重置" type="reset" class="submit" value="重置" />
    </div>
    <asp:HiddenField ID="hiddenCompanyID" runat="server" />
    </form>
</body>
</html>
