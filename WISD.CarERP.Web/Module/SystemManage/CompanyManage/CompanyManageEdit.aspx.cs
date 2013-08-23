using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WISD.CarERP.BLL;
using System.Data;

namespace WISD.CarERP.Web.Module.SystemManage.CompanyManage
{
    public partial class CompanyManageEdit : Utility.BasicPage
    {
        #region 字段
        private T_CF_Company m_CF_Company = new T_CF_Company();
        private int m_CompanyId;
        #endregion


        #region 事件
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int selectIndex = 0;
                if (Request.QueryString["id"] == null || !int.TryParse(Request.QueryString["id"], out this.m_CompanyId))
                {
                    hiddenCompanyID.Value = "";
                }
                else
                {
                    hiddenCompanyID.Value = m_CompanyId.ToString();

                    // 赋值
                    WISD.CarERP.Model.T_CF_Company companyModel
                        = this.m_CF_Company.GetModel(this.m_CompanyId);
                    if (companyModel != null)
                    {
                        selectIndex = int.Parse(companyModel.ParentId.ToString());
                        txtCompanyName.Text = companyModel.CompanyName.Trim();
                        txtContacter.Text = companyModel.Contacter.Trim();
                        txtContacterPhone.Text = companyModel.ContacterPhone.Trim();
                        txtCompanyAddress.Text = companyModel.CompanyAddress.Trim();
                        txtSort.Text = companyModel.Sort.ToString();
                    }
                }
                ddlParent.Items.Clear();
                ddlParent.Items.Add(new ListItem("父公司", "0"));
                DataTable dt = this.m_CF_Company.GetAllList().Tables[0];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ddlParent.Items.Add(new ListItem(dt.Rows[i]["CompanyName"].ToString(), dt.Rows[i]["CompanyId"].ToString()));
                }
                ddlParent.SelectedIndex = selectIndex;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string ret = "新增成功";
                WISD.CarERP.Model.T_CF_Company companyModel;
                if (!string.IsNullOrEmpty(hiddenCompanyID.Value))
                {
                    companyModel = this.m_CF_Company.GetModel(int.Parse(hiddenCompanyID.Value));
                }
                else
                {
                    companyModel = new Model.T_CF_Company();
                    companyModel.Memo = "";
                    companyModel.Memo1 = "";
                    companyModel.Memo2 = "";
                    companyModel.Memo3 = "";
                    companyModel.Memo4 = "";
                    companyModel.Memo5 = "";
                    companyModel.Memo6 = "";
                    companyModel.Memo7 = "";
                    companyModel.Memo8 = "";
                    companyModel.Status = 1;
                }
                companyModel.CompanyName = txtCompanyName.Text.Trim();
                companyModel.Contacter = txtContacter.Text.Trim();
                companyModel.ContacterPhone = txtContacterPhone.Text.Trim();
                companyModel.CompanyAddress = txtCompanyAddress.Text.Trim();
                companyModel.Sort = int.Parse(txtSort.Text.Trim());
                companyModel.Creator = Session["UserCode"].ToString();
                companyModel.CreateDate = DateTime.Now;
                companyModel.Updater = Session["UserCode"].ToString();
                companyModel.UpdateDate = DateTime.Now;
                companyModel.ParentId = int.Parse(ddlParent.SelectedItem.Value);

                if (!string.IsNullOrEmpty(hiddenCompanyID.Value))
                {
                    this.m_CF_Company.Update(companyModel);
                    ret = "修改成功";
                }
                else
                {
                    this.m_CF_Company.Add(companyModel);
                }
                Response.Redirect("CompanyManageList.aspx");
            }
            catch (Exception ex)
            {
                base.ShowMessageBox(350, 230, "错误提示", "<b>出现错误啦！</b>" + ex.Message.ToString(), "back", "Error");
            }
        }
        #endregion
    }
}