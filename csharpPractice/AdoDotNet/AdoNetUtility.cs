using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoDotNet
{
    internal class AdoNetUtility
    {
        private readonly SqlConnection _conn;
        public AdoNetUtility(string connectionString)
        {
            _conn = new SqlConnection(connectionString);
        }

        private SqlCommand CreateCommand(string sql, Dictionary<string, object> parameter)
        {
            if (_conn.State != System.Data.ConnectionState.Open)
            {
                _conn.Open();
            }

            SqlCommand command = new SqlCommand(sql, _conn);

            if (parameter != null)
            {
                foreach (var param in parameter)
                {
                    command.Parameters.Add(new SqlParameter(param.Key, param.Value));
                }
            }
            return command;
        }
        public void ExecuteSql(string sql, Dictionary<string, object> parameter = null)
        {
            using SqlCommand command = CreateCommand(sql, parameter);
            command.ExecuteNonQuery();
        }

        public (List<string> columnNames, List<object[]> values) ReadData(string sql, Dictionary<string, object> parameter = null)
        {
            using SqlCommand command = CreateCommand(sql, parameter);

            using SqlDataReader reader = command.ExecuteReader();

            List<string> columnNames = new List<string>();
            List<object[]> values = new List<object[]>();
            for(int i = 0; i < reader.FieldCount; i++)
            {
                columnNames.Add(reader.GetName(i));
            }

            while (reader.Read())
            {
                object[] row = new object[reader.FieldCount];
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    row[i] = reader.GetValue(i);
                }
                values.Add(row);
            }
            return (columnNames, values);
        }

        
    }
}
