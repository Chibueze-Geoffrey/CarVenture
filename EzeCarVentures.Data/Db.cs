using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace EzeCarVentures.Data
{
    public class Db
    {
        private static IConfiguration _configuration;

        public static void Initialize(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public static string ConnectionString
        {
            get
            {
                string connStr = _configuration.GetConnectionString("DefaultConnection").ToString();
                SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder(connStr);
                sb.ApplicationName = ApplicationName ?? sb.ApplicationName;
                sb.ConnectTimeout = (ConnectionTimeOut > 0) ? ConnectionTimeOut : sb.ConnectTimeout;
                return sb.ToString();
            }
        }
        public static SqlConnection GetSqlConnection()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            return conn;
        }
        public static int ConnectionTimeOut { get; set; }
        public static string ApplicationName
        {
            get;
            set;
        }
    }
}
