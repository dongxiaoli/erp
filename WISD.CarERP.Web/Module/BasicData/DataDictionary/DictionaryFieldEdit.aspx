<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DictionaryFieldEdit.aspx.cs" Inherits="WISD.CarERP.Web.Module.BasicData.DataDictionary.DictionaryFieldEdit" %>
<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
    <head id="Head1" runat="server">
        <title>修改数据字典栏位</title>
        <link rel="stylesheet" type="text/css" href="../../../CSS/Style.css" />
        <script type="text/javascript" src="../../../JS/jquery-1.7.2.js"></script>
        <script type="text/javascript" src="../../../JS/jquery.validate.min.js"></script>
        <script type="text/javascript" src="../../../JS/cursorfocus.js"></script>
        <script type="text/javascript" src="../../../JS/messages_cn.js"></script>
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
<body style="padding:10px;">
    <form id="form1" runat="server">
        <div class="navigation">
          <span class="back"><a href="DictionaryFieldList.aspx?id=<%=DictionaryItemId %>">返回列表</a></span><b>您当前的位置：首页 &gt; 数据字典管理 &gt; 数据字典栏位管理 &gt; 修改数据字典栏位 </b>
        </div>
        <div style="padding-bottom:10px;"></div>
        <table width="100%" border="0" cellspacing="0" cellpadding="0" class="msgtable">
            <tr>
                <th colspan="2" align="left">修改数据字典栏位</th>
            </tr>
            <tr>
                <td width="15%" align="right">弹性栏位：</td>
                <td width="85%">
                    <asp:TextBox ID="txtDictionaryField" runat="server" CssClass="input w380 required" 
                        maxlength="250" minlength="1" HintTitle="弹性栏位" HintInfo="弹性栏位"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td width="15%" align="right">备注：</td>
                <td width="85%">
                <FCKeditorV2:FCKeditor ID="FCKeditor" runat="server" BasePath="../../../Package/FCKedit/" Height="400px" ToolbarSet="ROY" Width="100%" Value=""></FCKeditorV2:FCKeditor>
                </td>
            </tr>
        </table>
        <div style="margin-top:10px;text-align:center;">
            <asp:Button ID="btnSave" runat="server" Text="确认保存" CssClass="submit" 
                onclick="btnSave_Click" />&nbsp;
            <input name="重置" type="reset" class="submit" value="重置" />
        </div>
    </form>
</body>
</html>
