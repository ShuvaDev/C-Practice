using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdonetExample
{
    public class AdonetUtility : IDisposable
    {
        private readonly SqlConnection _sqlConnection;

        public AdonetUtility(string connectionString)
        {
            _sqlConnection = new SqlConnection(connectionString);
        }

        public void Dispose()
        {
            _sqlConnection?.Dispose();
        }

        public void ExecuteSql(string sql, Dictionary<string, object> parameters = null)
        {
            using SqlCommand command = CreateCommand(sql, parameters);
            
            command.ExecuteNonQuery();
        }

        public (List<string> columnName, List<object[]> values) ReadData(string sql, Dictionary<string, object> parameters = null)
        {
            using SqlCommand command = CreateCommand(sql, parameters);
            using SqlDataReader reader = command.ExecuteReader();

            List<string> columnNames = new List<string>();
            for(int i = 0; i < reader.FieldCount; i++)
            {
                columnNames.Add(reader.GetName(i));
            }

            List<object[]> values = new List<object[]>();
            while(reader.Read())
            {
                object[] row = new object[reader.FieldCount];

                for(int i = 0; i < reader.FieldCount; i++)
                {
                    row[i] = reader.GetValue(i);
                }

                values.Add(row);
            }

            return (columnNames, values);
        }

        private SqlCommand CreateCommand(string sql, Dictionary<string, object> parameters)
        {
            SqlCommand command = new SqlCommand(sql, _sqlConnection);

            if (parameters != null)
            {
                foreach (var parameter in parameters)
                {
                    command.Parameters.Add(new SqlParameter(parameter.Key, parameter.Value));
                }
            }

            if (_sqlConnection.State != System.Data.ConnectionState.Open)
                _sqlConnection.Open();

            return command;
        }
    }
}
