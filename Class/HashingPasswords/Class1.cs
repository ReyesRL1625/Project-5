using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HashingPasswords
{
    public class Class1
    {
        public string hashMyPassword(string pwd)
        {            
            UnicodeEncoding unicodeObject = new UnicodeEncoding();
            byte[] pwdBytes = unicodeObject.GetBytes(pwd);
            SHA256Managed SHAObject = new SHA256Managed();
            byte[] hashValue = SHAObject.ComputeHash(pwdBytes);
            string result = BitConverter.ToString(hashValue);
            return result;
        }
    }
}
