using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusBookingSystem.Models;
namespace BusBookingSystem.ViewModels
{
    public class DriverAndBusViewModel
    {
        public Bus Bus { get; set; }
        public IEnumerable<Driver> Driver { get; set; }
    }
}