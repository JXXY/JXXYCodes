﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JXXY.Helper
{
    public static class EncryptionHelper
    {
        public static string EncryptPassword(string password)
        {
            string salt = "be6eacd9-b231-4bcf-91ff-c3cbfd640d07";            

            byte[] passwordAndSaltBytes = System.Text.Encoding.UTF8.GetBytes(password + salt);
            byte[] hashBytes = new System.Security.Cryptography.SHA256Managed().ComputeHash(passwordAndSaltBytes);
            string hashString = Convert.ToBase64String(hashBytes);
            return hashString;
        } 
    }
}
