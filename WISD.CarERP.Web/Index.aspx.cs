using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WISD.CarERP.Web
{
    public partial class Index : Utility.BasicPage
    {
        #region 字段
        private string m_TopMenu = string.Empty;
        private string m_LeftMenu = string.Empty;
        #endregion


        #region 属性
        /// <summary>
        /// TopMenu
        /// </summary>
        public string TopMenu
        {
            get { return m_TopMenu; }
            set { m_TopMenu = value; }
        }


        /// <summary>
        /// LeftMenu
        /// </summary>
        public string LeftMenu
        {
            get { return m_LeftMenu; }
            set { m_LeftMenu = value; }
        }
        #endregion


        #region 事件
        /// <summary>
        /// 加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                try
                {
                    lblUserName.Text = Session["UserName"].ToString();

                    this.SetTopMenu();
                    this.SetLeftMenu();
                }
                catch
                { }
            }
        }


        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lbtnExit_Click(object sender, EventArgs e)
        {
            try
            {
                Session["UserName"] = null;
                Response.Redirect("login.aspx");
            }
            catch (Exception ex)
            { }
        }


        /// <summary>
        /// 设置TopMenu
        /// </summary>
        private void SetTopMenu()
        {
            StringBuilder topMenu = new StringBuilder();
            topMenu.Append("<li onclick=\"tabs(1);\"><a href=\"/Module/SystemManage/CompanyManage/CompanyManageList.aspx\" target=\"sysMain\"><span>系统管理</span></a></li>");
            topMenu.Append("<li onclick=\"tabs(2);\"><a href=\"/Module/BasicData/DataDictionary/DictionaryItemList.aspx\" target=\"sysMain\"><span>基础数据</span></a></li>");
            topMenu.Append("<li onclick=\"tabs(3);\"><a href=\"\" target=\"sysMain\"><span>快修业务</span></a></li>");
            topMenu.Append("<li onclick=\"tabs(4);\"><a href=\"\" target=\"sysMain\"><span>汽配业务</span></a></li>");
            topMenu.Append("<li onclick=\"tabs(5);\"><a href=\"\" target=\"sysMain\"><span>应收应付</span></a></li>");
            topMenu.Append("<li onclick=\"tabs(6);\"><a href=\"\" target=\"sysMain\"><span>库存管理</span></a></li>");
            topMenu.Append("<li onclick=\"tabs(7);\"><a href=\"\" target=\"sysMain\"><span>期末核算</span></a></li>");
            
            this.m_TopMenu = topMenu.ToString();
        }


        /// <summary>
        /// 设置LeftMenu
        /// </summary>
        private void SetLeftMenu()
        {
            StringBuilder leftMenu = new StringBuilder();
            leftMenu.Append("<div class=\"left_menu\">");
            leftMenu.Append("<ul>");
            leftMenu.Append("<li><a href=\"/Module/SystemManage/CompanyManage/CompanyManageList.aspx\" target=\"sysMain\">公司管理</a></li>");
            leftMenu.Append("<li><a href=\"/Module/SystemManage/DeptManage/DeptManageList.aspx\" target=\"sysMain\">部门管理</a></li>");
            leftMenu.Append("<li><a href=\"/Module/SystemManage/UserManage/UserManageList.aspx\" target=\"sysMain\">职员管理</a></li>");
            leftMenu.Append("<li><a href=\"/Module/SystemManage/RoleManage/RoleManageList.aspx\" target=\"sysMain\">权限管理</a></li>");
            leftMenu.Append("</ul>");
            leftMenu.Append("</div>");

            leftMenu.Append("<div class=\"left_menu\">");
            leftMenu.Append("<ul>");
            leftMenu.Append("<li><a href=\"/Module/SystemManage/CompanyManage/CompanyManageList.aspx\" target=\"sysMain\">公司管理</a></li>");
            leftMenu.Append("<li><a href=\"/Module/SystemManage/DeptManage/DeptManageList.aspx\" target=\"sysMain\">部门管理</a></li>");
            leftMenu.Append("<li><a href=\"/Module/SystemManage/UserManage/UserManageList.aspx\" target=\"sysMain\">职员管理</a></li>");
            leftMenu.Append("<li><a href=\"/Module/SystemManage/RoleManage/RoleManageList.aspx\" target=\"sysMain\">权限管理</a></li>");
            leftMenu.Append("</ul>");
            leftMenu.Append("</div>");

            leftMenu.Append("<div class=\"left_menu\">");
            leftMenu.Append("<ul>");
            leftMenu.Append("<li><a href=\"/Module/BasicData/DataDictionary/DictionaryItemList.aspx\" target=\"sysMain\">数据字典</a></li>");
            leftMenu.Append("</ul>");
            leftMenu.Append("</div>");

            leftMenu.Append("<div class=\"left_menu\">");
            leftMenu.Append("<ul>");
            leftMenu.Append("<li><a href=\"\" target=\"sysMain\">委托修理单</a></li>");
            leftMenu.Append("<li><a href=\"\" target=\"sysMain\">派工单</a></li>");
            leftMenu.Append("<li><a href=\"\" target=\"sysMain\">维修领料</a></li>");
            leftMenu.Append("<li><a href=\"\" target=\"sysMain\">委托修理单</a></li>");
            leftMenu.Append("<li><a href=\"\" target=\"sysMain\">完工审核</a></li>");
            leftMenu.Append("</ul>");
            leftMenu.Append("</div>");

            leftMenu.Append("<div class=\"left_menu\">");
            leftMenu.Append("<ul>");
            leftMenu.Append("<li><a href=\"\" target=\"sysMain\">采购订单</a></li>");
            leftMenu.Append("<li><a href=\"\" target=\"sysMain\">采购入库单</a></li>");
            leftMenu.Append("<li><a href=\"\" target=\"sysMain\">采购退货单</a></li>");
            leftMenu.Append("<li><a href=\"\" target=\"sysMain\">销售订单</a></li>");
            leftMenu.Append("<li><a href=\"\" target=\"sysMain\">销售单</a></li>");
            leftMenu.Append("<li><a href=\"\" target=\"sysMain\">销售退货单</a></li>");
            leftMenu.Append("</ul>");
            leftMenu.Append("</div>");

            leftMenu.Append("<div class=\"left_menu\">");
            leftMenu.Append("<ul>");
            leftMenu.Append("<li><a href=\"\" target=\"sysMain\">应收总账</a></li>");
            leftMenu.Append("<li><a href=\"\" target=\"sysMain\">应收明细账</a></li>");
            leftMenu.Append("<li><a href=\"\" target=\"sysMain\">应付总账</a></li>");
            leftMenu.Append("<li><a href=\"\" target=\"sysMain\">应付明细账</a></li>");
            leftMenu.Append("</ul>");
            leftMenu.Append("</div>");

            leftMenu.Append("<div class=\"left_menu\">");
            leftMenu.Append("<ul>");
            leftMenu.Append("<li><a href=\"\" target=\"sysMain\">库存查询</a></li>");
            leftMenu.Append("<li><a href=\"\" target=\"sysMain\">滞销查询</a></li>");
            leftMenu.Append("<li><a href=\"\" target=\"sysMain\">调拨单</a></li>");
            leftMenu.Append("</ul>");
            leftMenu.Append("</div>");

            leftMenu.Append("<div class=\"left_menu\">");
            leftMenu.Append("<ul>");
            leftMenu.Append("<li><a href=\"\" target=\"sysMain\">业务核算期间</a></li>");
            leftMenu.Append("<li><a href=\"\" target=\"sysMain\">仓库未确定单据</a></li>");
            leftMenu.Append("<li><a href=\"\" target=\"sysMain\">期间成本价管理</a></li>");
            leftMenu.Append("</ul>");
            leftMenu.Append("</div>");
            this.m_LeftMenu = leftMenu.ToString();
        }

        #endregion
    }
}
