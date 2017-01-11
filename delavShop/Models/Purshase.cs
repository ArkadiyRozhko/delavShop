using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace delavShop.Models
{
    public class Purshase
    {
        public  int PurshaseId { get; set; }
        public  string Person { get; set; }
        public  int CreamId { get; set; }
        public  string Address { get; set; }
        public  DateTime Date { get; set; }
    }
}