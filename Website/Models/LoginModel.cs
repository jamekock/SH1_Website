using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;

namespace Website.Models
{
    public class LoginModel
    {
        public int id { get; set; }
        public string User{ get; set; }
        public string Password { get; set; }
    }
}