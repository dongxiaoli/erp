using System;
namespace WISD.CarERP.Model
{
	/// <summary>
	/// 用户信息表
	/// </summary>
	[Serializable]
	public partial class T_CF_User
	{
		public T_CF_User()
		{}
		#region Model
		private int _userid;
		private string _usercode;
		private string _password;
		private string _username;
		private int? _state;
		private int? _creatorid;
		private DateTime? _createtime;
		private int? _updaterid;
		private DateTime? _updatetime;
		private string _remarks;
		private int? _usertype;
		private string _userpermission;
		private bool _islock;
		private int? _shopid;
		private int? _deptid;
		private int? _companyid;
		/// <summary>
		/// 用户表主键
		/// </summary>
		public int UserID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 登录帐户
		/// </summary>
		public string UserCode
		{
			set{ _usercode=value;}
			get{return _usercode;}
		}
		/// <summary>
		/// 登录密码
		/// </summary>
		public string Password
		{
			set{ _password=value;}
			get{return _password;}
		}
		/// <summary>
		/// IM名称，用于显示IM的人员列表。
		/// </summary>
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 数据状态(0:删除 1:正常)
		/// </summary>
		public int? State
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
		/// 创建者
		/// </summary>
		public int? CreatorID
		{
			set{ _creatorid=value;}
			get{return _creatorid;}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime? CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		/// <summary>
		/// 修改者
		/// </summary>
		public int? UpdaterID
		{
			set{ _updaterid=value;}
			get{return _updaterid;}
		}
		/// <summary>
		/// 修改时间
		/// </summary>
		public DateTime? UpdateTime
		{
			set{ _updatetime=value;}
			get{return _updatetime;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string Remarks
		{
			set{ _remarks=value;}
			get{return _remarks;}
		}
		/// <summary>
		/// 用户角色（外键，T_CF_UserRole）
		/// </summary>
		public int? UserType
		{
			set{ _usertype=value;}
			get{return _usertype;}
		}
		/// <summary>
		/// 用户权限（此字段不用）
		/// </summary>
		public string UserPermission
		{
			set{ _userpermission=value;}
			get{return _userpermission;}
		}
		/// <summary>
		/// True : 正常 False : 锁定
		/// </summary>
		public bool IsLock
		{
			set{ _islock=value;}
			get{return _islock;}
		}
		/// <summary>
		/// 特约商户ID(外键 T_CF_OA_Shop)
		/// </summary>
		public int? ShopID
		{
			set{ _shopid=value;}
			get{return _shopid;}
		}
		/// <summary>
		/// 所属部门(外键,T_CF_Department)
		/// </summary>
		public int? DeptId
		{
			set{ _deptid=value;}
			get{return _deptid;}
		}
		/// <summary>
		/// 所属公司(外键,T_CF_Company)
		/// </summary>
		public int? CompanyId
		{
			set{ _companyid=value;}
			get{return _companyid;}
		}
		#endregion Model

	}
}

