using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Evaluation.Framework.Data.Connector
{
    internal class SqlDatabase
    {
        SQLiteConnection _connection;

        internal SQLiteConnection SqlConnection
        {
            get
            {
                return _connection;
            }
            set
            {
                _connection = value;
            }
        }

        public SqlDatabase()
        {
            _connection = this.CreateConnection();
        }

        private SQLiteConnection CreateConnection()
        {
            return new SQLiteConnection(string.Format("Data Source={0};Version=3;", (object)Path.Combine(Path.GetDirectoryName(Assembly.GetAssembly(typeof(SqlDatabase)).CodeBase), "Evaluation.Database.db").Replace("file:\\", "")));
        }
    }
}