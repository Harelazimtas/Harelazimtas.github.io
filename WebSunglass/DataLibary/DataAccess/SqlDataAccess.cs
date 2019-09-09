using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DataLibary.DataAccess
{
    public static class SqlDataAccess
    {
        public static String GetConnectionString(String conn = "master")
        {
            return ConfigurationManager.ConnectionStrings[conn].ConnectionString;
        }

        public static List<T> LoadData<T>(String sql)
        {
            using(IDbConnection cnn=new SqlConnection(GetConnectionString()))
            {
                return cnn.Query<T>(sql).ToList();
            }
        }

        public static int SaveData<T>(String sql,T data)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                return cnn.Execute(sql, data);
            }
        }




    }
}
