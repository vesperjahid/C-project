using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Mobile_Banking_System
{
    class dbconfig
    {
        private SqlConnection _conn;
        public SqlCommand cmd;
        private SqlDataAdapter _da;
        private DataTable _dt;
        
        public dbconfig()
        {
            _conn = new SqlConnection("Data Source=DESKTOP-G5H300K;Initial Catalog=Bank_Management_System;Integrated Security=True");
            _conn.Open();
        }

        public void query(string qureyText)
        {
            cmd = new SqlCommand(qureyText,_conn);
        }
        public DataTable queryEx()
        {
            _da = new SqlDataAdapter(cmd);
            _dt = new DataTable();
            _da.Fill(_dt);
            return _dt;
        }

        public void querynonEx()
        {
            cmd.ExecuteNonQuery();
        }
    }
}
