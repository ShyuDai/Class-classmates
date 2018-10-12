using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// Nodes:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Nodes
	{
		public Nodes()
		{}
		#region Model
		private int _id;
		private string _name;
		private int? _parentid;
		private string _target;
		private int? _orders;
		private string _navigateurl;
		private string _imageurl;
		private bool _isvisible;
		/// <summary>
		/// 节点编号
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 节点名称
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 父节点编号
		/// </summary>
		public int? ParentId
		{
			set{ _parentid=value;}
			get{return _parentid;}
		}
		/// <summary>
		/// 位置
		/// </summary>
		public string Target
		{
			set{ _target=value;}
			get{return _target;}
		}
		/// <summary>
		/// 排序
		/// </summary>
		public int? Orders
		{
			set{ _orders=value;}
			get{return _orders;}
		}
		/// <summary>
		/// 指向页面
		/// </summary>
		public string NavigateUrl
		{
			set{ _navigateurl=value;}
			get{return _navigateurl;}
		}
		/// <summary>
		/// 图片路径
		/// </summary>
		public string ImageUrl
		{
			set{ _imageurl=value;}
			get{return _imageurl;}
		}
		/// <summary>
		/// 是否可见
		/// </summary>
		public bool IsVisible
		{
			set{ _isvisible=value;}
			get{return _isvisible;}
		}
		#endregion Model

	}
}

