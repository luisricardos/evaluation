using Evaluation.Framework.Data.Connector;
using Evaluation.Framework.Data.Converter;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;

namespace Evaluation.Framework.ResourceAccess
{
    public class Operador : Interfaces.IOperador
    {
        public List<Entity.Operador> ConsultarOperadores(decimal? percentual, string nome)
        {
            List<Entity.Operador> response = null;

            using (SqlHelper msh = new SqlHelper())
            {
                var queryBase = "SELECT * FROM Operator" +
                    "inner join Praca pr" +
                    "on pr.ID = Praca" +
                    "WHERE 1 = 1";
                var clausulaPercentual = string.Empty;
                var clausulaNome = string.Empty;

                var sqlCommand = new SQLiteCommand();

                if (percentual.HasValue)
                {
                    sqlCommand.Parameters.AddWithValue("percentual", percentual);
                    clausulaPercentual = " AND Percentual = @percentual";
                } 

                if (!string.IsNullOrEmpty(nome))
                {
                    sqlCommand.Parameters.AddWithValue("percentual", percentual);
                    clausulaNome = " AND Nome LIKE @nome";
                }

                sqlCommand.CommandText = string.Concat(queryBase, clausulaPercentual, clausulaNome);

                using (SQLiteDataReader dr = msh.ExecuteReader(sqlCommand))
                {
                    if (dr.HasRows)
                    {
                        response = new List<Entity.Operador>();
                        while (dr.Read())
                        {
                            Entity.Operador item = new Entity.Operador()
                            {
                                Id = SqlDataTypes.DBInt32(dr["Id"]),
                                Nome = SqlDataTypes.DBString(dr["Nome"]),
                                Ativo = SqlDataTypes.DBBoolean(dr["Ativo"]),
                                Limite = SqlDataTypes.DBDecimal(dr["Limite"]),
                                Percentual = SqlDataTypes.DBDecimal(dr["Percentual"])
                            };

                            item.Praca = SqlDataTypes.DBString(dr["pr.Nome"]);

                            response.Add(item);
                        }
                    }
                }
            }

            return response;
        }

        public bool ConsultarOperador(int codOperador)
        {
            bool response = false;
            using (SqlHelper msh = new SqlHelper())
            {
                var sqlCommand = new SQLiteCommand($"SELECT * FROM Operador Where ID = {codOperador}");

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

        public int IncluirOperador(Entity.Operador operador)
        {
            int codOperador = 0;

            using (SqlHelper msh = new SqlHelper())
            {
                var sqlCommand = new SQLiteCommand("INSERT INTO Operator (Nome, Ativo, Percentual, Limite, Praca) Values(@nome, @status, @percentual, @limite, @praca)");

                sqlCommand.Parameters.AddWithValue("@nome", operador.Nome);
                sqlCommand.Parameters.AddWithValue("@status", operador.Ativo);
                sqlCommand.Parameters.AddWithValue("@percentual", operador.Percentual);
                sqlCommand.Parameters.AddWithValue("@limite", operador.Limite);
                sqlCommand.Parameters.AddWithValue("@praca", operador.Praca);

                codOperador = msh.ExecuteNonQuery(sqlCommand);
            }
            return codOperador;
        }

        public void AlterarOperador(Entity.Operador operador)
        {
            using (SqlHelper msh = new SqlHelper())
            {
                var sqlCommand = new SQLiteCommand("UPDATE Operator Set Nome = @nome, Ativo = @status, Percentual = @percentual, Limite = @limite, Praca = @praca where ID = @id");

                sqlCommand.Parameters.AddWithValue("@id", operador.Id);
                sqlCommand.Parameters.AddWithValue("@nome", operador.Nome);
                sqlCommand.Parameters.AddWithValue("@status", operador.Ativo);
                sqlCommand.Parameters.AddWithValue("@percentual", operador.Percentual);
                sqlCommand.Parameters.AddWithValue("@limite", operador.Limite);
                sqlCommand.Parameters.AddWithValue("@praca", operador.Praca);

                msh.ExecuteNonQuery(sqlCommand);
            }
        }

        public void ExcluirOperador(int id)
        {
            using (SqlHelper msh = new SqlHelper())
            {
                var sqlCommand = new SQLiteCommand("DELETE From Operator WHERE ID = @id");

                sqlCommand.Parameters.AddWithValue("@id", id);

                msh.ExecuteNonQuery(sqlCommand);
            }
        }
    }
}