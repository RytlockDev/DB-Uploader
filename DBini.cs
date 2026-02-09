using Microsoft.Data.SqlClient;
using System;
using System.Threading.Tasks;

namespace DB_Uploader;

public class DBini
{
    public static List<string> GetTableNames(List<string> list) {
        List<string> result;
        var builder = new SqlConnectionStringBuilder
        {
            DataSource = list[0],
            UserID = list[1],
            Password = list[2],
            InitialCatalog = list[3],
        };
        
        return result;
    }
}