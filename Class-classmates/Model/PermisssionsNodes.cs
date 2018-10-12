using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// PermisssionsNodes:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PermisssionsNodes
	{
		public PermisssionsNodes()
		{}
		#region Model
		private int _id;
		private int? _fk_permissions_id;
		private int? _fk_nodes_id;
		/// <summary>
		/// 编号
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 权限编号
		/// </summary>
		public int? Fk_Permissions_Id
		{
			set{ _fk_permissions_id=value;}
			get{return _fk_permissions_id;}
		}
		/// <summary>
		/// 节点编号
		/// </summary>
		public int? Fk_Nodes_Id
		{
			set{ _fk_nodes_id=value;}
			get{return _fk_nodes_id;}
		}
		#endregion Model

	}
}

