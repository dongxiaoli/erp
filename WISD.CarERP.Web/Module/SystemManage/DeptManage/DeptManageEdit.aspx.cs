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
    public partial class DeptManageEdit : System.Web.UI.Page
    {
        #region 字段
        private T_CF_Department m_CF_Depart = new T_CF_Department();
        private T_CF_Company m_CF_Company = new T_CF_Company();
        private int m_DepartId;
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
                int selectDepartIndex = 0;
                int selectCompanyID = 0;
                if (Request.QueryString["id"] == null || !int.TryParse(Request.QueryString["id"], out this.m_DepartId))
                {
                    hiddenDepatID.Value = "";
                }
                else
                {
                    hiddenDepatID.Value = m_DepartId.ToString();

                    // 赋值
                    WISD.CarERP.Model.T_CF_Department departModel
                        = this.m_CF_Depart.GetModel(this.m_DepartId);
                    if (departModel != null)
                    {
                        selectDepartIndex = int.Parse(departModel.ParentId.ToString());
                        selectCompanyID = departModel.CompanyId;
                        txtDepartName.Text = departModel.DeptName.Trim();
                        txtManager.Text = departModel.Manager.Trim();
                        txtManagerPhone.Text = departModel.ManagerPhone.Trim();
                        txtSort.Text = departModel.Sort.ToString();
                    }
                }
                ddlParent.Items.Clear();
                ddlParent.Items.Add(new ListItem("父部门", "0"));
                DataTable dt = this.m_CF_Depart.GetAllList().Tables[0];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ddlParent.Items.Add(new ListItem(dt.Rows[i]["DeptName"].ToString(), dt.Rows[i]["DeptId"].ToString()));
                }
                ddlParent.SelectedIndex = selectDepartIndex;

                DataTable dtCompany = this.m_CF_Company.GetAllList().Tables[0];
                ddlCompany.DataTextField = "CompanyName";
                ddlCompany.DataValueField = "CompanyId";
                ddlCompany.DataSource = dtCompany;
                ddlCompany.DataBind();

                ddlCompany.SelectedIndex = selectCompanyID;
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
                WISD.CarERP.Model.T_CF_Department deptModel;
                if (!string.IsNullOrEmpty(hiddenDepatID.Value))
                {
                    deptModel = this.m_CF_Depart.GetModel(int.Parse(hiddenDepatID.Value));
                }
                else
                {
                    deptModel = new Model.T_CF_Department();
                    deptModel.Memo = "";
                    deptModel.Memo1 = "";
                    deptModel.Memo2 = "";
                    deptModel.Memo3 = "";
                    deptModel.Memo4 = "";
                    deptModel.Memo5 = "";
                    deptModel.Memo6 = "";
                    deptModel.Memo7 = "";
                    deptModel.Memo8 = "";
                    deptModel.Status = 1;
                }
                deptModel.CompanyId = int.Parse(ddlCompany.SelectedItem.Value);
                deptModel.DeptName = this.txtDepartName.Text.Trim();
                //deptModel.DeptNum = txtContacterPhone.Text.Trim();
                deptModel.Manager = this.txtManager.Text.Trim();
                deptModel.ManagerPhone = this.txtManagerPhone.Text.Trim();
                deptModel.Sort = int.Parse(txtSort.Text.Trim());
                deptModel.Creator = Session["UserCode"].ToString();
                deptModel.CreateDate = DateTime.Now;
                deptModel.Updater = Session["UserCode"].ToString();
                deptModel.UpdateDate = DateTime.Now;
                deptModel.ParentId = int.Parse(ddlParent.SelectedItem.Value);

                if (!string.IsNullOrEmpty(hiddenDepatID.Value))
                {
                    this.m_CF_Depart.Update(deptModel);
                    ret = "修改成功";
                }
                else
                {
                    this.m_CF_Depart.Add(deptModel);
                }
                Response.Redirect("DeptManageList.aspx");
            }
            catch (Exception ex)
            {
            }
        }
        #endregion


    }
}