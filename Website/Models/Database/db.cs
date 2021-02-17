using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace Website.Models.Database
{
    public static class db
    {
        public static MySqlConnection dbConnect()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "prueba";
            MySqlConnection cn = new MySqlConnection(builder.ToString());
            return cn;
        }
    }
}