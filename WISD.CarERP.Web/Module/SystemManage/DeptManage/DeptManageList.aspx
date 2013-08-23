<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeptManageList.aspx.cs" Inherits="WISD.CarERP.Web.Module.SystemManage.DeptManage.DeptManageList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>公司管理</title>
    <link href="../../../CSS/Style.css" rel="stylesheet" type="text/css" />
    <link href="../../../CSS/Pagination.css" rel="stylesheet" type="text/css" />
    <script src="../../../JS/jquery-1.7.2.js" type="text/javascript"></script>
    <script src="../../../JS/jquery.pagination.js" type="text/javascript"></script>
    <script src="../../../JS/CheckAll.js" type="text/javascript"></script>
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
<body style="padding: 10px;">
    <form id="form1" runat="server">
    <div class="navigation">
        <span class="add"><a href="DeptManageEdit.aspx">新增部门</a></span><b>您当前的位置：首页 &gt;
            部门管理 </b>
    </div>
    <div class="spClear">
    </div>
    <asp:Repeater ID="rptList" runat="server">
        <HeaderTemplate>
            <table width="100%" border="0" cellspacing="0" cellpadding="0" class="msgtable">
                <tr>
                    <th width="6%">
                        选择
                    </th>
                    <th align="left" width="10%">
                        部门ID
                    </th>
                     <th align="left" width="15%">
                        部门名称
                    </th>
                     <th align="left" width="15%">
                        父部门名称
                    </th>
                     <th align="left" width="10%">
                        公司名称
                    </th>
                    <th align="left" width="10%">
                        联系人
                    </th>
                    <th align="left" width="15%">
                        联系人电话
                    </th>
                    <th align="left" width="8%">
                        编辑
                    </th>
                </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td align="center">
                    <asp:CheckBox ID="chkId" CssClass="checkall" runat="server" />
                </td>
                <td>
                    <asp:Label ID="lblId" runat="server" Text='<%#Eval("DeptId")%>' Style="display: none;"></asp:Label>
                    <a href="DeptManageEdit.aspx?id=<%#Eval("DeptId") %>">
                        <%#Eval("DeptId")%></a>
                </td>
                 <td>
                    <%#Eval("DeptName")%>
                </td>
                 <td>
                    <%#Eval("fDeptName")%>
                </td>
                <td>
                    <%#Eval("CompanyName")%>
                </td>               
                <td>
                    <%#Eval("Manager")%>
                </td>
                  <td>
                    <%#Eval("ManagerPhone")%>
                </td>
                <td>
                    <a href="DeptManageEdit.aspx?id=<%#Eval("DeptId") %>">编辑</a>
                </td>
            </tr>
        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>
    <div class="spClear">
    </div>
    <div style="line-height: 30px; height: 30px;">
        <div id="Pagination" class="right flickr">
        </div>
        <div class="left">
            <span class="btn_all" onclick="checkAll(this);">全选</span> <span class="btn_bg">
                <asp:LinkButton ID="lbtnDel" runat="server" 
                OnClientClick="return confirm( '确定要删除这些记录吗？ ');" onclick="lbtnDel_Click" >删 除</asp:LinkButton>
            </span>
        </div>
    </div>
    </form>
</body>
</html>
