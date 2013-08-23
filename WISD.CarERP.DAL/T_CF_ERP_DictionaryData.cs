using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using WISD.CarERP.DBUtility;
namespace WISD.CarERP.DAL
{
	/// <summary>
	/// 数据访问类:T_CF_ERP_DictionaryData
	/// </summary>
	public partial class T_CF_ERP_DictionaryData
	{
		public T_CF_ERP_DictionaryData()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("DictionaryDataId", "T_CF_ERP_DictionaryData"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int DictionaryDataId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_CF_ERP_DictionaryData");
			strSql.Append(" where DictionaryDataId=@DictionaryDataId");
			SqlParameter[] parameters = {
					new SqlParameter("@DictionaryDataId", SqlDbType.Int,4)
			};
			parameters[0].Value = DictionaryDataId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(WISD.CarERP.Model.T_CF_ERP_DictionaryData model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_CF_ERP_DictionaryData(");
			strSql.Append("DictionaryFieldId,DictionaryData,RowId,Creator,CreateDate,Updater,UpdateDate,Status,Memo,Memo1,Memo2,Memo3,Memo4,Memo5,Memo6,Memo7,Memo8)");
			strSql.Append(" values (");
			strSql.Append("@DictionaryFieldId,@DictionaryData,@RowId,@Creator,@CreateDate,@Updater,@UpdateDate,@Status,@Memo,@Memo1,@Memo2,@Memo3,@Memo4,@Memo5,@Memo6,@Memo7,@Memo8)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@DictionaryFieldId", SqlDbType.Int,4),
					new SqlParameter("@DictionaryData", SqlDbType.NVarChar,300),
					new SqlParameter("@RowId", SqlDbType.NVarChar,100),
					new SqlParameter("@Creator", SqlDbType.NVarChar,50),
					new SqlParameter("@CreateDate", SqlDbType.DateTime),
					new SqlParameter("@Updater", SqlDbType.NVarChar,50),
					new SqlParameter("@UpdateDate", SqlDbType.DateTime),
					new SqlParameter("@Status", SqlDbType.Int,4),
					new SqlParameter("@Memo", SqlDbType.NVarChar,100),
					new SqlParameter("@Memo1", SqlDbType.NVarChar,100),
					new SqlParameter("@Memo2", SqlDbType.NVarChar,100),
					new SqlParameter("@Memo3", SqlDbType.NVarChar,100),
					new SqlParameter("@Memo4", SqlDbType.NVarChar,100),
					new SqlParameter("@Memo5", SqlDbType.NVarChar,100),
					new SqlParameter("@Memo6", SqlDbType.NVarChar,100),
					new SqlParameter("@Memo7", SqlDbType.NVarChar,100),
					new SqlParameter("@Memo8", SqlDbType.NVarChar,100)};
			parameters[0].Value = model.DictionaryFieldId;
			parameters[1].Value = model.DictionaryData;
			parameters[2].Value = model.RowId;
			parameters[3].Value = model.Creator;
			parameters[4].Value = model.CreateDate;
			parameters[5].Value = model.Updater;
			parameters[6].Value = model.UpdateDate;
			parameters[7].Value = model.Status;
			parameters[8].Value = model.Memo;
			parameters[9].Value = model.Memo1;
			parameters[10].Value = model.Memo2;
			parameters[11].Value = model.Memo3;
			parameters[12].Value = model.Memo4;
			parameters[13].Value = model.Memo5;
			parameters[14].Value = model.Memo6;
			parameters[15].Value = model.Memo7;
			parameters[16].Value = model.Memo8;

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
		public bool Update(WISD.CarERP.Model.T_CF_ERP_DictionaryData model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_CF_ERP_DictionaryData set ");
			strSql.Append("DictionaryFieldId=@DictionaryFieldId,");
			strSql.Append("DictionaryData=@DictionaryData,");
			strSql.Append("RowId=@RowId,");
			strSql.Append("Creator=@Creator,");
			strSql.Append("CreateDate=@CreateDate,");
			strSql.Append("Updater=@Updater,");
			strSql.Append("UpdateDate=@UpdateDate,");
			strSql.Append("Status=@Status,");
			strSql.Append("Memo=@Memo,");
			strSql.Append("Memo1=@Memo1,");
			strSql.Append("Memo2=@Memo2,");
			strSql.Append("Memo3=@Memo3,");
			strSql.Append("Memo4=@Memo4,");
			strSql.Append("Memo5=@Memo5,");
			strSql.Append("Memo6=@Memo6,");
			strSql.Append("Memo7=@Memo7,");
			strSql.Append("Memo8=@Memo8");
			strSql.Append(" where DictionaryDataId=@DictionaryDataId");
			SqlParameter[] parameters = {
					new SqlParameter("@DictionaryFieldId", SqlDbType.Int,4),
					new SqlParameter("@DictionaryData", SqlDbType.NVarChar,300),
					new SqlParameter("@RowId", SqlDbType.NVarChar,100),
					new SqlParameter("@Creator", SqlDbType.NVarChar,50),
					new SqlParameter("@CreateDate", SqlDbType.DateTime),
					new SqlParameter("@Updater", SqlDbType.NVarChar,50),
					new SqlParameter("@UpdateDate", SqlDbType.DateTime),
					new SqlParameter("@Status", SqlDbType.Int,4),
					new SqlParameter("@Memo", SqlDbType.NVarChar,100),
					new SqlParameter("@Memo1", SqlDbType.NVarChar,100),
					new SqlParameter("@Memo2", SqlDbType.NVarChar,100),
					new SqlParameter("@Memo3", SqlDbType.NVarChar,100),
					new SqlParameter("@Memo4", SqlDbType.NVarChar,100),
					new SqlParameter("@Memo5", SqlDbType.NVarChar,100),
					new SqlParameter("@Memo6", SqlDbType.NVarChar,100),
					new SqlParameter("@Memo7", SqlDbType.NVarChar,100),
					new SqlParameter("@Memo8", SqlDbType.NVarChar,100),
					new SqlParameter("@DictionaryDataId", SqlDbType.Int,4)};
			parameters[0].Value = model.DictionaryFieldId;
			parameters[1].Value = model.DictionaryData;
			parameters[2].Value = model.RowId;
			parameters[3].Value = model.Creator;
			parameters[4].Value = model.CreateDate;
			parameters[5].Value = model.Updater;
			parameters[6].Value = model.UpdateDate;
			parameters[7].Value = model.Status;
			parameters[8].Value = model.Memo;
			parameters[9].Value = model.Memo1;
			parameters[10].Value = model.Memo2;
			parameters[11].Value = model.Memo3;
			parameters[12].Value = model.Memo4;
			parameters[13].Value = model.Memo5;
			parameters[14].Value = model.Memo6;
			parameters[15].Value = model.Memo7;
			parameters[16].Value = model.Memo8;
			parameters[17].Value = model.DictionaryDataId;

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
		public bool Delete(int DictionaryDataId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_CF_ERP_DictionaryData ");
			strSql.Append(" where DictionaryDataId=@DictionaryDataId");
			SqlParameter[] parameters = {
					new SqlParameter("@DictionaryDataId", SqlDbType.Int,4)
			};
			parameters[0].Value = DictionaryDataId;

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
		public bool DeleteList(string DictionaryDataIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_CF_ERP_DictionaryData ");
			strSql.Append(" where DictionaryDataId in ("+DictionaryDataIdlist + ")  ");
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
		public WISD.CarERP.Model.T_CF_ERP_DictionaryData GetModel(int DictionaryDataId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 DictionaryDataId,DictionaryFieldId,DictionaryData,RowId,Creator,CreateDate,Updater,UpdateDate,Status,Memo,Memo1,Memo2,Memo3,Memo4,Memo5,Memo6,Memo7,Memo8 from T_CF_ERP_DictionaryData ");
			strSql.Append(" where DictionaryDataId=@DictionaryDataId");
			SqlParameter[] parameters = {
					new SqlParameter("@DictionaryDataId", SqlDbType.Int,4)
			};
			parameters[0].Value = DictionaryDataId;

			WISD.CarERP.Model.T_CF_ERP_DictionaryData model=new WISD.CarERP.Model.T_CF_ERP_DictionaryData();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["DictionaryDataId"]!=null && ds.Tables[0].Rows[0]["DictionaryDataId"].ToString()!="")
				{
					model.DictionaryDataId=int.Parse(ds.Tables[0].Rows[0]["DictionaryDataId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["DictionaryFieldId"]!=null && ds.Tables[0].Rows[0]["DictionaryFieldId"].ToString()!="")
				{
					model.DictionaryFieldId=int.Parse(ds.Tables[0].Rows[0]["DictionaryFieldId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["DictionaryData"]!=null && ds.Tables[0].Rows[0]["DictionaryData"].ToString()!="")
				{
					model.DictionaryData=ds.Tables[0].Rows[0]["DictionaryData"].ToString();
				}
				if(ds.Tables[0].Rows[0]["RowId"]!=null && ds.Tables[0].Rows[0]["RowId"].ToString()!="")
				{
					model.RowId=ds.Tables[0].Rows[0]["RowId"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Creator"]!=null && ds.Tables[0].Rows[0]["Creator"].ToString()!="")
				{
					model.Creator=ds.Tables[0].Rows[0]["Creator"].ToString();
				}
				if(ds.Tables[0].Rows[0]["CreateDate"]!=null && ds.Tables[0].Rows[0]["CreateDate"].ToString()!="")
				{
					model.CreateDate=DateTime.Parse(ds.Tables[0].Rows[0]["CreateDate"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Updater"]!=null && ds.Tables[0].Rows[0]["Updater"].ToString()!="")
				{
					model.Updater=ds.Tables[0].Rows[0]["Updater"].ToString();
				}
				if(ds.Tables[0].Rows[0]["UpdateDate"]!=null && ds.Tables[0].Rows[0]["UpdateDate"].ToString()!="")
				{
					model.UpdateDate=DateTime.Parse(ds.Tables[0].Rows[0]["UpdateDate"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Status"]!=null && ds.Tables[0].Rows[0]["Status"].ToString()!="")
				{
					model.Status=int.Parse(ds.Tables[0].Rows[0]["Status"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Memo"]!=null && ds.Tables[0].Rows[0]["Memo"].ToString()!="")
				{
					model.Memo=ds.Tables[0].Rows[0]["Memo"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Memo1"]!=null && ds.Tables[0].Rows[0]["Memo1"].ToString()!="")
				{
					model.Memo1=ds.Tables[0].Rows[0]["Memo1"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Memo2"]!=null && ds.Tables[0].Rows[0]["Memo2"].ToString()!="")
				{
					model.Memo2=ds.Tables[0].Rows[0]["Memo2"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Memo3"]!=null && ds.Tables[0].Rows[0]["Memo3"].ToString()!="")
				{
					model.Memo3=ds.Tables[0].Rows[0]["Memo3"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Memo4"]!=null && ds.Tables[0].Rows[0]["Memo4"].ToString()!="")
				{
					model.Memo4=ds.Tables[0].Rows[0]["Memo4"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Memo5"]!=null && ds.Tables[0].Rows[0]["Memo5"].ToString()!="")
				{
					model.Memo5=ds.Tables[0].Rows[0]["Memo5"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Memo6"]!=null && ds.Tables[0].Rows[0]["Memo6"].ToString()!="")
				{
					model.Memo6=ds.Tables[0].Rows[0]["Memo6"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Memo7"]!=null && ds.Tables[0].Rows[0]["Memo7"].ToString()!="")
				{
					model.Memo7=ds.Tables[0].Rows[0]["Memo7"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Memo8"]!=null && ds.Tables[0].Rows[0]["Memo8"].ToString()!="")
				{
					model.Memo8=ds.Tables[0].Rows[0]["Memo8"].ToString();
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
			strSql.Append("select DictionaryDataId,DictionaryFieldId,DictionaryData,RowId,Creator,CreateDate,Updater,UpdateDate,Status,Memo,Memo1,Memo2,Memo3,Memo4,Memo5,Memo6,Memo7,Memo8 ");
			strSql.Append(" FROM T_CF_ERP_DictionaryData ");
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
			strSql.Append(" DictionaryDataId,DictionaryFieldId,DictionaryData,RowId,Creator,CreateDate,Updater,UpdateDate,Status,Memo,Memo1,Memo2,Memo3,Memo4,Memo5,Memo6,Memo7,Memo8 ");
			strSql.Append(" FROM T_CF_ERP_DictionaryData ");
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
			strSql.Append("select count(1) FROM T_CF_ERP_DictionaryData ");
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
				strSql.Append("order by T.DictionaryDataId desc");
			}
			strSql.Append(")AS Row, T.*  from T_CF_ERP_DictionaryData T ");
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
			parameters[0].Value = "T_CF_ERP_DictionaryData";
			parameters[1].Value = "DictionaryDataId";
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

