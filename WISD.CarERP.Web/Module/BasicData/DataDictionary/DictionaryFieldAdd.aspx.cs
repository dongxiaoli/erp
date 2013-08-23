using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WISD.CarERP.Web.Module.BasicData.DataDictionary
{
    public partial class DictionaryFieldAdd : Utility.BasicPage
    {
        #region 字段
        private BLL.T_CF_ERP_DictionaryField m_DictionaryFieldBLL = new BLL.T_CF_ERP_DictionaryField();
        private int m_DictionaryItemId;
        #endregion


        #region 属性
        /// <summary>
        /// 字典数据项
        /// </summary>
        public int DictionaryItemId
        {
            get { return m_DictionaryItemId; }
            set { m_DictionaryItemId = value; }
        }
        #endregion


        #region 方法
        /// <summary>
        /// Page_Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Request.QueryString["id"] == null || !int.TryParse(Request.QueryString["id"], out this.m_DictionaryItemId))
                {
                    base.ShowMessageBox(350, 230, "错误提示", "<b>出现错误啦！</b>您要修改的信息不存在或参数不正确。", "back", "Error");
                    return;
                }

                if (!IsPostBack)
                {
                    // 验证权限
                    base.CheckPermission("DictionaryField_Add");
                }
            }
            catch (Exception exception)
            {
                base.ShowMessageBox(350, 230, "错误提示", "<b>出现错误啦！</b>" + exception.Message.ToString(), "back", "Error");
            }
        }


        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Model.T_CF_ERP_DictionaryField dictionaryFieldModel = new Model.T_CF_ERP_DictionaryField();
                dictionaryFieldModel.DictionaryItemId = this.m_DictionaryItemId;
                dictionaryFieldModel.DictionaryField = this.txtDictionaryField.Text.Trim();
                dictionaryFieldModel.Creator = Session["UserCode"].ToString();
                dictionaryFieldModel.CreateDate = DateTime.Now;
                dictionaryFieldModel.Updater = Session["UserCode"].ToString();
                dictionaryFieldModel.UpdateDate = DateTime.Now;
                dictionaryFieldModel.Memo = FCKeditor.Value.ToString().Trim();
                this.m_DictionaryFieldBLL.Add(dictionaryFieldModel);
                ShowMessageBox("新增成功！", "DictionaryFieldList.aspx?id=" + this.m_DictionaryItemId.ToString(), "Success");
            }
            catch (Exception exception)
            {
                base.ShowMessageBox(350, 230, "错误提示", "<b>出现错误啦！</b>" + exception.Message.ToString(), "back", "Error");
            }
        }
        #endregion

    }
}