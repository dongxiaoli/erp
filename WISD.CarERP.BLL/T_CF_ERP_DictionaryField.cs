using System;
using System.Data;
using System.Collections.Generic;

namespace WISD.CarERP.BLL
{
	/// <summary>
	/// 字典弹性栏位表
	/// </summary>
	public partial class T_CF_ERP_DictionaryField
	{
		private readonly WISD.CarERP.DAL.T_CF_ERP_DictionaryField dal=new WISD.CarERP.DAL.T_CF_ERP_DictionaryField();
		public T_CF_ERP_DictionaryField()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int DictionaryFieldId)
		{
			return dal.Exists(DictionaryFieldId);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(WISD.CarERP.Model.T_CF_ERP_DictionaryField model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(WISD.CarERP.Model.T_CF_ERP_DictionaryField model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int DictionaryFieldId)
		{
			
			return dal.Delete(DictionaryFieldId);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string DictionaryFieldIdlist )
		{
			return dal.DeleteList(DictionaryFieldIdlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public WISD.CarERP.Model.T_CF_ERP_DictionaryField GetModel(int DictionaryFieldId)
		{
			
			return dal.GetModel(DictionaryFieldId);
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<WISD.CarERP.Model.T_CF_ERP_DictionaryField> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<WISD.CarERP.Model.T_CF_ERP_DictionaryField> DataTableToList(DataTable dt)
		{
			List<WISD.CarERP.Model.T_CF_ERP_DictionaryField> modelList = new List<WISD.CarERP.Model.T_CF_ERP_DictionaryField>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				WISD.CarERP.Model.T_CF_ERP_DictionaryField model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new WISD.CarERP.Model.T_CF_ERP_DictionaryField();
					if(dt.Rows[n]["DictionaryFieldId"]!=null && dt.Rows[n]["DictionaryFieldId"].ToString()!="")
					{
						model.DictionaryFieldId=int.Parse(dt.Rows[n]["DictionaryFieldId"].ToString());
					}
					if(dt.Rows[n]["DictionaryItemId"]!=null && dt.Rows[n]["DictionaryItemId"].ToString()!="")
					{
						model.DictionaryItemId=int.Parse(dt.Rows[n]["DictionaryItemId"].ToString());
					}
					if(dt.Rows[n]["DictionaryField"]!=null && dt.Rows[n]["DictionaryField"].ToString()!="")
					{
					model.DictionaryField=dt.Rows[n]["DictionaryField"].ToString();
					}
					if(dt.Rows[n]["Creator"]!=null && dt.Rows[n]["Creator"].ToString()!="")
					{
					model.Creator=dt.Rows[n]["Creator"].ToString();
					}
					if(dt.Rows[n]["CreateDate"]!=null && dt.Rows[n]["CreateDate"].ToString()!="")
					{
						model.CreateDate=DateTime.Parse(dt.Rows[n]["CreateDate"].ToString());
					}
					if(dt.Rows[n]["Updater"]!=null && dt.Rows[n]["Updater"].ToString()!="")
					{
					model.Updater=dt.Rows[n]["Updater"].ToString();
					}
					if(dt.Rows[n]["UpdateDate"]!=null && dt.Rows[n]["UpdateDate"].ToString()!="")
					{
						model.UpdateDate=DateTime.Parse(dt.Rows[n]["UpdateDate"].ToString());
					}
					if(dt.Rows[n]["Status"]!=null && dt.Rows[n]["Status"].ToString()!="")
					{
						model.Status=int.Parse(dt.Rows[n]["Status"].ToString());
					}
					if(dt.Rows[n]["Memo"]!=null && dt.Rows[n]["Memo"].ToString()!="")
					{
					model.Memo=dt.Rows[n]["Memo"].ToString();
					}
					if(dt.Rows[n]["Memo1"]!=null && dt.Rows[n]["Memo1"].ToString()!="")
					{
					model.Memo1=dt.Rows[n]["Memo1"].ToString();
					}
					if(dt.Rows[n]["Memo2"]!=null && dt.Rows[n]["Memo2"].ToString()!="")
					{
					model.Memo2=dt.Rows[n]["Memo2"].ToString();
					}
					if(dt.Rows[n]["Memo3"]!=null && dt.Rows[n]["Memo3"].ToString()!="")
					{
					model.Memo3=dt.Rows[n]["Memo3"].ToString();
					}
					if(dt.Rows[n]["Memo4"]!=null && dt.Rows[n]["Memo4"].ToString()!="")
					{
					model.Memo4=dt.Rows[n]["Memo4"].ToString();
					}
					if(dt.Rows[n]["Memo5"]!=null && dt.Rows[n]["Memo5"].ToString()!="")
					{
					model.Memo5=dt.Rows[n]["Memo5"].ToString();
					}
					if(dt.Rows[n]["Memo6"]!=null && dt.Rows[n]["Memo6"].ToString()!="")
					{
					model.Memo6=dt.Rows[n]["Memo6"].ToString();
					}
					if(dt.Rows[n]["Memo7"]!=null && dt.Rows[n]["Memo7"].ToString()!="")
					{
					model.Memo7=dt.Rows[n]["Memo7"].ToString();
					}
					if(dt.Rows[n]["Memo8"]!=null && dt.Rows[n]["Memo8"].ToString()!="")
					{
					model.Memo8=dt.Rows[n]["Memo8"].ToString();
					}
					modelList.Add(model);
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  Method
	}
}

