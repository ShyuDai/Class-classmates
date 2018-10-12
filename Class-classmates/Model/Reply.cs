using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// Reply:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Reply
	{
		public Reply()
		{}
		#region Model
		private int _id;
		private int? _fk_leaveword_id;
		private string _contents;
		private int? _fk_users_id;
		private DateTime? _addtimes;
		/// <summary>
		/// 回复编号
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 留言编号
		/// </summary>
		public int? Fk_Leaveword_Id
		{
			set{ _fk_leaveword_id=value;}
			get{return _fk_leaveword_id;}
		}
		/// <summary>
		/// 回复内容
		/// </summary>
		public string Contents
		{
			set{ _contents=value;}
			get{return _contents;}
		}
		/// <summary>
		/// 回复用户
		/// </summary>
		public int? Fk_Users_Id
		{
			set{ _fk_users_id=value;}
			get{return _fk_users_id;}
		}
		/// <summary>
		/// 回复时间
		/// </summary>
		public DateTime? AddTimes
		{
			set{ _addtimes=value;}
			get{return _addtimes;}
		}
		#endregion Model

	}
}

