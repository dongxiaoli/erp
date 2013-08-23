using System;
using System.Data;
using System.Collections.Generic;

namespace WISD.CarERP.BLL
{
	/// <summary>
	/// 字典数据内容表
	/// </summary>
	public partial class T_CF_ERP_DictionaryData
	{
		private readonly WISD.CarERP.DAL.T_CF_ERP_DictionaryData dal=new WISD.CarERP.DAL.T_CF_ERP_DictionaryData();
		public T_CF_ERP_DictionaryData()
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
		public bool Exists(int DictionaryDataId)
		{
			return dal.Exists(DictionaryDataId);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(WISD.CarERP.Model.T_CF_ERP_DictionaryData model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(WISD.CarERP.Model.T_CF_ERP_DictionaryData model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int DictionaryDataId)
		{
			
			return dal.Delete(DictionaryDataId);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string DictionaryDataIdlist )
		{
			return dal.DeleteList(DictionaryDataIdlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public WISD.CarERP.Model.T_CF_ERP_DictionaryData GetModel(int DictionaryDataId)
		{
			
			return dal.GetModel(DictionaryDataId);
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
		public List<WISD.CarERP.Model.T_CF_ERP_DictionaryData> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<WISD.CarERP.Model.T_CF_ERP_DictionaryData> DataTableToList(DataTable dt)
		{
			List<WISD.CarERP.Model.T_CF_ERP_DictionaryData> modelList = new List<WISD.CarERP.Model.T_CF_ERP_DictionaryData>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				WISD.CarERP.Model.T_CF_ERP_DictionaryData model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new WISD.CarERP.Model.T_CF_ERP_DictionaryData();
					if(dt.Rows[n]["DictionaryDataId"]!=null && dt.Rows[n]["DictionaryDataId"].ToString()!="")
					{
						model.DictionaryDataId=int.Parse(dt.Rows[n]["DictionaryDataId"].ToString());
					}
					if(dt.Rows[n]["DictionaryFieldId"]!=null && dt.Rows[n]["DictionaryFieldId"].ToString()!="")
					{
						model.DictionaryFieldId=int.Parse(dt.Rows[n]["DictionaryFieldId"].ToString());
					}
					if(dt.Rows[n]["DictionaryData"]!=null && dt.Rows[n]["DictionaryData"].ToString()!="")
					{
					model.DictionaryData=dt.Rows[n]["DictionaryData"].ToString();
					}
					if(dt.Rows[n]["RowId"]!=null && dt.Rows[n]["RowId"].ToString()!="")
					{
					model.RowId=dt.Rows[n]["RowId"].ToString();
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

