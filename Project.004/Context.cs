using System;
using System.Collections.Generic;
using System.Linq;
using Project._004.Models; 

namespace Project._004
{
    public partial class Context : QLKHODataContext
    {
        public Context() : 
            base(Program.ConnectionString)
        {
        }

        public Context(string connectionString)
            : base(connectionString)
        {
        }
    }
}
