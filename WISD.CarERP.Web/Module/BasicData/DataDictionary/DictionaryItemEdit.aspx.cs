using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WISD.CarERP.Web.Module.BasicData.DataDictionary
{
    public partial class DictionaryItemEdit : Utility.BasicPage
    {
        #region 字段
        private BLL.T_CF_ERP_DictionaryItem m_DictionaryItemBLL = new BLL.T_CF_ERP_DictionaryItem();
        private int m_DictionaryItemId;
        #endregion


        #region 事件
        /// <summary>
        /// Page_Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] == null || !int.TryParse(Request.QueryString["id"], out this.m_DictionaryItemId))
            {
                base.ShowMessageBox(350, 230, "错误提示", "<b>出现错误啦！</b>您要修改的信息不存在或参数不正确。", "back", "Error");
                return;
            }

            if (!IsPostBack)
            {
                // 验证权限
                base.CheckPermission("DictionaryItem_Edit");

                Model.T_CF_ERP_DictionaryItem  dictionaryItemModel
                    = this.m_DictionaryItemBLL.GetModel(this.m_DictionaryItemId);
                if (dictionaryItemModel != null)
                {
                    this.txtDictionaryItem.Text = dictionaryItemModel.DictionaryItem.Trim();
                    FCKeditor.Value = dictionaryItemModel.Memo;
                }
                else
                {
                    base.ShowMessageBox(350, 230, "错误提示", "<b>出现错误啦！</b>您要修改的信息不存在或参数不正确。", "back", "Error");
                }
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
                Model.T_CF_ERP_DictionaryItem dictionaryItemModel
                    = this.m_DictionaryItemBLL.GetModel(this.m_DictionaryItemId);
                dictionaryItemModel.DictionaryItem = this.txtDictionaryItem.Text.Trim();
                dictionaryItemModel.Updater = Session["UserCode"].ToString();
                dictionaryItemModel.UpdateDate = DateTime.Now;
                dictionaryItemModel.Memo = FCKeditor.Value.ToString().Trim();
                this.m_DictionaryItemBLL.Update(dictionaryItemModel);
                ShowMessageBox("修改成功！", "DictionaryItemList.aspx", "Success");
            }
            catch (Exception ex)
            {
                base.ShowMessageBox(350, 230, "错误提示", "<b>出现错误啦！</b>" + ex.Message.ToString(), "back", "Error");
            }
        }
        #endregion

    }
}