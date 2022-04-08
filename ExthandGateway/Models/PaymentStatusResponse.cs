﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Exthand.GatewayClient.Models
{


    public class PaymentStatusResponse
    {

        public PaymentStatus paymentStatus { get; set; }
        public string userContext { get; set; }
        public string rawResponse { get; set; }

    }

}
