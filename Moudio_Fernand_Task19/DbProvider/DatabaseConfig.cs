using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Sql;

namespace DbProvider
{
    public static class DatabaseConfig
    {
        public static string GetConnectionString()
        {
            return @"Data Source=fernand.database.windows.net;Initial Catalog=UsersAndRewards;
                    Persist Security Info=True;User ID=titi20117;Password=Emiwx81990";
        }
    }
}
