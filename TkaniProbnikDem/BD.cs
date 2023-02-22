
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TkaniProbnikDem
{
    public class BD
    {
        MySqlConnection connection = new MySqlConnection("server=cfif31.ru;user ID=ISPr24-38_LamasovaYAD;password=ISPr24-38_LamasovaYAD;database=ISPr24-38_LamasovaYAD_test;CharSet=utf8;Connection Timeout=3600");

        public static BD Instance = new BD();
        public BD()
        {
            connection.Open();
        }
        public DataTable SqlZapros(string sql)
        {
            MySqlCommand command = new MySqlCommand(sql, connection);
            using (var reader = command.ExecuteReader())
            {
                DataTable table = new DataTable();
                table.Load(reader);
                return table;
            }
        }
    }
}