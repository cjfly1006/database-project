using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MySQL_edit
{
    class DBRoome
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=;database=roomey";
            MySqlConnection conn = new MySqlConnection();
            try
            {
                conn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return conn;

        }
        public static void AddRoome(Roome std)
        {
            string sql = "INSERT INTO roome_table VALUES (NULL, @RoomeName, @RoomeRoom, @RoomeChore, Null";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@RoomeName", MySqlDbType.VarChar).Value = std.Name;
            cmd.Parameters.Add("@RoomeRoom", MySqlDbType.VarChar).Value = std.Room;
            cmd.Parameters.Add("@RoomeChore", MySqlDbType.VarChar).Value = std.Chore;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Succesfully.", "Informatino", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Roome not insert. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conn.Close();
        }
        public static void UpdateRoome(Roome std)
        {
            string sql = "UPDATE roome_table SET Name = @RoomeName, Room = @RoomeRoom, Chore = @RoomeChore WHERE ID =@RoomeID";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@RoomeName", MySqlDbType.VarChar).Value = std.Name;
            cmd.Parameters.Add("@RoomeRoom", MySqlDbType.VarChar).Value = std.Room;
            cmd.Parameters.Add("@RoomeChore", MySqlDbType.VarChar).Value = std.Chore;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Uppdated Succesfully.", "Informatino", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Roome not update. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conn.Close();
        }
        public static void DeleteRoome(Roome std)
        {
            string sql = "DELETE FROM roome_table WHERE ID =@RoomeID";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@RoomeName", MySqlDbType.VarChar).Value = std.Name;
            cmd.Parameters.Add("@RoomeRoom", MySqlDbType.VarChar).Value = std.Room;
            cmd.Parameters.Add("@RoomeChore", MySqlDbType.VarChar).Value = std.Chore;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete Succesfully.", "Informatino", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Roome not delete. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conn.Close();
        }

        public static void DisplayAndSearch(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataAdapter adpt = new MySqlDataAdapter(cmd);
            DataTable tb1 = new DataTable();
            adpt.Fill(tb1);
            conn.Close();
        }
    }
}
