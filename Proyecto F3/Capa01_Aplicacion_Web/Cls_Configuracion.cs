using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration; //para utilizar configuration Manager

namespace Capa01_Aplicacion_Web
{
    public static class Cls_Configuracion
    {
        public static string getConnectionString
        {
            get
            {
                return ConfigurationManager.AppSettings["ConnectionString"];
            }
        }

    }
}