using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// News:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class News
	{
		public News()
		{}
		#region Model
		private int _id;
		private string _name;
		private int? _fk_newstype_id;
		private string _contents;
		private int? _fk_users_id;
		private DateTime? _addtime;
		/// <summary>
		/// 新闻编号
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 新闻标题
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 新闻类别
		/// </summary>
		public int? Fk_NewsType_Id
		{
			set{ _fk_newstype_id=value;}
			get{return _fk_newstype_id;}
		}
		/// <summary>
		/// 新闻内容
		/// </summary>
		public string Contents
		{
			set{ _contents=value;}
			get{return _contents;}
		}
		/// <summary>
		/// 发布用户
		/// </summary>
		public int? Fk_Users_Id
		{
			set{ _fk_users_id=value;}
			get{return _fk_users_id;}
		}
		/// <summary>
		/// 发布时间
		/// </summary>
		public DateTime? AddTime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		#endregion Model

	}
}

