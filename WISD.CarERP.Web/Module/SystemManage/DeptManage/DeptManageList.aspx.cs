using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WISD.CarERP.BLL;
using System.Data;

namespace WISD.CarERP.Web.Module.SystemManage.DeptManage
{
    public partial class DeptManageList : System.Web.UI.Page
    {
        #region 字段
        private T_CF_Department m_CF_Department = new T_CF_Department();
        private BLL.Module.SystemManage.DeptManage.DeptManageModule m_DeptManageModule 
            = new BLL.Module.SystemManage.DeptManage.DeptManageModule();

        private int m_CurrentPageIndex;    // 当前页
        private int m_PageCount;    // 总条数
        private string m_Keywords = "";    // 分页传递查询条件
        public readonly int m_PageSize = 12;    // 每页显示条数
        #endregion


        #region 属性
        /// <summary>
        /// 当前页
        /// </summary>
        public int CurrentPageIndex
        {
            get { return this.m_CurrentPageIndex; }
            set { this.m_CurrentPageIndex = value; }
        }


        /// <summary>
        /// 总条数
        /// </summary>
        public int PageCount
        {
            get { return this.m_PageCount; }
            set { this.m_PageCount = value; }
        }


        /// <summary>
        /// 分页查询条件
        /// </summary>
        public string Keywords
        {
            get { return this.m_Keywords; }
            set { this.m_Keywords = value; }
        }


        /// <summary>
        /// 每页显示条数
        /// </summary>
        public int PageSize
        {
            get { return this.m_PageSize; }
        }
        #endregion


        #region 事件
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                // 绑定数据
                this.BindReapterForPageLoad();
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lbtnDel_Click(object sender, EventArgs e)
        {
            this.BatchDelete();
        }
        #endregion


        #region 方法
        /// <summary>
        /// 绑定数据
        /// </summary>
        private void BindReapterForPageLoad()
        {
            if (Request.QueryString["page"] != null)
            {
                this.m_CurrentPageIndex = Convert.ToInt32(Request.QueryString["page"]);
            }
            else
            {
                this.m_CurrentPageIndex = 0;
            }

            // 查询数据库
            DataTable dataTable = this.m_DeptManageModule.GetDeptList("").Tables[0];

            // 绑定
            this.BindReapter(dataTable);
        }

        /// <summary>
        /// BindReapter
        /// </summary>
        /// <param name="dt"></param>
        private void BindReapter(DataTable dt)
        {
            //分页
            PagedDataSource pagedDataSource = new PagedDataSource();
            pagedDataSource.DataSource = dt.DefaultView;
            pagedDataSource.AllowPaging = true;
            pagedDataSource.PageSize = this.m_PageSize;
            pagedDataSource.CurrentPageIndex = this.m_CurrentPageIndex;
            this.m_PageCount = dt.Rows.Count;

            //绑定数据
            rptList.DataSource = pagedDataSource;
            rptList.DataBind();
        }

        /// <summary>
        /// 批量删除
        /// </summary>
        private void BatchDelete()
        {
            // 删除
            for (int i = 0; i < rptList.Items.Count; i++)
            {
                int id = Convert.ToInt32(((Label)rptList.Items[i].FindControl("lblId")).Text);
                CheckBox checkBox = (CheckBox)rptList.Items[i].FindControl("chkId");
                if (checkBox.Checked)
                {
                    this.m_CF_Department.Delete(id);
                }
            }
            //base.ShowMessageBox("批量删除成功啦！", "", "Success");
            this.BindReapterForPageLoad();
        }
        #endregion
    }
}