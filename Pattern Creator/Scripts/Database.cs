using System;
using System.Data;
using System.Configuration;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pattern_Creator.Scripts
{
    class Database
    {
        public static bool Insert(string blockName, byte[] image)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "InsertBlocks";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = Tools.sql;
                cmd.Parameters.AddWithValue("@Name", blockName);
                cmd.Parameters.AddWithValue("@Image", image);

                if (Tools.ExecuteNonQuery(cmd))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could NOT added! \n Error: {ex.Message}", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        public static DataTable Select()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SelectBlocks";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = Tools.sql;
            sda.SelectCommand = cmd;
            sda.Fill(dt);
            return dt;
        }

        public static AutoCompleteStringCollection AllBlockNames()
        {
            SqlConnection sql = new SqlConnection(ConfigurationManager.ConnectionStrings["LocalDB"].ConnectionString);
            AutoCompleteStringCollection blockNames = new AutoCompleteStringCollection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SelectBlocks";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = sql;
            sql.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                blockNames.Add(dr["Name"].ToString());
            }
            sql.Close();
            return blockNames;
        }

        public static bool Update(int id, string name)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "UpdateBlocks";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = Tools.sql;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@Name", name);

                if (Tools.ExecuteNonQuery(cmd))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could NOT updated! \n Error: {ex.Message}", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }


        public static void Delete(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DeleteBlocks";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = Tools.sql;
            cmd.Parameters.AddWithValue("@id", id);

            Tools.ExecuteNonQuery(cmd);
        }

        public static byte[] GetImage(int id)
        {
            if (Tools.sql.State == ConnectionState.Closed)
                Tools.sql.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "GetImage";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = Tools.sql;
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            byte[] image;
            try { image = (byte[])dr["Image"]; }
            catch (Exception) { return new byte[2]; }
            finally
            {
                if (Tools.sql.State == ConnectionState.Open)
                    Tools.sql.Close();
            }
            return image;
        }
    }
}
