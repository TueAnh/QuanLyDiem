using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QuanLyDiem.GUI
{
    class ValidError
    {
        public static bool ValidEmailAddress(string emailAddress, out string errorMessage)
        {
            // Confirm that the e-mail address string is not empty. 
            // Confirm that there is an "@" and a "." in the e-mail address, and in the correct order.
            if (emailAddress.IndexOf("@") > -1)
            {
                if (emailAddress.IndexOf(".", emailAddress.IndexOf("@")) > emailAddress.IndexOf("@"))
                {
                    errorMessage = "";
                    return true;
                }
            }

            errorMessage = "Định dạng Email không hợp lệ.\n" +
               "ví dụ như 'someone@example.com' ";
            return false;
        }
        public static bool ValidPhone(string no, out string errorMessage)
        {
            if (Regex.IsMatch(no, "^[0-9]*$"))
            {
                errorMessage = "";
                return true;
            }

            else
            {
                errorMessage = "Số điện thoại không hợp lệ ";
                return false;
            }
        }
        public static bool ValidMaSo(string maso, out string errorMessage)
        {
            if (Regex.IsMatch(maso, "^[0-9]*$"))
            {
                errorMessage = "";
                return true;
            }

            else
            {
                errorMessage = "Vui lòng chỉ nhập số.";
                return false;
            }
        }
        public static bool ValidMatKhau(string matKhau, out string errorMessage)
        {
            if (matKhau.Trim().Length<=10)
            {
                errorMessage = "";
                return true;
            }

            else
            {
                errorMessage = "Mật khẩu không quá 10 kí tự";
                return false;
            }
        }
    }
}
