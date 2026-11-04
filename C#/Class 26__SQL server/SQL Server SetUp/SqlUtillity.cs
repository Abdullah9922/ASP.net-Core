using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQL_Server_SetUp
{
    public class SqlUtillity
    {
        public void ExecutesSqlCommand(string connectingString, string sqlCommand, Dictionary<string, object> parameters)
        {
            using SqlConnection connection = new SqlConnection(connectingString);

            if (connection.State != System.Data.ConnectionState.Open) connection.Open();

            using SqlCommand command = new SqlCommand(sqlCommand, connection);

            if(parameters != null)
            {
                foreach (var param in parameters)
                    command.Parameters.AddWithValue(param.Key, param.Value);
            }

            command.ExecuteNonQuery();
        }

        public List<Dictionary<string,object>> ExecuteSqlQuery(string connectionString, string sqlQuery, Dictionary<string, object> parameters)
        {
            using SqlConnection connection = new SqlConnection(connectionString);

            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            using SqlCommand command = new SqlCommand(sqlQuery, connection);
            if (parameters != null)
            {
                foreach (var param in parameters)
                {
                    command.Parameters.AddWithValue(param.Key, param.Value);
                }
            }

            using SqlDataReader reader = command.ExecuteReader();

            List<Dictionary<string,object>> table = new List<Dictionary<string, object>>();
            while (reader.Read())
            {
                Dictionary<string,object> row = new Dictionary<string,object>();
                for (int i = 0; i < reader.FieldCount; i++)
                    row.Add(reader.GetName(i), reader.GetValue(i));
                table.Add(row);
            }
            return table;
        }
    }
}
