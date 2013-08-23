using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using WISD.CarERP.DBUtility;

namespace WISD.CarERP.DAL.Module
{
    public class CommonModule
    {
        #region 系统管理
        /// <summary>
        /// 获得部门信息
        /// </summary>
        public DataSet GetDeptList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select BB.DeptId,AA.CompanyName,BB.DeptName,case when BB.ParentId=0 then '父部门' else (select AA.DeptName from T_CF_Department AA where AA.DeptId=BB.ParentId) end as fDeptName,BB.Manager,BB.ManagerPhone,BB.Sort,BB.DeptNum");
            strSql.Append(" FROM T_CF_Department BB,T_CF_Company AA where BB.CompanyId=AA.CompanyId ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
        #endregion


        #region 基础数据

        #endregion


        #region 快修业务

        #endregion


        #region 汽配业务

        #endregion


        #region 应收应付

        #endregion


        #region 库存管理

        #endregion


        #region 期末核算

        #endregion


        #region 综合
        
        #endregion
    }
}
