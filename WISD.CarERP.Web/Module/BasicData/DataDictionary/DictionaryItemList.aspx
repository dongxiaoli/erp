<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DictionaryItemList.aspx.cs" Inherits="WISD.CarERP.Web.Module.BasicData.DataDictionary.DictionaryItemList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>会员卡类型管理</title>
    <link rel="stylesheet" type="text/css" href="../../../CSS/Style.css" />
    <link rel="stylesheet" type="text/css" href="../../../CSS/Pagination.css" />
    <script type="text/javascript" src="../../../JS/jquery-1.7.2.js"></script>
    <script type="text/javascript" src="../../../JS/jquery.pagination.js"></script>
    <script type="text/javascript" src="../../../JS/CheckAll.js"></script>
    <script type="text/javascript">
        $(function() {
            //分页参数设置
            $("#Pagination").pagination(<%=PageCount %>, {
                callback: pageselectCallback,
                prev_text: "« 上一页",
                next_text: "下一页 »",
                items_per_page:<%=PageSize %>,
		        num_display_entries:3,
		        current_page:<%=CurrentPageIndex %>,
		        num_edge_entries:2,
		        link_to:"?page=__id__<%=Keywords %>"
           });
        });
        
        function pageselectCallback(page_id, jq) {
            //alert(page_id); 回调函数
        }
        
        $(function() {
            $(".msgtable tr:nth-child(odd)").addClass("tr_bg"); //隔行变色
            $(".msgtable tr").hover(
			    function() {
			        $(this).addClass("tr_hover_col");
			    },
			    function() {
			        $(this).removeClass("tr_hover_col");
			    }
		    );
        });
    </script>
</head>
<body style="padding:10px;">
    <form id="form1" runat="server">
        <div class="navigation"><span class="add"><a href="DictionaryItemAdd.aspx">新增数据字典项</a></span><b>您当前的位置：首页 &gt; 数据字典项管理 </b></div>
        <div class="spClear"></div>
        <asp:Repeater ID="rptList" runat="server">
            <HeaderTemplate>
                <table width="100%" border="0" cellspacing="0" cellpadding="0" class="msgtable">
                  <tr>
                    <th width="6%">选择</th>
                    <th align="left">数据字典</th>
                    <th align="left" width="8%">修改者</th>
                    <th align="left" width="15%">修改日期</th>
                    <th align="left" width="10%">栏位管理</th>
                    <th align="left" width="10%">内容管理</th>
                    <th align="left" width="8%">编辑</th>
                  </tr>
              </HeaderTemplate>
              <ItemTemplate>
                  <tr>
                    <td align="center"><asp:CheckBox ID="chkId" CssClass="checkall" runat="server" /></td>
                    <td><asp:Label ID="lblId" runat="server" Text='<%#Eval("DictionaryItemId")%>' style="display:none;"></asp:Label>
                    <a href="DictionaryItemEdit.aspx?id=<%#Eval("DictionaryItemId") %>"><%#Eval("DictionaryItem")%></a></td>
                     <td><%#Eval("Updater")%></td>
                    <td><%#Eval("UpdateDate")%></td>
                    <td><a href="DictionaryFieldList.aspx?id=<%#Eval("DictionaryItemId") %>">栏位管理</a></td>
                    <td><a href="DictionaryDataList.aspx?id=<%#Eval("DictionaryItemId") %>">内容管理</a></td>
                    <td><a href="DictionaryItemEdit.aspx?id=<%#Eval("DictionaryItemId") %>">编辑</a></td>
                  </tr>
              </ItemTemplate>
              <FooterTemplate>
                </table>
              </FooterTemplate>
          </asp:Repeater>
        
        <div class="spClear"></div>
        <div style="line-height:30px;height:30px;">
            <div id="Pagination" class="right flickr"></div>
            <div class="left">
                <span class="btn_all" onclick="checkAll(this);">全选</span>
                <span class="btn_bg">
                  <asp:LinkButton ID="lbtnDel" runat="server" 
                    OnClientClick="return confirm( '确定要删除这些记录吗？ ');" onclick="lbtnDel_Click">删 除</asp:LinkButton>
                </span>
            </div>
	    </div>
    </form>
</body>
</html>
