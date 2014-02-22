using System;
using System.Collections.Generic;
using System.Linq;
using Project._008.Models;

namespace Project._008
{
    public partial class Context : QLKDONGLUCDataContext
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
