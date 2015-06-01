using System;
using System.Collections.Specialized;
using System.IO;
using System.Text;
using System.Web;
using System.Web.UI;

namespace UTILS
{
    public class Utilities
    {


        public static string GetExtensionOfFile(string fileName)
        {
            int num = fileName.LastIndexOf('.');
            if (num == -1)
            {
                return string.Empty;
            }
            return fileName.Substring(num + 1).ToLower();
        }

        public static string GetFolderUrl(string url)
        {
            int length = url.LastIndexOf('/');
            if (length == -1)
            {
                return string.Empty;
            }
            return url.Substring(0, length);
        }

        public static string GetNameOfPath(string path)
        {
            if (path.EndsWith(@"\"))
            {
                path = path.Substring(0, path.Length - 1);
            }
            path = path.Replace('/', '\\');
            return path.Substring(path.LastIndexOf(@"\") + 1);
        }

        public static bool IsImage(string extension)
        {
            switch (extension)
            {
                case "gif":
                    return true;

                case "bmp":
                    return true;

                case "png":
                    return true;

                case "jpg":
                    return true;

                case "jpeg":
                    return true;
            }
            return false;
        }

        public static string RenderControlToString(Control ctr)
        {
            var sb = new StringBuilder();
            var writer = new StringWriter(sb);
            var writer2 = new HtmlTextWriter(writer);
            ctr.RenderControl(writer2);
            return sb.ToString();
        }

        public static string UnicodeToKoDauAndGach(string s)
        {
            int index;
            int num2;
            string str = string.Empty;
            for (num2 = 0; num2 < s.Length; num2++)
            {
                char ch = s[num2];
                index = "\x00e0\x00e1ả\x00e3ạ\x00e2ầấẩẫậăằắẳẵặ\x00e8\x00e9ẻẽẹ\x00eaềếểễệđ\x00ec\x00edỉĩị\x00f2\x00f3ỏ\x00f5ọ\x00f4ồốổỗộơờớởỡợ\x00f9\x00faủũụưừứửữựỳ\x00fdỷỹỵ\x00c0\x00c1Ả\x00c3Ạ\x00c2ẦẤẨẪẬĂẰẮẲẴẶ\x00c8\x00c9ẺẼẸ\x00caỀẾỂỄỆĐ\x00cc\x00cdỈĨỊ\x00d2\x00d3Ỏ\x00d5Ọ\x00d4ỒỐỔỖỘƠỜỚỞỠỢ\x00d9\x00daỦŨỤƯỪỨỬỮỰỲ\x00ddỶỸỴ\x00c2ĂĐ\x00d4ƠƯ".IndexOf(ch.ToString());
                if (index >= 0)
                {
                    str = str + "aaaaaaaaaaaaaaaaaeeeeeeeeeeediiiiiooooooooooooooooouuuuuuuuuuuyyyyyAAAAAAAAAAAAAAAAAEEEEEEEEEEEDIIIOOOOOOOOOOOOOOOOOOOUUUUUUUUUUUYYYYYAADOOU"[index];
                }
                else
                {
                    str = str + s[num2];
                }
            }
            string str2 = str;
            for (num2 = 0; num2 < str.Length; num2++)
            {
                index = Convert.ToInt32(str[num2]);
                if (((((index < 0x61) || (index > 0x7a)) && ((index < 0x41) || (index > 90))) && ((index < 0x30) || (index > 0x39))) && (index != 0x20))
                {
                    str2 = str2.Replace(str[num2].ToString(), "");
                }
            }
            str2 = str2.Replace(" ", "-");
            while (str2.EndsWith("-"))
            {
                str2 = str2.Substring(0, str2.Length - 1);
            }
            while (str2.IndexOf("--") >= 0)
            {
                str2 = str2.Replace("--", "-");
            }
            str = str2;
            return str.Replace("\"", string.Empty).Replace("'", string.Empty);
        }

        public class RequestForm
        {
            private static NameValueCollection CurrentPageParam()
            {
                HttpRequest request = HttpContext.Current.Request;
                return (request.HttpMethod.ToLower().Equals("get") ? request.QueryString : request.Form);
            }

            public static bool GetBool(string key)
            {
                return GetBool(key, false);
            }

            public static bool GetBool(string key, bool defaultValue)
            {
                NameValueCollection values = CurrentPageParam();
                if (string.IsNullOrEmpty(values[key]))
                {
                    return defaultValue;
                }
                try
                {
                    return bool.Parse(values[key]);
                }
                catch
                {
                    return defaultValue;
                }
            }

            public static DateTime GetDate(string key)
            {
                return GetDate(key, DateTime.MinValue);
            }

            public static DateTime GetDate(string key, DateTime defaultValue)
            {
                NameValueCollection values = CurrentPageParam();
                if (string.IsNullOrEmpty(values[key]))
                {
                    return defaultValue;
                }
                try
                {
                    string[] strArray = values[key].Split(new[] { '/' });
                    return new DateTime(int.Parse(strArray[2]), int.Parse(strArray[1]), int.Parse(strArray[0]));
                }
                catch
                {
                    return defaultValue;
                }
            }

            public static int GetInt(string key)
            {
                return GetInt(key, 0);
            }

            public static int GetInt(string key, int defaultValue)
            {
                NameValueCollection values = CurrentPageParam();
                if (string.IsNullOrEmpty(values[key]))
                {
                    return defaultValue;
                }
                try
                {
                    return int.Parse(values[key]);
                }
                catch
                {
                    return defaultValue;
                }
            }

            public static long GetLong(string key)
            {
                return GetLong(key, 0L);
            }

            public static long GetLong(string key, long defaultValue)
            {
                NameValueCollection values = CurrentPageParam();
                if (string.IsNullOrEmpty(values[key]))
                {
                    return defaultValue;
                }
                try
                {
                    return long.Parse(values[key]);
                }
                catch
                {
                    return defaultValue;
                }
            }

            public static string GetString(string key)
            {
                NameValueCollection values = CurrentPageParam();
                if (string.IsNullOrEmpty(values[key]))
                {
                    return string.Empty;
                }
                return values[key];
            }
        }
    }
}
