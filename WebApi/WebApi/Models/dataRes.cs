using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class dataRes
    {
        public int code { get; set; }
        public string description { get; set; }
        public string data { get; set; }
    }
    public class dataIn
    {
        public string data { get; set; }
    }
}