﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class timeController : ApiController
    {
        // GET: api/time
        public string Get(string value)
        {
            dataRes respuesta;
            try
            {
                respuesta = new dataRes();
                respuesta.data = Convert.ToDateTime(value).ToUniversalTime().ToString();
                respuesta.code = 200;
                respuesta.description = "OK";
                var jsonRespuesta = new JavaScriptSerializer().Serialize(respuesta);

                return jsonRespuesta;
            }
            catch (Exception e)
            {
                respuesta = new dataRes();
                
                //check if the exception is "Can´t convert the format to DateTime
                if (e.HResult== -2146233033)
                {
                    respuesta.code = 400;
                    respuesta.description = "Bad Request";
                }
                else
                {
                    respuesta.code = 500;
                    respuesta.description = "Internal Server Error";
                    
                }
                var jsonRespuestaex = new JavaScriptSerializer().Serialize(respuesta);
                return jsonRespuestaex;
            }

        }

    }
}
