using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    public abstract class IDatabase
    {
        public const string FORMATCONNECTTIONSTRING = "Data Source={0};Initial Catalog={1};User ID={2};Password={3}";
        public const string FORMATCONNECTTIONSTRING2 = "Data Source={0};Initial Catalog={1};User ID={2};Password={3};Connection Timeout={4}";

        public const string FORMATGETTABLES = "SELECT [TABLE_NAME] FROM information_schema.tables where [TABLE_CATALOG] = '{0}'";
    }
}
