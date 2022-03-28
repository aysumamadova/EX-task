using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_tast.CapasityEX
{
   public class CapacityLimitException:Exception
    {
        public CapacityLimitException(string message) : base(message) { }
    }
}
