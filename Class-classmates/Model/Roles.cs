using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// Roles:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Roles
	{
		public Roles()
		{}
		#region Model
		private int _id;
		private string _name;
		private int? _fk_permissions_id;
		/// <summary>
		/// 编号
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 角色名称
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 权限名称
		/// </summary>
		public int? Fk_Permissions_Id
		{
			set{ _fk_permissions_id=value;}
			get{return _fk_permissions_id;}
		}
		#endregion Model

	}
}

