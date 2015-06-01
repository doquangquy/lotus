using System;
namespace UTILS
{
    [Serializable]
    public class ReturnPack
    {
        private string _status;
        private string _message;
        private string _value;
        private object _data;

        public ReturnPack()
        {
            _status = "";
            _message = "";
            _data = null;
            _value = "";
        }
        public ReturnPack(string status, string message)
        {
            _status = status;
            _message = message;
            _data = null;
            _value = "";
        }
        public ReturnPack(string status, string message, object data, string value)
        {
            _status = status;
            _value = value;
            _message = message;
            _data = data;
        }
        public string status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
            }
        }
        public string value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }
        public string message
        {
            get
            {
                return _message;
            }
            set
            {
                _message = value;
            }
        }
        public object data
        {
            get
            {
                return _data;
            }
            set
            {
                _data = value;
            }
        }
    }
}
