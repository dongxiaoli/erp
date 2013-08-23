using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WISD.CarERP.DBUtility;
namespace WISD.CarERP.DAL
{
	/// <summary>
	/// 数据访问类:T_CF_User
	/// </summary>
	public partial class T_CF_User
	{
		public T_CF_User()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("UserID", "T_CF_User"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int UserID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_CF_User");
			strSql.Append(" where UserID=@UserID");
			SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.Int,4)
			};
			parameters[0].Value = UserID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(WISD.CarERP.Model.T_CF_User model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_CF_User(");
			strSql.Append("UserCode,Password,UserName,State,CreatorID,CreateTime,UpdaterID,UpdateTime,Remarks,UserType,UserPermission,IsLock,ShopID,DeptId,CompanyId)");
			strSql.Append(" values (");
			strSql.Append("@UserCode,@Password,@UserName,@State,@CreatorID,@CreateTime,@UpdaterID,@UpdateTime,@Remarks,@UserType,@UserPermission,@IsLock,@ShopID,@DeptId,@CompanyId)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@UserCode", SqlDbType.NVarChar,50),
					new SqlParameter("@Password", SqlDbType.NVarChar,100),
					new SqlParameter("@UserName", SqlDbType.NVarChar,100),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@CreatorID", SqlDbType.Int,4),
					new SqlParameter("@CreateTime", SqlDbType.DateTime),
					new SqlParameter("@UpdaterID", SqlDbType.Int,4),
					new SqlParameter("@UpdateTime", SqlDbType.DateTime),
					new SqlParameter("@Remarks", SqlDbType.NVarChar,1000),
					new SqlParameter("@UserType", SqlDbType.Int,4),
					new SqlParameter("@UserPermission", SqlDbType.NVarChar,1000),
					new SqlParameter("@IsLock", SqlDbType.Bit,1),
					new SqlParameter("@ShopID", SqlDbType.Int,4),
					new SqlParameter("@DeptId", SqlDbType.Int,4),
					new SqlParameter("@CompanyId", SqlDbType.Int,4)};
			parameters[0].Value = model.UserCode;
			parameters[1].Value = model.Password;
			parameters[2].Value = model.UserName;
			parameters[3].Value = model.State;
			parameters[4].Value = model.CreatorID;
			parameters[5].Value = model.CreateTime;
			parameters[6].Value = model.UpdaterID;
			parameters[7].Value = model.UpdateTime;
			parameters[8].Value = model.Remarks;
			parameters[9].Value = model.UserType;
			parameters[10].Value = model.UserPermission;
			parameters[11].Value = model.IsLock;
			parameters[12].Value = model.ShopID;
			parameters[13].Value = model.DeptId;
			parameters[14].Value = model.CompanyId;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(WISD.CarERP.Model.T_CF_User model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_CF_User set ");
			strSql.Append("UserCode=@UserCode,");
			strSql.Append("Password=@Password,");
			strSql.Append("UserName=@UserName,");
			strSql.Append("State=@State,");
			strSql.Append("CreatorID=@CreatorID,");
			strSql.Append("CreateTime=@CreateTime,");
			strSql.Append("UpdaterID=@UpdaterID,");
			strSql.Append("UpdateTime=@UpdateTime,");
			strSql.Append("Remarks=@Remarks,");
			strSql.Append("UserType=@UserType,");
			strSql.Append("UserPermission=@UserPermission,");
			strSql.Append("IsLock=@IsLock,");
			strSql.Append("ShopID=@ShopID,");
			strSql.Append("DeptId=@DeptId,");
			strSql.Append("CompanyId=@CompanyId");
			strSql.Append(" where UserID=@UserID");
			SqlParameter[] parameters = {
					new SqlParameter("@UserCode", SqlDbType.NVarChar,50),
					new SqlParameter("@Password", SqlDbType.NVarChar,100),
					new SqlParameter("@UserName", SqlDbType.NVarChar,100),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@CreatorID", SqlDbType.Int,4),
					new SqlParameter("@CreateTime", SqlDbType.DateTime),
					new SqlParameter("@UpdaterID", SqlDbType.Int,4),
					new SqlParameter("@UpdateTime", SqlDbType.DateTime),
					new SqlParameter("@Remarks", SqlDbType.NVarChar,1000),
					new SqlParameter("@UserType", SqlDbType.Int,4),
					new SqlParameter("@UserPermission", SqlDbType.NVarChar,1000),
					new SqlParameter("@IsLock", SqlDbType.Bit,1),
					new SqlParameter("@ShopID", SqlDbType.Int,4),
					new SqlParameter("@DeptId", SqlDbType.Int,4),
					new SqlParameter("@CompanyId", SqlDbType.Int,4),
					new SqlParameter("@UserID", SqlDbType.Int,4)};
			parameters[0].Value = model.UserCode;
			parameters[1].Value = model.Password;
			parameters[2].Value = model.UserName;
			parameters[3].Value = model.State;
			parameters[4].Value = model.CreatorID;
			parameters[5].Value = model.CreateTime;
			parameters[6].Value = model.UpdaterID;
			parameters[7].Value = model.UpdateTime;
			parameters[8].Value = model.Remarks;
			parameters[9].Value = model.UserType;
			parameters[10].Value = model.UserPermission;
			parameters[11].Value = model.IsLock;
			parameters[12].Value = model.ShopID;
			parameters[13].Value = model.DeptId;
			parameters[14].Value = model.CompanyId;
			parameters[15].Value = model.UserID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int UserID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_CF_User ");
			strSql.Append(" where UserID=@UserID");
			SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.Int,4)
			};
			parameters[0].Value = UserID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string UserIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_CF_User ");
			strSql.Append(" where UserID in ("+UserIDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public WISD.CarERP.Model.T_CF_User GetModel(int UserID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 UserID,UserCode,Password,UserName,State,CreatorID,CreateTime,UpdaterID,UpdateTime,Remarks,UserType,UserPermission,IsLock,ShopID,DeptId,CompanyId from T_CF_User ");
			strSql.Append(" where UserID=@UserID");
			SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.Int,4)
			};
			parameters[0].Value = UserID;

			WISD.CarERP.Model.T_CF_User model=new WISD.CarERP.Model.T_CF_User();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["UserID"]!=null && ds.Tables[0].Rows[0]["UserID"].ToString()!="")
				{
					model.UserID=int.Parse(ds.Tables[0].Rows[0]["UserID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["UserCode"]!=null && ds.Tables[0].Rows[0]["UserCode"].ToString()!="")
				{
					model.UserCode=ds.Tables[0].Rows[0]["UserCode"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Password"]!=null && ds.Tables[0].Rows[0]["Password"].ToString()!="")
				{
					model.Password=ds.Tables[0].Rows[0]["Password"].ToString();
				}
				if(ds.Tables[0].Rows[0]["UserName"]!=null && ds.Tables[0].Rows[0]["UserName"].ToString()!="")
				{
					model.UserName=ds.Tables[0].Rows[0]["UserName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["State"]!=null && ds.Tables[0].Rows[0]["State"].ToString()!="")
				{
					model.State=int.Parse(ds.Tables[0].Rows[0]["State"].ToString());
				}
				if(ds.Tables[0].Rows[0]["CreatorID"]!=null && ds.Tables[0].Rows[0]["CreatorID"].ToString()!="")
				{
					model.CreatorID=int.Parse(ds.Tables[0].Rows[0]["CreatorID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["CreateTime"]!=null && ds.Tables[0].Rows[0]["CreateTime"].ToString()!="")
				{
					model.CreateTime=DateTime.Parse(ds.Tables[0].Rows[0]["CreateTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["UpdaterID"]!=null && ds.Tables[0].Rows[0]["UpdaterID"].ToString()!="")
				{
					model.UpdaterID=int.Parse(ds.Tables[0].Rows[0]["UpdaterID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["UpdateTime"]!=null && ds.Tables[0].Rows[0]["UpdateTime"].ToString()!="")
				{
					model.UpdateTime=DateTime.Parse(ds.Tables[0].Rows[0]["UpdateTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Remarks"]!=null && ds.Tables[0].Rows[0]["Remarks"].ToString()!="")
				{
					model.Remarks=ds.Tables[0].Rows[0]["Remarks"].ToString();
				}
				if(ds.Tables[0].Rows[0]["UserType"]!=null && ds.Tables[0].Rows[0]["UserType"].ToString()!="")
				{
					model.UserType=int.Parse(ds.Tables[0].Rows[0]["UserType"].ToString());
				}
				if(ds.Tables[0].Rows[0]["UserPermission"]!=null && ds.Tables[0].Rows[0]["UserPermission"].ToString()!="")
				{
					model.UserPermission=ds.Tables[0].Rows[0]["UserPermission"].ToString();
				}
				if(ds.Tables[0].Rows[0]["IsLock"]!=null && ds.Tables[0].Rows[0]["IsLock"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["IsLock"].ToString()=="1")||(ds.Tables[0].Rows[0]["IsLock"].ToString().ToLower()=="true"))
					{
						model.IsLock=true;
					}
					else
					{
						model.IsLock=false;
					}
				}
				if(ds.Tables[0].Rows[0]["ShopID"]!=null && ds.Tables[0].Rows[0]["ShopID"].ToString()!="")
				{
					model.ShopID=int.Parse(ds.Tables[0].Rows[0]["ShopID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["DeptId"]!=null && ds.Tables[0].Rows[0]["DeptId"].ToString()!="")
				{
					model.DeptId=int.Parse(ds.Tables[0].Rows[0]["DeptId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["CompanyId"]!=null && ds.Tables[0].Rows[0]["CompanyId"].ToString()!="")
				{
					model.CompanyId=int.Parse(ds.Tables[0].Rows[0]["CompanyId"].ToString());
				}
				return model;
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select UserID,UserCode,Password,UserName,State,CreatorID,CreateTime,UpdaterID,UpdateTime,Remarks,UserType,UserPermission,IsLock,ShopID,DeptId,CompanyId ");
			strSql.Append(" FROM T_CF_User ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" UserID,UserCode,Password,UserName,State,CreatorID,CreateTime,UpdaterID,UpdateTime,Remarks,UserType,UserPermission,IsLock,ShopID,DeptId,CompanyId ");
			strSql.Append(" FROM T_CF_User ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM T_CF_User ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.UserID desc");
			}
			strSql.Append(")AS Row, T.*  from T_CF_User T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "T_CF_User";
			parameters[1].Value = "UserID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  Method
	}
}

