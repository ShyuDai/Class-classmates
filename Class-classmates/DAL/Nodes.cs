using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:Nodes
	/// </summary>
	public partial class Nodes
	{
		public Nodes()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Id", "Nodes"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Nodes");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.Nodes model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Nodes(");
			strSql.Append("Name,ParentId,Target,Orders,NavigateUrl,ImageUrl,IsVisible)");
			strSql.Append(" values (");
			strSql.Append("@Name,@ParentId,@Target,@Orders,@NavigateUrl,@ImageUrl,@IsVisible)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Name", SqlDbType.VarChar,50),
					new SqlParameter("@ParentId", SqlDbType.Int,4),
					new SqlParameter("@Target", SqlDbType.VarChar,50),
					new SqlParameter("@Orders", SqlDbType.Int,4),
					new SqlParameter("@NavigateUrl", SqlDbType.VarChar,300),
					new SqlParameter("@ImageUrl", SqlDbType.VarChar,300),
					new SqlParameter("@IsVisible", SqlDbType.Bit,1)};
			parameters[0].Value = model.Name;
			parameters[1].Value = model.ParentId;
			parameters[2].Value = model.Target;
			parameters[3].Value = model.Orders;
			parameters[4].Value = model.NavigateUrl;
			parameters[5].Value = model.ImageUrl;
			parameters[6].Value = model.IsVisible;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.Nodes model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Nodes set ");
			strSql.Append("Name=@Name,");
			strSql.Append("ParentId=@ParentId,");
			strSql.Append("Target=@Target,");
			strSql.Append("Orders=@Orders,");
			strSql.Append("NavigateUrl=@NavigateUrl,");
			strSql.Append("ImageUrl=@ImageUrl,");
			strSql.Append("IsVisible=@IsVisible");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Name", SqlDbType.VarChar,50),
					new SqlParameter("@ParentId", SqlDbType.Int,4),
					new SqlParameter("@Target", SqlDbType.VarChar,50),
					new SqlParameter("@Orders", SqlDbType.Int,4),
					new SqlParameter("@NavigateUrl", SqlDbType.VarChar,300),
					new SqlParameter("@ImageUrl", SqlDbType.VarChar,300),
					new SqlParameter("@IsVisible", SqlDbType.Bit,1),
					new SqlParameter("@Id", SqlDbType.Int,4)};
			parameters[0].Value = model.Name;
			parameters[1].Value = model.ParentId;
			parameters[2].Value = model.Target;
			parameters[3].Value = model.Orders;
			parameters[4].Value = model.NavigateUrl;
			parameters[5].Value = model.ImageUrl;
			parameters[6].Value = model.IsVisible;
			parameters[7].Value = model.Id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Nodes ");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string Idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Nodes ");
			strSql.Append(" where Id in ("+Idlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.Nodes GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,Name,ParentId,Target,Orders,NavigateUrl,ImageUrl,IsVisible from Nodes ");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Id;

			Maticsoft.Model.Nodes model=new Maticsoft.Model.Nodes();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.Nodes DataRowToModel(DataRow row)
		{
			Maticsoft.Model.Nodes model=new Maticsoft.Model.Nodes();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["Name"]!=null)
				{
					model.Name=row["Name"].ToString();
				}
				if(row["ParentId"]!=null && row["ParentId"].ToString()!="")
				{
					model.ParentId=int.Parse(row["ParentId"].ToString());
				}
				if(row["Target"]!=null)
				{
					model.Target=row["Target"].ToString();
				}
				if(row["Orders"]!=null && row["Orders"].ToString()!="")
				{
					model.Orders=int.Parse(row["Orders"].ToString());
				}
				if(row["NavigateUrl"]!=null)
				{
					model.NavigateUrl=row["NavigateUrl"].ToString();
				}
				if(row["ImageUrl"]!=null)
				{
					model.ImageUrl=row["ImageUrl"].ToString();
				}
				if(row["IsVisible"]!=null && row["IsVisible"].ToString()!="")
				{
					if((row["IsVisible"].ToString()=="1")||(row["IsVisible"].ToString().ToLower()=="true"))
					{
						model.IsVisible=true;
					}
					else
					{
						model.IsVisible=false;
					}
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,Name,ParentId,Target,Orders,NavigateUrl,ImageUrl,IsVisible ");
			strSql.Append(" FROM Nodes ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" Id,Name,ParentId,Target,Orders,NavigateUrl,ImageUrl,IsVisible ");
			strSql.Append(" FROM Nodes ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM Nodes ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.Id desc");
			}
			strSql.Append(")AS Row, T.*  from Nodes T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "Nodes";
			parameters[1].Value = "Id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod
		public DataSet GetListOnExt(string strSql)
		{
			return DbHelperSQL.Query(strSql.ToString());
		}
		#endregion  ExtensionMethod
	}
}

