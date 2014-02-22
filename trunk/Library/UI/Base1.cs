using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.UI.Form
{
    public class Base1 : DevExpress.XtraEditors.XtraForm
    {
        protected TimeSpan ActiveTime;
        protected TimeSpan TotalTime;
        protected TimeSpan Interval;
        protected int RemainingTime;
        protected bool Waiting = false;
    }
}
