using System;
using System.Configuration;
using System.Web.Configuration;

namespace UTILS
{
    public class Settings
    {
        // Declare properties and objects
        private readonly RijndaelEnhanced _rijndaelKey = new RijndaelEnhanced("DGCTV", "@1B2c3D4e5F6g7H8");

        public Settings()
        {
            // Init Connection object
            ConnectionStringSettingsCollection connections = WebConfigurationManager.ConnectionStrings;

            ConnectionStringDGTV = _rijndaelKey.Decrypt(connections["ConnectionStringCommon"].ToString());

            //Init Other

            LogingType = "Global Policy";
          
            IsLocal = Convert.ToBoolean(WebConfigurationManager.AppSettings["currentStatus"]);
        }



        public String ConnectionStringDGTV { get; set; }

        public String LogingType { get; set; }

        public bool IsLocal { get; set; }
    }
}