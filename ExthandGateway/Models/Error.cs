using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json.Schema;

namespace Exthand.GatewayClient.Models
{
    public class Error
    {
        
        
        public string ExceptionType { get; set; }

        public string Message { get; set; }


        public string InnerException { get; set; }


        public int? StatusCode { get; set; }


        public string UserContext { get; set; }


        public string Log { get; set; }
    }
}
