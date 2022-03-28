using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_tast.Models
{
    interface IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }
       public string ShowInfo();
    }
}
