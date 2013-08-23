using System;
namespace WISD.CarERP.Model
{
	/// <summary>
	/// 公司信息表
	/// </summary>
	[Serializable]
	public partial class T_CF_Company
	{
		public T_CF_Company()
		{}
		#region Model
		private int _companyid;
		private string _companyname;
		private int? _parentid;
		private string _contacter;
		private string _contacterphone;
		private string _companyaddress;
		private int? _sort;
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
		/// 公司Id
		/// </summary>
		public int CompanyId
		{
			set{ _companyid=value;}
			get{return _companyid;}
		}
		/// <summary>
		/// 公司名
		/// </summary>
		public string CompanyName
		{
			set{ _companyname=value;}
			get{return _companyname;}
		}
		/// <summary>
		/// 父公司Id(外键，T_CF_Company)
		/// </summary>
		public int? ParentId
		{
			set{ _parentid=value;}
			get{return _parentid;}
		}
		/// <summary>
		/// 联系人
		/// </summary>
		public string Contacter
		{
			set{ _contacter=value;}
			get{return _contacter;}
		}
		/// <summary>
		/// 联系人电话
		/// </summary>
		public string ContacterPhone
		{
			set{ _contacterphone=value;}
			get{return _contacterphone;}
		}
		/// <summary>
		/// 公司地址
		/// </summary>
		public string CompanyAddress
		{
			set{ _companyaddress=value;}
			get{return _companyaddress;}
		}
		/// <summary>
		/// 排序
		/// </summary>
		public int? Sort
		{
			set{ _sort=value;}
			get{return _sort;}
		}
		/// <summary>
		/// 创建者
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
		/// 修改者
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

