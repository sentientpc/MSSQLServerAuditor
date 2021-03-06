﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using MSSQLServerAuditor.Model.Commands;
using MSSQLServerAuditor.SQLite.Commands;

namespace MSSQLServerAuditor.Model.Connections.Query
{
	internal abstract class SqliteQueryConnection : DbQueryConnection<SQLiteConnection>
	{
		protected SqliteQueryConnection(SQLiteConnection dbConnection) : base(dbConnection)
		{
		}

		public abstract SqliteQueryCommand GetSqliteCommand(
			string                          sqlText,
			int                             commandTimeout
		);

		public override IQueryCommand GetCommand(
			string                          sqlText,
			int                             commandTimeout,
			IEnumerable<QueryParameterInfo> parameters,
			out List<Tuple<int, string>>    parametersQueueForODBC)
		{
			parametersQueueForODBC = new List<Tuple<int, string>>();

			return GetSqliteCommand(sqlText, commandTimeout);
		}
	}

	internal abstract class SqliteQueryCommand : IQueryCommand
	{
		protected Func<SQLiteDataReader> _commandFunc;
		protected readonly SQLiteCommand _sqliteCommand;

		protected SqliteQueryCommand(SQLiteCommand sqliteCommand)
		{
			this._commandFunc   = null;
			this._sqliteCommand = sqliteCommand;
		}

		public void Dispose()
		{
			if (this._sqliteCommand != null)
			{
				this._sqliteCommand.Dispose();
			}
		}

		public void AssignParameters(
			IEnumerable<QueryParameterInfo> parameters,
			IEnumerable<ParameterValue>     parameterValues,
			List<Tuple<int, string>>        parametersQueueForOdbc)
		{
			if (parameters != null)
			{
				foreach (QueryParameterInfo parameter in parameters)
				{
					if (this._sqliteCommand != null)
					{
						var p = this._sqliteCommand.CreateParameter();

						p.ParameterName = parameter.Name;
						p.IsNullable    = true;
						p.DbType        = parameter.Type.ToDbType();
						p.Value         = parameter.GetDefaultValue();

						this._sqliteCommand.Parameters.Add(p);
					}
				}
			}

			if (parameterValues != null)
			{
				foreach (ParameterValue value in parameterValues)
				{
					if (this._sqliteCommand != null)
					{
						var parameter =
							(from SQLiteParameter p in this._sqliteCommand.Parameters
							 where p.ParameterName == value.Name
							 select p)
							.FirstOrDefault();

						if (parameter != null)
						{
							parameter.Value = value.GetValue(parameter.DbType.ToSqlDbType());
						}
					}
				}
			}
		}

		public IAsyncResult BeginExecuteReader(AsyncCallback callback)
		{
			this.AssignDefaultParameters();

			this._commandFunc = () =>
			{
				if (this._sqliteCommand.Connection.State == ConnectionState.Closed)
				{
					this._sqliteCommand.Connection.Open();
				}

				return this._sqliteCommand.ExecuteReader();
			};

			return this._commandFunc.BeginInvoke(callback, this);
		}

		public IDataReader EndExecuteReader(IAsyncResult result)
		{
			return this._commandFunc.EndInvoke(result);
		}

		public void Cancel()
		{
			if (this._sqliteCommand != null)
			{
				this._sqliteCommand.Cancel();
			}
		}

		protected abstract void AssignDefaultParameters();
	}
}
