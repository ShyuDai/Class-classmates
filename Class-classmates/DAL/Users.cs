using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:Users
	/// </summary>
	public partial class Users
	{
		public Users()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Id", "Users"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string Name,int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Users");
			strSql.Append(" where Name=@Name and Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Name", SqlDbType.VarChar,50),
					new SqlParameter("@Id", SqlDbType.Int,4)			};
			parameters[0].Value = Name;
			parameters[1].Value = Id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.Users model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Users(");
			strSql.Append("Name,Password,TrueName,Sex,Phone,Photo,Email,Birthday,IsActivity,Fk_Roles_Id)");
			strSql.Append(" values (");
			strSql.Append("@Name,@Password,@TrueName,@Sex,@Phone,@Photo,@Email,@Birthday,@IsActivity,@Fk_Roles_Id)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Name", SqlDbType.VarChar,50),
					new SqlParameter("@Password", SqlDbType.VarChar,50),
					new SqlParameter("@TrueName", SqlDbType.VarChar,50),
					new SqlParameter("@Sex", SqlDbType.VarChar,10),
					new SqlParameter("@Phone", SqlDbType.VarChar,50),
					new SqlParameter("@Photo", SqlDbType.VarChar,100),
					new SqlParameter("@Email", SqlDbType.VarChar,50),
					new SqlParameter("@Birthday", SqlDbType.DateTime),
					new SqlParameter("@IsActivity", SqlDbType.Bit,1),
					new SqlParameter("@Fk_Roles_Id", SqlDbType.Int,4)};
			parameters[0].Value = model.Name;
			parameters[1].Value = model.Password;
			parameters[2].Value = model.TrueName;
			parameters[3].Value = model.Sex;
			parameters[4].Value = model.Phone;
			parameters[5].Value = model.Photo;
			parameters[6].Value = model.Email;
			parameters[7].Value = model.Birthday;
			parameters[8].Value = model.IsActivity;
			parameters[9].Value = model.Fk_Roles_Id;

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
		public bool Update(Maticsoft.Model.Users model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Users set ");
			strSql.Append("Password=@Password,");
			strSql.Append("TrueName=@TrueName,");
			strSql.Append("Sex=@Sex,");
			strSql.Append("Phone=@Phone,");
			strSql.Append("Photo=@Photo,");
			strSql.Append("Email=@Email,");
			strSql.Append("Birthday=@Birthday,");
			strSql.Append("IsActivity=@IsActivity,");
			strSql.Append("Fk_Roles_Id=@Fk_Roles_Id");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Password", SqlDbType.VarChar,50),
					new SqlParameter("@TrueName", SqlDbType.VarChar,50),
					new SqlParameter("@Sex", SqlDbType.VarChar,10),
					new SqlParameter("@Phone", SqlDbType.VarChar,50),
					new SqlParameter("@Photo", SqlDbType.VarChar,100),
					new SqlParameter("@Email", SqlDbType.VarChar,50),
					new SqlParameter("@Birthday", SqlDbType.DateTime),
					new SqlParameter("@IsActivity", SqlDbType.Bit,1),
					new SqlParameter("@Fk_Roles_Id", SqlDbType.Int,4),
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@Name", SqlDbType.VarChar,50)};
			parameters[0].Value = model.Password;
			parameters[1].Value = model.TrueName;
			parameters[2].Value = model.Sex;
			parameters[3].Value = model.Phone;
			parameters[4].Value = model.Photo;
			parameters[5].Value = model.Email;
			parameters[6].Value = model.Birthday;
			parameters[7].Value = model.IsActivity;
			parameters[8].Value = model.Fk_Roles_Id;
			parameters[9].Value = model.Id;
			parameters[10].Value = model.Name;

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
			strSql.Append("delete from Users ");
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
		/// 删除一条数据
		/// </summary>
		public bool Delete(string Name,int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Users ");
			strSql.Append(" where Name=@Name and Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Name", SqlDbType.VarChar,50),
					new SqlParameter("@Id", SqlDbType.Int,4)			};
			parameters[0].Value = Name;
			parameters[1].Value = Id;

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
			strSql.Append("delete from Users ");
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
		public Maticsoft.Model.Users GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,Name,Password,TrueName,Sex,Phone,Photo,Email,Birthday,IsActivity,Fk_Roles_Id from Users ");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Id;

			Maticsoft.Model.Users model=new Maticsoft.Model.Users();
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
		public Maticsoft.Model.Users DataRowToModel(DataRow row)
		{
			Maticsoft.Model.Users model=new Maticsoft.Model.Users();
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
				if(row["Password"]!=null)
				{
					model.Password=row["Password"].ToString();
				}
				if(row["TrueName"]!=null)
				{
					model.TrueName=row["TrueName"].ToString();
				}
				if(row["Sex"]!=null)
				{
					model.Sex=row["Sex"].ToString();
				}
				if(row["Phone"]!=null)
				{
					model.Phone=row["Phone"].ToString();
				}
				if(row["Photo"]!=null)
				{
					model.Photo=row["Photo"].ToString();
				}
				if(row["Email"]!=null)
				{
					model.Email=row["Email"].ToString();
				}
				if(row["Birthday"]!=null && row["Birthday"].ToString()!="")
				{
					model.Birthday=DateTime.Parse(row["Birthday"].ToString());
				}
				if(row["IsActivity"]!=null && row["IsActivity"].ToString()!="")
				{
					if((row["IsActivity"].ToString()=="1")||(row["IsActivity"].ToString().ToLower()=="true"))
					{
						model.IsActivity=true;
					}
					else
					{
						model.IsActivity=false;
					}
				}
				if(row["Fk_Roles_Id"]!=null && row["Fk_Roles_Id"].ToString()!="")
				{
					model.Fk_Roles_Id=int.Parse(row["Fk_Roles_Id"].ToString());
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
			strSql.Append("select Id,Name,Password,TrueName,Sex,Phone,Photo,Email,Birthday,IsActivity,Fk_Roles_Id ");
			strSql.Append(" FROM Users ");
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
			strSql.Append(" Id,Name,Password,TrueName,Sex,Phone,Photo,Email,Birthday,IsActivity,Fk_Roles_Id ");
			strSql.Append(" FROM Users ");
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
			strSql.Append("select count(1) FROM Users ");
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
			strSql.Append(")AS Row, T.*  from Users T ");
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
			parameters[0].Value = "Users";
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

