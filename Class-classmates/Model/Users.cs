using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// Users:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Users
	{
		public Users()
		{}
		#region Model
		private int _id;
		private string _name;
		private string _password;
		private string _truename;
		private string _sex;
		private string _phone;
		private string _photo;
		private string _email;
		private DateTime? _birthday;
		private bool _isactivity;
		private int? _fk_roles_id;
		/// <summary>
		/// 编号
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 帐号
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 密码
		/// </summary>
		public string Password
		{
			set{ _password=value;}
			get{return _password;}
		}
		/// <summary>
		/// 姓名
		/// </summary>
		public string TrueName
		{
			set{ _truename=value;}
			get{return _truename;}
		}
		/// <summary>
		/// 性别
		/// </summary>
		public string Sex
		{
			set{ _sex=value;}
			get{return _sex;}
		}
		/// <summary>
		/// 电话
		/// </summary>
		public string Phone
		{
			set{ _phone=value;}
			get{return _phone;}
		}
		/// <summary>
		/// 照片
		/// </summary>
		public string Photo
		{
			set{ _photo=value;}
			get{return _photo;}
		}
		/// <summary>
		/// 邮箱
		/// </summary>
		public string Email
		{
			set{ _email=value;}
			get{return _email;}
		}
		/// <summary>
		/// 生日
		/// </summary>
		public DateTime? Birthday
		{
			set{ _birthday=value;}
			get{return _birthday;}
		}
		/// <summary>
		/// 是否激活
		/// </summary>
		public bool IsActivity
		{
			set{ _isactivity=value;}
			get{return _isactivity;}
		}
		/// <summary>
		/// 角色名称
		/// </summary>
		public int? Fk_Roles_Id
		{
			set{ _fk_roles_id=value;}
			get{return _fk_roles_id;}
		}
		#endregion Model

	}
}

