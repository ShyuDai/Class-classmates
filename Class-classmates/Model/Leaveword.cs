using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// Leaveword:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Leaveword
	{
		public Leaveword()
		{}
		#region Model
		private int _id;
		private int? _fk_news_id;
		private string _contents;
		private int? _fk_users_id;
		private DateTime? _addtimes;
		/// <summary>
		/// 留言编号
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 新闻标题
		/// </summary>
		public int? Fk_News_Id
		{
			set{ _fk_news_id=value;}
			get{return _fk_news_id;}
		}
		/// <summary>
		/// 留言内容
		/// </summary>
		public string Contents
		{
			set{ _contents=value;}
			get{return _contents;}
		}
		/// <summary>
		/// 留言用户
		/// </summary>
		public int? FK_Users_Id
		{
			set{ _fk_users_id=value;}
			get{return _fk_users_id;}
		}
		/// <summary>
		/// 留言时间
		/// </summary>
		public DateTime? AddTimes
		{
			set{ _addtimes=value;}
			get{return _addtimes;}
		}
		#endregion Model

	}
}

