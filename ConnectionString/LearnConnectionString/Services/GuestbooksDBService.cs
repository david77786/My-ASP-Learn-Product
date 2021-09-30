using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;

namespace LearnConnectionString.Services
{
    public class GuestbooksDBService
    {
        private readonly static string cnstr = ConfigurationManager.ConnectionStrings["ASP.NET MVC"].ConnectionString;

        private readonly SqlConnection conn = new SqlConnection(cnstr);
    }
}