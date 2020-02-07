using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace HotelBookingSystem.DAL
{
    public class Connection
    {
        class DBSQLServerUtil
        {
            public static SqlConnection GetDBConnection(string connectionString)
            {
                try
                {

                    SqlConnection sqlConnection = new SqlConnection(connectionString);
                    return sqlConnection;
                }
                catch (Exception exCon)
                {
                    Console.WriteLine("Unable to connect to database: {0}", exCon);
                    return null;
                }
            }
        }
        class Connector
        {
            public static SqlConnection GetDBConnection()
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                return DBSQLServerUtil.GetDBConnection(connectionString);
            }
        }
    }
}
