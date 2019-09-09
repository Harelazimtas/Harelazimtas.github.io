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

        public String TypeManOrWoman { get; set;}
         
        public Image ImageUrl { get; set;}


        public static List<Product> LoadProduct(int Id)
        {
            string sql = @"select Price, Name, Image, Type, ProductId from dbo.Product where Id=" + Id;
            return SqlDataAccess.LoadData<Product>(sql);
        }

        public int InsertProduct()
        {
            
            String sql = @"insert into dbo.Product (Id, Price, Name, Image, Type) values (@Id, @Price, @Name, @ImageUrl, @TypeManOrWoman);";
            return SqlDataAccess.SaveData(sql, this);
        }

    }
}