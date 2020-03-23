using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusBookingSystem.Models
{
    public class Bus
    {
        public int id { get; set; }
        public string MLicensePlateNo { get; set; }
        public int MBusCapacity { get; set; }
        public string MBusType { get; set; }
    }
}