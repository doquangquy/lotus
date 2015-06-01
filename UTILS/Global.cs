namespace UTILS
{
    public class Global
    {
        private static Settings _settings;

        public static Settings Settings
        {
            get
            {
                //not Setting class is not init
                if (_settings == null)
                    _settings = new Settings();
                return _settings;
            }
        }

    
    }
}