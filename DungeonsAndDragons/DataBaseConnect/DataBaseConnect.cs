using System.Data.SqlClient;

namespace DungeonsAndDragons.DataBaseConnect
{
    public class DataBaseConnect
    {
        public DataBaseConnect()
        {
            databaseConnect();
        }

        public bool databaseConnect()
        {
            string connetionString = null;
            SqlConnection cnn;
            connetionString = "Data Source=garciablasco.tk;Initial Catalog=dnd;User ID=sa;Password=DnB2022";
            cnn = new SqlConnection(connetionString);
            try
            {
                using (cnn)
                {
                    var query = "select 1";
                    Console.WriteLine("Executing: {0}", query);

                    var command = new SqlCommand(query, cnn);

                    cnn.Open();
                    Console.WriteLine("SQL Connection successful.");

                    command.ExecuteScalar();
                    Console.WriteLine("SQL Query execution successful.");
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failure: {0}", ex.Message);
                return false;
            }
        }

    }
}
