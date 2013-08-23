using System;
using System.Data;
using System.Collections.Generic;

namespace WISD.CarERP.BLL
{
	/// <summary>
	/// 用户信息表
	/// </summary>
	public partial class T_CF_User
	{
		private readonly WISD.CarERP.DAL.T_CF_User dal=new WISD.CarERP.DAL.T_CF_User();
		public T_CF_User()
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
		public bool Exists(int UserID)
		{
			return dal.Exists(UserID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(WISD.CarERP.Model.T_CF_User model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(WISD.CarERP.Model.T_CF_User model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int UserID)
		{
			
			return dal.Delete(UserID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string UserIDlist )
		{
			return dal.DeleteList(UserIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public WISD.CarERP.Model.T_CF_User GetModel(int UserID)
		{
			
			return dal.GetModel(UserID);
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
		public List<WISD.CarERP.Model.T_CF_User> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<WISD.CarERP.Model.T_CF_User> DataTableToList(DataTable dt)
		{
			List<WISD.CarERP.Model.T_CF_User> modelList = new List<WISD.CarERP.Model.T_CF_User>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				WISD.CarERP.Model.T_CF_User model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new WISD.CarERP.Model.T_CF_User();
					if(dt.Rows[n]["UserID"]!=null && dt.Rows[n]["UserID"].ToString()!="")
					{
						model.UserID=int.Parse(dt.Rows[n]["UserID"].ToString());
					}
					if(dt.Rows[n]["UserCode"]!=null && dt.Rows[n]["UserCode"].ToString()!="")
					{
					model.UserCode=dt.Rows[n]["UserCode"].ToString();
					}
					if(dt.Rows[n]["Password"]!=null && dt.Rows[n]["Password"].ToString()!="")
					{
					model.Password=dt.Rows[n]["Password"].ToString();
					}
					if(dt.Rows[n]["UserName"]!=null && dt.Rows[n]["UserName"].ToString()!="")
					{
					model.UserName=dt.Rows[n]["UserName"].ToString();
					}
					if(dt.Rows[n]["State"]!=null && dt.Rows[n]["State"].ToString()!="")
					{
						model.State=int.Parse(dt.Rows[n]["State"].ToString());
					}
					if(dt.Rows[n]["CreatorID"]!=null && dt.Rows[n]["CreatorID"].ToString()!="")
					{
						model.CreatorID=int.Parse(dt.Rows[n]["CreatorID"].ToString());
					}
					if(dt.Rows[n]["CreateTime"]!=null && dt.Rows[n]["CreateTime"].ToString()!="")
					{
						model.CreateTime=DateTime.Parse(dt.Rows[n]["CreateTime"].ToString());
					}
					if(dt.Rows[n]["UpdaterID"]!=null && dt.Rows[n]["UpdaterID"].ToString()!="")
					{
						model.UpdaterID=int.Parse(dt.Rows[n]["UpdaterID"].ToString());
					}
					if(dt.Rows[n]["UpdateTime"]!=null && dt.Rows[n]["UpdateTime"].ToString()!="")
					{
						model.UpdateTime=DateTime.Parse(dt.Rows[n]["UpdateTime"].ToString());
					}
					if(dt.Rows[n]["Remarks"]!=null && dt.Rows[n]["Remarks"].ToString()!="")
					{
					model.Remarks=dt.Rows[n]["Remarks"].ToString();
					}
					if(dt.Rows[n]["UserType"]!=null && dt.Rows[n]["UserType"].ToString()!="")
					{
						model.UserType=int.Parse(dt.Rows[n]["UserType"].ToString());
					}
					if(dt.Rows[n]["UserPermission"]!=null && dt.Rows[n]["UserPermission"].ToString()!="")
					{
					model.UserPermission=dt.Rows[n]["UserPermission"].ToString();
					}
					if(dt.Rows[n]["IsLock"]!=null && dt.Rows[n]["IsLock"].ToString()!="")
					{
						if((dt.Rows[n]["IsLock"].ToString()=="1")||(dt.Rows[n]["IsLock"].ToString().ToLower()=="true"))
						{
						model.IsLock=true;
						}
						else
						{
							model.IsLock=false;
						}
					}
					if(dt.Rows[n]["ShopID"]!=null && dt.Rows[n]["ShopID"].ToString()!="")
					{
						model.ShopID=int.Parse(dt.Rows[n]["ShopID"].ToString());
					}
					if(dt.Rows[n]["DeptId"]!=null && dt.Rows[n]["DeptId"].ToString()!="")
					{
						model.DeptId=int.Parse(dt.Rows[n]["DeptId"].ToString());
					}
					if(dt.Rows[n]["CompanyId"]!=null && dt.Rows[n]["CompanyId"].ToString()!="")
					{
						model.CompanyId=int.Parse(dt.Rows[n]["CompanyId"].ToString());
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

