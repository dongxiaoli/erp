using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace WISD.CarERP.BLL.Module.SystemManage.DeptManage
{
    public class DeptManageModule
    {
        private DAL.Module.CommonModule m_CommonModule = new DAL.Module.CommonModule();


        /// <summary>
        /// 获得部门信息
        /// </summary>
        public DataSet GetDeptList(string strWhere)
        {
            return m_CommonModule.GetDeptList(strWhere);
        }

    }
}
