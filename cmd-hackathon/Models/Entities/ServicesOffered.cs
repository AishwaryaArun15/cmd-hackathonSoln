using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cmd_hackathon.Models.Entities
{
    public class ServiceOffered
    {
        public int ServiceOfferedId;
        public string ServiceName;
        public string ServiceDescription;
        public double AvgPrice;
        public bool IsActive;

    }
}