using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WISD.CarERP.Web.Module.BasicData.DataDictionary
{
    public partial class DictionaryItemList : Utility.BasicPage
    {
        #region 字段
        private BLL.T_CF_ERP_DictionaryItem m_DictionaryItemBLL = new BLL.T_CF_ERP_DictionaryItem();

        private int m_CurrentPageIndex;    // 当前页
        private int m_PageCount;    // 总条数
        private string m_Keywords = "";    // 分页传递查询条件
        public readonly int m_PageSize = 12;    // 每页显示条数
        #region 备注
        // 确保页面中的服务器控件完成功能后，绑定数据，否则会导致分页异常。
        // 异常详述：
        // 服务器控件会触发页面Page_Load方法，
        // 服务器控件触发的类的实例与第一次加载的类的实例不是同一实例，
        // 所以m_PageCount会被初始化为0，导致大量数据却只有一个分页的异常。
        // 第二种解决办法：
        // 将m_PageCount变为静态变量，这样即使两个实例不一致，但m_PageCount数据一致。
        // 但这样会导致全局记忆，即用户关闭该页面，但信息仍然保存，下次打开时，就会产生冲突。
        #endregion
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
        /// Page_Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    // 验证权限
                    base.CheckPermission("DictionaryItem_List");

                    // 绑定数据
                    this.BindReapterForPageLoad();
                }
            }
            catch (Exception exception)
            {
                base.ShowMessageBox(350, 230, "错误提示", "<b>出现错误啦！</b>" + exception.Message.ToString(), "back", "Error");
            }
        }


        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lbtnDel_Click(object sender, EventArgs e)
        {
            try
            {
                this.BatchDelete();
            }
            catch (Exception exception)
            {
                base.ShowMessageBox(350, 230, "错误提示", "<b>出现错误啦！</b>" + exception.Message.ToString(), "back", "Error");
            }
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
            DataTable dataTable = this.m_DictionaryItemBLL.GetList("1=1").Tables[0];

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
                    this.m_DictionaryItemBLL.Delete(id);
                }
            }
            base.ShowMessageBox("批量删除成功啦！", "", "Success");
            this.BindReapterForPageLoad();
        }
        #endregion
    }
}