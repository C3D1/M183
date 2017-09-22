using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OtpNet;

namespace _2_Factor_Auth.Model
{
    public class AuthentificationModel
    {
        public byte[] Secret { get; set; }
        public Totp Timestamp { get; set; }
    }
}