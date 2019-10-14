using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace Evaluation.Framework.Data.Connector
{
   public class SqlHelper : IDisposable
    {
        private SqlDatabase _sqlDatabase;

        public SqlHelper()
        {
            _sqlDatabase = new SqlDatabase();
            _sqlDatabase.SqlConnection.Open();
        }

        public SQLiteDataReader ExecuteReader(SQLiteCommand sqlCommand)
        {
            sqlCommand.Connection = _sqlDatabase.SqlConnection;
            
            return sqlCommand.ExecuteReader();
        }

        public int ExecuteNonQuery(SQLiteCommand sqlCommand)
        {
            sqlCommand.Connection = _sqlDatabase.SqlConnection;

            return sqlCommand.ExecuteNonQuery();
        }

        public int ExecuteNonQuery(SQLiteCommand sqlCommand, out int id)
        {
            id = -1;

            sqlCommand.Connection = _sqlDatabase.SqlConnection;

            int num = sqlCommand.ExecuteNonQuery();

            sqlCommand.CommandText = "Select @@identity";

            id = Convert.ToInt32(sqlCommand.ExecuteScalar());

            return num;
        }

        public object ExecuteScalar(SQLiteCommand sqlCommand)
        {
            sqlCommand.Connection = _sqlDatabase.SqlConnection;

            return sqlCommand.ExecuteScalar();
        }

        #region Dispose

        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (this._sqlDatabase != null
                && this._sqlDatabase.SqlConnection != null
                    && this._sqlDatabase.SqlConnection.State != ConnectionState.Closed)
            {
                this._sqlDatabase.SqlConnection.Close();
            }

            GC.SuppressFinalize((object)this);
        }

        #endregion
    }
}