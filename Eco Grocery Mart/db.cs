/*using Microsoft.Data.SqlClient;
string conStr = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=EcoGroceryPOS;Integrated Security=True;";

using (SqlConnection con = new SqlConnection(conStr))
{
    try
    {
        con.Open();
        MessageBox.Show("Connection successful!");
    }
    catch (Exception ex)
    {
        MessageBox.Show("Error: " + ex.Message);
    }
}
*/

/*using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;

public class DB
{
    public static string connectionString = "your_connection_string";

    //public static string connectionString =

    //"Data Source=.;Initial Catalog=EcoMart_POS;" + "Integrated Security=True";
    public static SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }
}
*/

using Microsoft.Data.SqlClient;




public class DB
{
    public class DatabaseConnection
    {
        

        public static string connectionString =
        "Server=DESKTOP-O3R14AN\\SQLEXPRESS;Database=EcoMartDB;User Id=admin;Password=1234;";
      //  private static readonly string connectionString =  = connectionString = "Data Source=DESKTOP-O3R14AN\\SQLEXPRESS;Initial Catalog=EcoMart_POS;Integrated Security=True";

        //  "Server=DESKTOP-O3R14AN\\SQLEXPRESS;Database=EcoMart_POS;User Id=admin;Password=1234; TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
         

        {
            return new SqlConnection(connectionString);
        }
    }
}





   