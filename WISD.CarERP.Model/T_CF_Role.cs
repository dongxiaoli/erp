using System;
namespace WISD.CarERP.Model
{
	/// <summary>
	/// 角色权限表
	/// </summary>
	[Serializable]
	public partial class T_CF_Role
	{
		public T_CF_Role()
		{}
		#region Model
		private int _roleid;
		private string _rolename;
		private string _menupermission;
		private string _actionpermission;
		private string _datapermission;
		private string _creator;
		private DateTime? _createdate;
		private string _updater;
		private DateTime? _updatedate;
		private int? _status;
		private string _memo;
		private string _memo1;
		private string _memo2;
		private string _memo3;
		private string _memo4;
		private string _memo5;
		private string _memo6;
		private string _memo7;
		private string _memo8;
		/// <summary>
		/// 角色Id
		/// </summary>
		public int RoleId
		{
			set{ _roleid=value;}
			get{return _roleid;}
		}
		/// <summary>
		/// 角色名
		/// </summary>
		public string RoleName
		{
			set{ _rolename=value;}
			get{return _rolename;}
		}
		/// <summary>
		/// 外键(TBL_S_Memu)
		/// </summary>
		public string MenuPermission
		{
			set{ _menupermission=value;}
			get{return _menupermission;}
		}
		/// <summary>
		/// 定义页面操作权限，例：Add/Update/Del
		/// </summary>
		public string ActionPermission
		{
			set{ _actionpermission=value;}
			get{return _actionpermission;}
		}
		/// <summary>
		/// 定义页面数据权限：1、只可查询本部门数据；2、可操作本部门数据；3、只可查询本人数据
		/// </summary>
		public string DataPermission
		{
			set{ _datapermission=value;}
			get{return _datapermission;}
		}
		/// <summary>
		/// 创建人
		/// </summary>
		public string Creator
		{
			set{ _creator=value;}
			get{return _creator;}
		}
		/// <summary>
		/// 创建日期
		/// </summary>
		public DateTime? CreateDate
		{
			set{ _createdate=value;}
			get{return _createdate;}
		}
		/// <summary>
		/// 修改人
		/// </summary>
		public string Updater
		{
			set{ _updater=value;}
			get{return _updater;}
		}
		/// <summary>
		/// 修改日期
		/// </summary>
		public DateTime? UpdateDate
		{
			set{ _updatedate=value;}
			get{return _updatedate;}
		}
		/// <summary>
		/// 数据状态(0:删除 1:正常)
		/// </summary>
		public int? Status
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string Memo
		{
			set{ _memo=value;}
			get{return _memo;}
		}
		/// <summary>
		/// 拓展字段1
		/// </summary>
		public string Memo1
		{
			set{ _memo1=value;}
			get{return _memo1;}
		}
		/// <summary>
		/// 拓展字段2
		/// </summary>
		public string Memo2
		{
			set{ _memo2=value;}
			get{return _memo2;}
		}
		/// <summary>
		/// 拓展字段3
		/// </summary>
		public string Memo3
		{
			set{ _memo3=value;}
			get{return _memo3;}
		}
		/// <summary>
		/// 拓展字段4
		/// </summary>
		public string Memo4
		{
			set{ _memo4=value;}
			get{return _memo4;}
		}
		/// <summary>
		/// 拓展字段5
		/// </summary>
		public string Memo5
		{
			set{ _memo5=value;}
			get{return _memo5;}
		}
		/// <summary>
		/// 拓展字段6
		/// </summary>
		public string Memo6
		{
			set{ _memo6=value;}
			get{return _memo6;}
		}
		/// <summary>
		/// 拓展字段7
		/// </summary>
		public string Memo7
		{
			set{ _memo7=value;}
			get{return _memo7;}
		}
		/// <summary>
		/// 拓展字段8
		/// </summary>
		public string Memo8
		{
			set{ _memo8=value;}
			get{return _memo8;}
		}
		#endregion Model

	}
}

