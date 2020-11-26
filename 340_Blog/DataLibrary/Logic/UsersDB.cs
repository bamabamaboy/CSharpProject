using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.DBAccess;
using DataLibrary.Models;

namespace DataLibrary.Logic {
    public static class UsersDB {

        public static void creatUser(int _age, string _name, string _surname, 
            string _email, string _password) {

            UsersModel user = new UsersModel() {
                age = _age,
                name = _name,
                surname = _surname,
                email = _email,
                password = _password
            };

            string sql = @"INSERT INTO dbo.Users (age, name, surname, email, password)
                            VALUES(@age, @name, @surname, @email, @password)";

            SqlWorkflow.saveData(sql, user);
        }

        public static List<UsersModel> loadUsers() {
            string sql = @"SELECT * FROM dbo.Users";

            return SqlWorkflow.loadData<UsersModel> (sql);
        }

    }
}
