using Microsoft.Data.SqlClient;
using System;
using System.Threading.Tasks;
using System.Data;

namespace DB_Uploader;

public class DBini
{
    public static SqlConnectionStringBuilder CreateBuilder(List<String> list)
    {
        return new SqlConnectionStringBuilder
        {
            DataSource = list[0],
            UserID = list[1],
            Password = list[2],
            InitialCatalog = list[3],
        };
    }
    public static List<string> GetTableNames(List<string> list, MainWindow fenster) {
        List<string> result = new List<string>();
        var builder = CreateBuilder(list);
        
        var connectionstring = builder.ConnectionString;

        try
        {
            var connection = new SqlConnection(connectionstring);
            connection.Open();
            DataTable schemaTable = connection.GetSchema("Tables");

            foreach (DataRow row in schemaTable.Rows)
            {
                result.Add(row["TABLE_NAME"].ToString());
            }
            connection.Close();
        }
        catch (SqlException e)
        {
            fenster.ForeColor = Color.Red;
            fenster.meldungen.Text = e.Message;
        }

        return result;
    }
}