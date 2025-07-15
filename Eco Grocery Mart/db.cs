using Microsoft.Data.SqlClient;

public class DB
{
      public static string connectionString =
           "Data Source=.;Initial Catalog=EcoMart_POS;Integrated Security=True";
           public static SqlConnection GetConnection()
           {
               return new SqlConnection(connectionString);
           }
 }
      
