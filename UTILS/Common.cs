using System;
using System.IO;
using System.Drawing;
using System.Text.RegularExpressions;

namespace UTILS
{
    public class Common
    {
       

        public static string EncryptString(string input)
        {
            try
            {
                var rijndaelKey = new RijndaelEnhanced("DGCTV", "@1B2c3D4e5F6g7H8");
                return rijndaelKey.Encrypt(input);
            }
            catch (Exception)
            {
                return "";
            }

        }

        public static string DecryptString(string input)
        {
            try
            {
                var rijndaelKey = new RijndaelEnhanced("DGCTV", "@1B2c3D4e5F6g7H8");
                return rijndaelKey.Decrypt(input);
            }
            catch (Exception)
            {
                return "";
            }
        }

        public static bool IsValidEmail(string inputEmail)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }


        public static bool CheckUserName(string userName)
        {
            // return System.Text.RegularExpressions.Regex.IsMatch(name,@"^[a-zA-Z][\w|.]{2,10}\w$");
            userName = userName.ToLower();
            // Độ dài từ 4-16
            if (userName.Length < 4 || userName.Length > 16) return false;

            //Kí tự đầu tiên phải là chữ cái
            string fillterChar = "abcdefghijklmnopqrstuvwxyz";
            if (fillterChar.IndexOf(userName[0]) < 0) return false;

            //Kí tự '._' không được xuất hiện liền nhau
            if (userName.IndexOf("..") > 0
                || userName.IndexOf("__") > 0
                || userName.IndexOf("._") > 0
                || userName.IndexOf("_.") > 0
                ) return false;

            // Ký tự '._' không được ở sau cùng
            if (userName.EndsWith(".") || userName.EndsWith("_")) return false;

            //Chuỗi hợp lệ   abcdefghijklmnopqrstuvxyzw012345678.
            fillterChar = "abcdefghijklmnopqrstuvwxyz0123456789._";
            for (int i = 0; i < userName.Length; i++)
            {
                if (fillterChar.IndexOf(userName[i]) < 0) return false;
            }

            return true;

        }

        public static string FullTime()
        {
            string myFullTime = DateTime.Now.Year + DateTime.Now.Month.ToString() + DateTime.Now.Day + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Millisecond;
            return myFullTime;
        }

        public static Image Base64ToImage(string base64String)
        {
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            var ms = new MemoryStream(imageBytes, 0,
              imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }

        public static string ReplaceVietnameseChar(string s)
        {
            if (s == null)
                return String.Empty;
            // replace specification character
            s = s.Trim().ToLower();
            s = s.Replace('á', 'a');
            s = s.Replace('à', 'a');
            s = s.Replace('ả', 'a');
            s = s.Replace('ã', 'a');
            s = s.Replace('ạ', 'a');
            s = s.Replace('ă', 'a');
            s = s.Replace('ắ', 'a');
            s = s.Replace('ằ', 'a');
            s = s.Replace('ẳ', 'a');
            s = s.Replace('ẵ', 'a');
            s = s.Replace('ặ', 'a');
            s = s.Replace('â', 'a');
            s = s.Replace('ấ', 'a');
            s = s.Replace('ầ', 'a');
            s = s.Replace('ẩ', 'a');
            s = s.Replace('ẫ', 'a');
            s = s.Replace('ậ', 'a');
            s = s.Replace('é', 'e');
            s = s.Replace('è', 'e');
            s = s.Replace('ẻ', 'e');
            s = s.Replace('ẽ', 'e');
            s = s.Replace('ẹ', 'e');
            s = s.Replace('ê', 'e');
            s = s.Replace('ế', 'e');
            s = s.Replace('ề', 'e');
            s = s.Replace('ể', 'e');
            s = s.Replace('ễ', 'e');
            s = s.Replace('ệ', 'e');
            s = s.Replace('í', 'i');
            s = s.Replace('ì', 'i');
            s = s.Replace('ỉ', 'i');
            s = s.Replace('ĩ', 'i');
            s = s.Replace('ị', 'i');
            s = s.Replace('ó', 'o');
            s = s.Replace('ò', 'o');
            s = s.Replace('ỏ', 'o');
            s = s.Replace('õ', 'o');
            s = s.Replace('ọ', 'o');
            s = s.Replace('ô', 'o');
            s = s.Replace('ố', 'o');
            s = s.Replace('ồ', 'o');
            s = s.Replace('ổ', 'o');
            s = s.Replace('ỗ', 'o');
            s = s.Replace('ộ', 'o');
            s = s.Replace('ơ', 'o');
            s = s.Replace('ớ', 'o');
            s = s.Replace('ờ', 'o');
            s = s.Replace('ở', 'o');
            s = s.Replace('ỡ', 'o');
            s = s.Replace('ợ', 'o');
            s = s.Replace('ú', 'u');
            s = s.Replace('ù', 'u');
            s = s.Replace('ủ', 'u');
            s = s.Replace('ũ', 'u');
            s = s.Replace('ụ', 'u');
            s = s.Replace('ư', 'u');
            s = s.Replace('ứ', 'u');
            s = s.Replace('ừ', 'u');
            s = s.Replace('ử', 'u');
            s = s.Replace('ữ', 'u');
            s = s.Replace('ự', 'u');
            s = s.Replace('ý', 'y');
            s = s.Replace('ỳ', 'y');
            s = s.Replace('ỷ', 'y');
            s = s.Replace('ỹ', 'y');
            s = s.Replace('ỵ', 'y');
            s = s.Replace('đ', 'd');
            return s;
        }
    }
}
