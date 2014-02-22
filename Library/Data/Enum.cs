using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Data
{
    public enum USERSTATE
    {
        ERROR = -2,
        NOTEXIST = -1,
        WRONGPASSWORD = 0,
        BEINGUSED = 1,
        AUTHORIZE = 2,
        LOCK = 3,
    };
}
