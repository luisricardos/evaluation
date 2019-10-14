using System.Collections.Generic;
using System.Data.SQLite;
using Evaluation.Framework.Data.Connector;
using Evaluation.Framework.Data.Converter;

namespace Evaluation.Framework.ResourceAccess
{
    public class Praca : Interfaces.IPraca
    {
        public List<Entity.Praca> ConsultarPraca()
        {
            List<Entity.Praca> response = null;
            using (SqlHelper msh = new SqlHelper())
            {
                var sqlCommand = new SQLiteCommand("SELECT * FROM Praca");

                using (SQLiteDataReader dr = msh.ExecuteReader(sqlCommand))
                {
                    if (dr.HasRows)
                    {
                        response = new List<Entity.Praca>();
                        while (dr.Read())
                        {
                            Entity.Praca item = new Entity.Praca()
                            {
                                Id = SqlDataTypes.DBInt32(dr["Id"]),
                                Nome = SqlDataTypes.DBString(dr["Nome"])
                            };

                            response.Add(item);
                        }
                    }
                }
            }
            return response;
        }

        public bool ConsultarPracaPorId(int idPraca)
        {
            bool response = false;
            using (SqlHelper msh = new SqlHelper())
            {
                var sqlCommand = new SQLiteCommand($"SELECT * FROM Praca Where id = {idPraca}");

                using (SQLiteDataReader dr = msh.ExecuteReader(sqlCommand))
                {
                    if (dr.HasRows)
                    {
                        response = true;
                    }
                }
            }
            return response;
        }

    }
}