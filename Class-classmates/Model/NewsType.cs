using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// NewsType:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class NewsType
	{
		public NewsType()
		{}
		#region Model
		private int _id;
		private string _name;
		/// <summary>
		/// 新闻类别编号
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 类别名称
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		#endregion Model

	}
}

