using DataLibary.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace WebSunglass.Models
{
    public class Product
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public int Price { get; set; }
        public String Name { get; set; }

        public String Type { get; set;}
         
        public String Image { get; set;}


        public static List<Product> LoadProduct(int Id)
        {
            string sql = @"select Id, ProductId, Price, Name, Image, Type from dbo.Product where Id="+Id;
            return SqlDataAccess.LoadData<Product>(sql);
        }

        public static List<Product> LoadOtherProduct(int Id)
        {
            string sql = @"select Id, ProductId, Price, Name, Image, Type from dbo.Product where Id!=" + Id;
            return SqlDataAccess.LoadData<Product>(sql);
        }

        public int InsertProduct()
        {
            
            String sql = @"insert into dbo.Product (Id, Price, Name, Image, Type) values (@Id, @Price, @Name, @Image, @Type);";
            return SqlDataAccess.SaveData(sql, this);
        }

    }
}