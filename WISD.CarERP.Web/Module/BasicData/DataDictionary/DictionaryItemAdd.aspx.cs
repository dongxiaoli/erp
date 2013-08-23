using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WISD.CarERP.Web.Module.BasicData.DataDictionary
{
    public partial class DictionaryItemAdd : Utility.BasicPage
    {
        private BLL.T_CF_ERP_DictionaryItem m_DictionaryItemBLL = new BLL.T_CF_ERP_DictionaryItem();

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
                    base.CheckPermission("DictionaryItem_Add");
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
                Model.T_CF_ERP_DictionaryItem dictionaryItemModel = new Model.T_CF_ERP_DictionaryItem();
                dictionaryItemModel.DictionaryItem = this.txtDictionaryItem.Text.Trim();
                dictionaryItemModel.Creator = Session["UserCode"].ToString();
                dictionaryItemModel.CreateDate = DateTime.Now;
                dictionaryItemModel.Updater = Session["UserCode"].ToString();
                dictionaryItemModel.UpdateDate = DateTime.Now;
                dictionaryItemModel.Memo = FCKeditor.Value.ToString().Trim();
                this.m_DictionaryItemBLL.Add(dictionaryItemModel);
                ShowMessageBox("新增成功！", "DictionaryItemList.aspx", "Success");
            }
            catch (Exception exception)
            {
                base.ShowMessageBox(350, 230, "错误提示", "<b>出现错误啦！</b>" + exception.Message.ToString(), "back", "Error");
            }
        }


    }
}