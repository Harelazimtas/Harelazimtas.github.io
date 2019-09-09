using DataLibary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibary.DataAccess;

namespace DataLibary.Logic
{
    public static class CustomerProcessor
    {
        public static int CreateCustomer(int id, String firstName, String lastName, String email,String password)
        {
            CustomerModel data = new CustomerModel
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Password = password
            };
            String sql = @"insert into dbo.Customer (Id, FirstName, LastName, Email, Password) values (@Id, @FirstName, @LastName, @Email, @Password);";
            return SqlDataAccess.SaveData(sql, data);
        }


        public static List<CustomerModel> LoadCustomer() 
        {
            String sql = @"select Id, FirstName, LastName, Email, Password from dbo.Customer;";

            return SqlDataAccess.LoadData<CustomerModel>(sql);
        }

        public static CustomerModel GetCustomer(int Id)
        {
            String sql = @"select Id, FirstName, LastName, Email, Password from dbo.Customer where Id=" + Id; ;

            return SqlDataAccess.LoadData<CustomerModel>(sql).ElementAt(0);
        }


        public static CustomerModel LoginCustomer(int Id,string Password)
        {
            string sql= @"select Id, FirstName, LastName, Email, Password from dbo.Customer where Id=" + Id;
            

            List<CustomerModel> custList=SqlDataAccess.LoadData<CustomerModel>(sql);
            try
            {
                if (custList[0].Password.CompareTo(Password) == 0)
                {
                    return custList[0];
                }
            }
            catch (Exception e)
            {

            }
            return null;
        }


    }
}
