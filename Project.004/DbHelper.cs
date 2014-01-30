using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project._004
{
    public class DbHelper : Library.IDatabase
    {
        private static string key = "16ca63eb81b779e50e5629ad9fd547cd1757c222812903df24a4006b4a585f9552bda51573c2e40443fabe42599db66c6a343a8aae0a813bfa3b3f516afc2ed5";//SHA256

        public static string GetConnectionString()
        {
            var Datasource = Properties.Settings.Default.DS;
            var Database = Properties.Settings.Default.DB;
            var UserId = Properties.Settings.Default.UID;
            var Password = DeCryptPass(); 
            
            return string.Format(FORMATCONNECTTIONSTRING, new object[] { Datasource, Database, UserId, Password });
        }

        public static string GetConnectionString(string datasource, string database, string userId, string password)
        {
            return string.Format(FORMATCONNECTTIONSTRING, new object[] { datasource, database, userId, password });
        }

        private static string DeCryptPass()
        {
            return Library.ISecurity.DeCryptMD5(Properties.Settings.Default.SSAP, key);
        }

        public static string EnCryptPass(string pass)
        {
            return Library.ISecurity.EnCryptMD5(pass, key);
        }

        public static List<string> GetDatabaseList(string datasource, string userId, string password)
        {
            try
            {
                Context db = new Context(GetConnectionString(datasource, "master", userId, password));

                var databases = db.ExecuteQuery<string>("SELECT [name] FROM sys.databases where [name] = 'QLKDONGLUC2'").ToList();

                return databases;
            }
            catch
            {
                return null;
            }
        }

        public static DateTime GetDatabaseDate()
        {
            Context db = new Context();
            return db.ExecuteQuery<DateTime>("SELECT GetDate()").First();
        }
    }
}
