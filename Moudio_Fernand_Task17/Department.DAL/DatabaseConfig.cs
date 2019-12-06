using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.Sql;


namespace Department.DAL
{
    public static class DatabaseConfig
    {
        public static string GetConnectionString()
        {            

            return @"Data Source=DESKTOP-B2649OM;Initial Catalog=UsersAndRewards;Integrated Security=True";
        }
    }
}
