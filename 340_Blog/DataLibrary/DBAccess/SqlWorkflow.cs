using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace DataLibrary.DBAccess {
    class SqlWorkflow {

        //Метод для подключения к MSSQL Server
        public static string getStringCinnection() {
            return ConfigurationManager.ConnectionStrings["blogDB"].ConnectionString;
        }

        //Метод для получения данных из DB, принимает SQL-запрос
        public static List<T> loadData<T>(string sql) {
            using (IDbConnection conn = new SqlConnection(getStringCinnection())) {
                return conn.Query<T>(sql).ToList();
            }
        }

        //Метод для сохранения данных в DB, принимает SQL-запрос
        public static void saveData<T>(string sql, T data) {
            using (IDbConnection conn = new SqlConnection(getStringCinnection())) {
                conn.Execute(sql, data);
            }
        }

    }
}
