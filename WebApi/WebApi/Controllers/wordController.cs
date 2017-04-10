using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;
using WebApi.Models;
using System.Web;


namespace WebApi.Controllers
{
    public class wordController : ApiController
    {
        // POST: /word
        public string Post([FromBody]dataIn data)
        {
            dataRes respuesta;
            try{
                respuesta = new dataRes();

                //Check if the lenght for the word is diferent to 4
                if (data.data.Length == 4)
                {
                    respuesta.data = data.data.ToUpper();
                    respuesta.code = 200;
                    respuesta.description = "OK";
                }
                else
                {
                    respuesta.code = 400;
                    respuesta.description = "Bad Request";
                }

                var jsonRespuesta = new JavaScriptSerializer().Serialize(respuesta);

                return jsonRespuesta;
            }
            catch(Exception e)
            {
                respuesta = new dataRes();
                respuesta.data = e.Message;
                respuesta.code = 500;
                respuesta.description = "Internal Server Error";

                //Convert the String to JSON
                var jsonRespuestaE = new JavaScriptSerializer().Serialize(respuesta);

                return jsonRespuestaE;
            }
            
        }
    }
}
