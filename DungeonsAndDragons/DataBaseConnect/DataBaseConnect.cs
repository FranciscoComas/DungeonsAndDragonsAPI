using System.Data.SqlClient;

namespace DungeonsAndDragons.DataBaseConnect
{
    public class DataBaseConnect
    {
        public DataBaseConnect()
        {

        }

        public bool databaseConnect()
        {
            string connetionString = null;
            SqlConnection cnn;
            connetionString = "Data Source=145.1.202.191;Initial Catalog=DatabaseName;User ID=UserName;Password=Password";
            cnn = new SqlConnection(connetionString);
            return false;
        }
    }
}
