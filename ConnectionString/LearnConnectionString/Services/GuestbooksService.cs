using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LearnConnectionString.Models;
using System.Data.SqlClient;

namespace LearnConnectionString.Services
{
    public class GuestbooksService
    {
        private readonly string cnstr = @"Persist Security Info = false;
    Integrated Security = true; server= ACER\SQLEXPRESS01;Initial Catalog=ASP.NET MVC;
    user ID=;Password = ";
        public List<Guestbooks> GerDataList()
        {
            List<Guestbooks> DataList = new List<Guestbooks>();
            string sql = @"SELECT * FROM Guestbooks";
            SqlConnection conn = new SqlConnection(cnstr);
            conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Guestbooks Data = new Guestbooks();
                Data.id = Convert.ToInt32(dr["id"]);
                Data.Name = dr["Name"].ToString();
                Data.Content = dr["Content"].ToString();
                DataList.Add(Data);
            }
            conn.Close();
            return DataList;             
        }
    }
}