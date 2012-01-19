
/*
'===============================================================================
'  Generated From - CSharp_dOOdads_BusinessEntity.vbgen
' 
'  ** IMPORTANT  ** 
'  How to Generate your stored procedures:
' 
'  SQL        = SQL_StoredProcs.vbgen
'  ACCESS     = Access_StoredProcs.vbgen
'  ORACLE     = Oracle_StoredProcs.vbgen
'  FIREBIRD   = FirebirdStoredProcs.vbgen
'  POSTGRESQL = PostgreSQL_StoredProcs.vbgen
'
'  The supporting base class PostgreSqlEntity is in the Architecture directory in "dOOdads".
'  
'  This object is 'abstract' which means you need to inherit from it to be able
'  to instantiate it.  This is very easilly done. You can override properties and
'  methods in your derived class, this allows you to regenerate this class at any
'  time and not worry about overwriting custom code. 
'
'  NEVER EDIT THIS FILE.
'
'  public class YourObject :  _YourObject
'  {
'
'  }
'
'===============================================================================
*/

// Generated by MyGeneration Version # (1.1.0.0)

using System;
using System.Data;
using Npgsql;
using System.Collections;
using System.Collections.Specialized;

using MyGeneration.dOOdads;

namespace CSharp.POSTGRESQL
{
	public abstract class _tblCustomers1 : PostgreSqlEntity
	{
		public _tblCustomers1()
		{
			this.QuerySource = "tblCustomers1";
			this.MappingName = "tblCustomers1";

		}	

		//=================================================================
		//  public Overrides void AddNew()
		//=================================================================
		//
		//=================================================================
		public override void AddNew()
		{
			base.AddNew();
			
		}
		
		
		public override void FlushData()
		{
			this._whereClause = null;
			base.FlushData();
		}
		
		//=================================================================
		//  	public Function LoadAll() As Boolean
		//=================================================================
		//  Loads all of the records in the database, and sets the currentRow to the first row
		//=================================================================
		public bool LoadAll() 
		{
			ListDictionary parameters = null;
			
			return base.LoadFromSql(this.SchemaStoredProcedure + "tblCustomers1_load_all", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int ICustomerId)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.ICustomerId, ICustomerId);

		
			return base.LoadFromSql(this.SchemaStoredProcedure + "tblCustomers1_load_by_primarykey", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static NpgsqlParameter ICustomerId
			{
				get
				{
					return new NpgsqlParameter("ICustomerId", NpgsqlTypes.NpgsqlDbType.Integer, 0);
				}
			}
			
			public static NpgsqlParameter SCustomerName
			{
				get
				{
					return new NpgsqlParameter("SCustomerName", NpgsqlTypes.NpgsqlDbType.Varchar, 50);
				}
			}
			
			public static NpgsqlParameter SCustomerEmail
			{
				get
				{
					return new NpgsqlParameter("SCustomerEmail", NpgsqlTypes.NpgsqlDbType.Varchar, 50);
				}
			}
			
			public static NpgsqlParameter SCustomerPhone1
			{
				get
				{
					return new NpgsqlParameter("SCustomerPhone1", NpgsqlTypes.NpgsqlDbType.Varchar, 50);
				}
			}
			
			public static NpgsqlParameter SCustomerHistory
			{
				get
				{
					return new NpgsqlParameter("SCustomerHistory", NpgsqlTypes.NpgsqlDbType.Text, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
			public const string ICustomerId = "iCustomerId";
			public const string SCustomerName = "sCustomerName";
			public const string SCustomerEmail = "sCustomerEmail";
			public const string SCustomerPhone1 = "sCustomerPhone1";
			public const string SCustomerHistory = "sCustomerHistory";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ICustomerId] = _tblCustomers1.PropertyNames.ICustomerId;
					ht[SCustomerName] = _tblCustomers1.PropertyNames.SCustomerName;
					ht[SCustomerEmail] = _tblCustomers1.PropertyNames.SCustomerEmail;
					ht[SCustomerPhone1] = _tblCustomers1.PropertyNames.SCustomerPhone1;
					ht[SCustomerHistory] = _tblCustomers1.PropertyNames.SCustomerHistory;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
			public const string ICustomerId = "ICustomerId";
			public const string SCustomerName = "SCustomerName";
			public const string SCustomerEmail = "SCustomerEmail";
			public const string SCustomerPhone1 = "SCustomerPhone1";
			public const string SCustomerHistory = "SCustomerHistory";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ICustomerId] = _tblCustomers1.ColumnNames.ICustomerId;
					ht[SCustomerName] = _tblCustomers1.ColumnNames.SCustomerName;
					ht[SCustomerEmail] = _tblCustomers1.ColumnNames.SCustomerEmail;
					ht[SCustomerPhone1] = _tblCustomers1.ColumnNames.SCustomerPhone1;
					ht[SCustomerHistory] = _tblCustomers1.ColumnNames.SCustomerHistory;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
			public const string ICustomerId = "s_ICustomerId";
			public const string SCustomerName = "s_SCustomerName";
			public const string SCustomerEmail = "s_SCustomerEmail";
			public const string SCustomerPhone1 = "s_SCustomerPhone1";
			public const string SCustomerHistory = "s_SCustomerHistory";

		}
		#endregion		
		
		#region Properties
	
		public virtual int ICustomerId
		{
			get
			{
				return base.Getint(ColumnNames.ICustomerId);
			}
			set
			{
				base.Setint(ColumnNames.ICustomerId, value);
			}
		}

		public virtual string SCustomerName
		{
			get
			{
				return base.Getstring(ColumnNames.SCustomerName);
			}
			set
			{
				base.Setstring(ColumnNames.SCustomerName, value);
			}
		}

		public virtual string SCustomerEmail
		{
			get
			{
				return base.Getstring(ColumnNames.SCustomerEmail);
			}
			set
			{
				base.Setstring(ColumnNames.SCustomerEmail, value);
			}
		}

		public virtual string SCustomerPhone1
		{
			get
			{
				return base.Getstring(ColumnNames.SCustomerPhone1);
			}
			set
			{
				base.Setstring(ColumnNames.SCustomerPhone1, value);
			}
		}

		public virtual string SCustomerHistory
		{
			get
			{
				return base.Getstring(ColumnNames.SCustomerHistory);
			}
			set
			{
				base.Setstring(ColumnNames.SCustomerHistory, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_ICustomerId
		{
			get
			{
				return this.IsColumnNull(ColumnNames.ICustomerId) ? string.Empty : base.GetintAsString(ColumnNames.ICustomerId);
			}
			set
			{
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ICustomerId);
				else
					this.ICustomerId = base.SetintAsString(ColumnNames.ICustomerId, value);
			}
		}

		public virtual string s_SCustomerName
		{
			get
			{
				return this.IsColumnNull(ColumnNames.SCustomerName) ? string.Empty : base.GetstringAsString(ColumnNames.SCustomerName);
			}
			set
			{
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.SCustomerName);
				else
					this.SCustomerName = base.SetstringAsString(ColumnNames.SCustomerName, value);
			}
		}

		public virtual string s_SCustomerEmail
		{
			get
			{
				return this.IsColumnNull(ColumnNames.SCustomerEmail) ? string.Empty : base.GetstringAsString(ColumnNames.SCustomerEmail);
			}
			set
			{
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.SCustomerEmail);
				else
					this.SCustomerEmail = base.SetstringAsString(ColumnNames.SCustomerEmail, value);
			}
		}

		public virtual string s_SCustomerPhone1
		{
			get
			{
				return this.IsColumnNull(ColumnNames.SCustomerPhone1) ? string.Empty : base.GetstringAsString(ColumnNames.SCustomerPhone1);
			}
			set
			{
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.SCustomerPhone1);
				else
					this.SCustomerPhone1 = base.SetstringAsString(ColumnNames.SCustomerPhone1, value);
			}
		}

		public virtual string s_SCustomerHistory
		{
			get
			{
				return this.IsColumnNull(ColumnNames.SCustomerHistory) ? string.Empty : base.GetstringAsString(ColumnNames.SCustomerHistory);
			}
			set
			{
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.SCustomerHistory);
				else
					this.SCustomerHistory = base.SetstringAsString(ColumnNames.SCustomerHistory, value);
			}
		}


		#endregion		
	
		#region Where Clause
		public class WhereClause
		{
			public WhereClause(BusinessEntity entity)
			{
				this._entity = entity;
			}
			
			public TearOffWhereParameter TearOff
			{
				get
				{
					if(_tearOff == null)
					{
						_tearOff = new TearOffWhereParameter(this);
					}

					return _tearOff;
				}
			}

			#region TearOff's
			public class TearOffWhereParameter
			{
				public TearOffWhereParameter(WhereClause clause)
				{
					this._clause = clause;
				}
				
				
				public WhereParameter ICustomerId
				{
					get
					{
						WhereParameter where = new WhereParameter(ColumnNames.ICustomerId, Parameters.ICustomerId);
						this._clause._entity.Query.AddWhereParameter(where);
						return where;
					}
				}

				public WhereParameter SCustomerName
				{
					get
					{
						WhereParameter where = new WhereParameter(ColumnNames.SCustomerName, Parameters.SCustomerName);
						this._clause._entity.Query.AddWhereParameter(where);
						return where;
					}
				}

				public WhereParameter SCustomerEmail
				{
					get
					{
						WhereParameter where = new WhereParameter(ColumnNames.SCustomerEmail, Parameters.SCustomerEmail);
						this._clause._entity.Query.AddWhereParameter(where);
						return where;
					}
				}

				public WhereParameter SCustomerPhone1
				{
					get
					{
						WhereParameter where = new WhereParameter(ColumnNames.SCustomerPhone1, Parameters.SCustomerPhone1);
						this._clause._entity.Query.AddWhereParameter(where);
						return where;
					}
				}

				public WhereParameter SCustomerHistory
				{
					get
					{
						WhereParameter where = new WhereParameter(ColumnNames.SCustomerHistory, Parameters.SCustomerHistory);
						this._clause._entity.Query.AddWhereParameter(where);
						return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter ICustomerId
			{
				get
				{
					if(_ICustomerId_W == null)
					{
						_ICustomerId_W = TearOff.ICustomerId;
					}
					return _ICustomerId_W;
				}
			}

			public WhereParameter SCustomerName
			{
				get
				{
					if(_SCustomerName_W == null)
					{
						_SCustomerName_W = TearOff.SCustomerName;
					}
					return _SCustomerName_W;
				}
			}

			public WhereParameter SCustomerEmail
			{
				get
				{
					if(_SCustomerEmail_W == null)
					{
						_SCustomerEmail_W = TearOff.SCustomerEmail;
					}
					return _SCustomerEmail_W;
				}
			}

			public WhereParameter SCustomerPhone1
			{
				get
				{
					if(_SCustomerPhone1_W == null)
					{
						_SCustomerPhone1_W = TearOff.SCustomerPhone1;
					}
					return _SCustomerPhone1_W;
				}
			}

			public WhereParameter SCustomerHistory
			{
				get
				{
					if(_SCustomerHistory_W == null)
					{
						_SCustomerHistory_W = TearOff.SCustomerHistory;
					}
					return _SCustomerHistory_W;
				}
			}

			private WhereParameter _ICustomerId_W = null;
			private WhereParameter _SCustomerName_W = null;
			private WhereParameter _SCustomerEmail_W = null;
			private WhereParameter _SCustomerPhone1_W = null;
			private WhereParameter _SCustomerHistory_W = null;

			public void WhereClauseReset()
			{
				_ICustomerId_W = null;
				_SCustomerName_W = null;
				_SCustomerEmail_W = null;
				_SCustomerPhone1_W = null;
				_SCustomerHistory_W = null;

				this._entity.Query.FlushWhereParameters();

			}
	
			private BusinessEntity _entity;
			private TearOffWhereParameter _tearOff;
			
		}
	
		public WhereClause Where
		{
			get
			{
				if(_whereClause == null)
				{
					_whereClause = new WhereClause(this);
				}
		
				return _whereClause;
			}
		}
		
		private WhereClause _whereClause = null;	
		#endregion
	
		protected override IDbCommand GetInsertCommand() 
		{
		
			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "tblCustomers1_insert";
	
			CreateParameters(cmd);
			
			NpgsqlParameter p;
			p = cmd.Parameters[Parameters.ICustomerId.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "tblCustomers1_update";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			NpgsqlCommand cmd = new NpgsqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = this.SchemaStoredProcedure + "tblCustomers1_delete";
	
			NpgsqlParameter p;
			p = cmd.Parameters.Add(Parameters.ICustomerId);
			p.SourceColumn = ColumnNames.ICustomerId;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(NpgsqlCommand cmd)
		{
			NpgsqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.ICustomerId);
			p.SourceColumn = ColumnNames.ICustomerId;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.SCustomerName);
			p.SourceColumn = ColumnNames.SCustomerName;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.SCustomerEmail);
			p.SourceColumn = ColumnNames.SCustomerEmail;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.SCustomerPhone1);
			p.SourceColumn = ColumnNames.SCustomerPhone1;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.SCustomerHistory);
			p.SourceColumn = ColumnNames.SCustomerHistory;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}


