using System.Configuration;
using System.Data.SqlClient;

namespace Pattern_Creator
{
    class Tools
    {
        private static SqlConnection SQL { get; set; }

        public static SqlConnection sql
        {
            get
            {
                if (SQL == null)
                    SQL = new SqlConnection(ConfigurationManager.ConnectionStrings["LocalDB"].ConnectionString);
                return SQL;
            }
            set { SQL = value; }
        }

        public static bool ExecuteNonQuery(SqlCommand cmd)
        {
            try
            {
                if (cmd.Connection.State == System.Data.ConnectionState.Closed)
                    cmd.Connection.Open();
                int affected = cmd.ExecuteNonQuery();
                return affected > 0 ? true : false;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
            finally 
            {
                if (cmd.Connection.State == System.Data.ConnectionState.Open)
                cmd.Connection.Close();
            }
        }
    }
}
