using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    //Class for dataResponse
    public class dataRes
    {
        public int code { get; set; }
        public string description { get; set; }
        public string data { get; set; }
    }
    //Class For ImputData POST
    public class dataIn
    {
        public string data { get; set; }
    }
}