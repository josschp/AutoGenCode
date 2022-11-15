using MySql.Data.MySqlClient;
using System.Data;
using System.Xml.Serialization;

namespace AutoGenCode
{
    internal class Connection
    {
        private static MySqlConnection mconn =new MySqlConnection();
        public Connection()
        {
            mconn.ConnectionString = $"server=localhost;uid=root;pwd=;";
        }

        public Connection(string sv, string uid, string psw)
        {
            mconn.ConnectionString=$"server = {sv}; uid = {uid}; pwd = {psw};database = information_schema";
        }

        public Connection(string sv, string uid, string psw, string dataname)
        {
            mconn.ConnectionString = $"server = {sv}; uid = {uid}; pwd = {psw};database = {dataname}";
        }

        public DataTable SchemasLoad()
        {
            if (mconn.State == ConnectionState.Closed)
                mconn.Open();
            DataTable dtTable = new DataTable();
            string sql = "select table_schema as database_name, table_name from information_schema.tables where table_type = 'BASE TABLE' group by database_name order by database_name, table_name;";
            var comm = new MySqlCommand(sql, mconn);
            MySqlDataAdapter ad = new MySqlDataAdapter(comm);
            ad.Fill(dtTable);
            mconn.Close();
            return dtTable;
        }

        internal DataTable GetTableName(string text)
        {
            if (mconn.State == ConnectionState.Closed)
                mconn.Open();
            DataTable dtTable = new DataTable();
            string sql = $"SELECT table_name FROM information_schema.tables WHERE table_type = 'base table' AND table_schema='{text}';";
            var comm = new MySqlCommand(sql, mconn);
            MySqlDataAdapter ad = new MySqlDataAdapter(comm);
            ad.Fill(dtTable);
            mconn.Close();
            return dtTable;
        }

        internal DataTable GetField(string dbname, string tbname)
        {
            if (mconn.State == ConnectionState.Closed)
                mconn.Open();
            DataTable dtTable = new DataTable();
            string sql = $"SELECT ordinal_position, Column_name, data_type, Is_nullable, column_default, character_maximum_length FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = '{dbname}' AND TABLE_NAME = '{tbname}';";
            var comm = new MySqlCommand(sql, mconn);
            MySqlDataAdapter ad = new MySqlDataAdapter(comm);
            ad.Fill(dtTable);
            mconn.Close();
            return dtTable;
        }

        ~Connection() { }
    }
}
