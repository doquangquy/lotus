using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTILS
{
    [Serializable]
    public class UserInfo
    {
        public int PartnerID { get; set; }
        public int UserID { get; set; }
        public string AccountName { get; set; }
        public string FullName { get; set; }
        public CustomType.UserType Type { get; set; }
        public List<int> RegionID { get; set; }
        public string SessionCode { get; set; }
        public List<UserPermit> Permit { get; set; }
        public int UserLevel { get; set; }
    }
}
