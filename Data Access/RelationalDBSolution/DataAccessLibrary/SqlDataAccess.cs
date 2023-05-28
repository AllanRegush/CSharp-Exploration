using System.Data;
using Microsoft.Data.SqlClient;
using Dapper;

namespace DataAccessLibrary;

public class SqlDataAccess
{
    public List<T> LoadData<T, U>(string sqlStatement, U parameters, string connectionString)
    {
        using (IDbConnection connection = new SqlConnection(connectionString))
        {
            List<T> rows = connection.Query<T>(sqlStatement, parameters).ToList();
            return rows;
        }
    }

    public void SaveData<T, U>(string sqlStatement, U parameters, string connectionString)
    {
        using(var connection = new SqlConnection(connectionString))
        {
            connection.Execute(sqlStatement, parameters);
        }
    }
}
