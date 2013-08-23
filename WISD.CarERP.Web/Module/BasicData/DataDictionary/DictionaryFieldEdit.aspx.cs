using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WISD.CarERP.Web.Module.BasicData.DataDictionary
{
    public partial class DictionaryFieldEdit : Utility.BasicPage
    {
        #region 字段
        private BLL.T_CF_ERP_DictionaryField m_DictionaryFieldBLL = new BLL.T_CF_ERP_DictionaryField();
        private int m_DictionaryItemId;
        private int m_DictionaryFieldId;
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
                if (Request.QueryString["id"] == null || !int.TryParse(Request.QueryString["id"], out this.m_DictionaryFieldId) ||
                    Request.QueryString["DictionaryItemId"] == null || !int.TryParse(Request.QueryString["DictionaryItemId"], out this.m_DictionaryItemId))
                {
                    base.ShowMessageBox(350, 230, "错误提示", "<b>出现错误啦！</b>您要修改的信息不存在或参数不正确。", "back", "Error");
                    return;
                }

                if (!IsPostBack)
                {
                    // 验证权限
                    base.CheckPermission("DictionaryField_Edit");

                    Model.T_CF_ERP_DictionaryField dictionaryFieldModel = this.m_DictionaryFieldBLL.GetModel(this.m_DictionaryFieldId);
                    if (dictionaryFieldModel != null)
                    {
                        this.txtDictionaryField.Text = dictionaryFieldModel.DictionaryField;
                        FCKeditor.Value = dictionaryFieldModel.Memo;
                    }
                    else
                    {
                        base.ShowMessageBox(350, 230, "错误提示", "<b>出现错误啦！</b>您要修改的信息不存在或参数不正确。", "back", "Error");
                    }
                }
            }
            catch (Exception exception)
            {
                base.ShowMessageBox(350, 230, "错误提示", "<b>出现错误啦！</b>" + exception.Message.ToString(), "back", "Error");
            }
        }


        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Model.T_CF_ERP_DictionaryField dictionaryFieldModel = this.m_DictionaryFieldBLL.GetModel(this.m_DictionaryFieldId);
                dictionaryFieldModel.DictionaryField = this.txtDictionaryField.Text.Trim();
                dictionaryFieldModel.Updater = Session["UserCode"].ToString();
                dictionaryFieldModel.UpdateDate = DateTime.Now;
                dictionaryFieldModel.Memo = FCKeditor.Value.ToString().Trim();
                this.m_DictionaryFieldBLL.Update(dictionaryFieldModel);
                ShowMessageBox("修改成功！", "DictionaryFieldList.aspx?id=" + this.m_DictionaryItemId.ToString(), "Success");
            }
            catch (Exception exception)
            {
                base.ShowMessageBox(350, 230, "错误提示", "<b>出现错误啦！</b>" + exception.Message.ToString(), "back", "Error");
            }
        }
        #endregion


    }
}