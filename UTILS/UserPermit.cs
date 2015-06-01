using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTILS
{
    public class UserPermit
    {
        public int Code { get; set; }
        public string Page { get; set; }
        public bool IsView { get; set; }
        public bool IsUpdate { get; set; }
        public bool IsAdd { get; set; }
        public bool IsDelete { get; set; }
    }
}
