using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cmd_hackathon.Models.Entities
{
    public class Clinic
    {
        public int ClinicId { get; set; }
        public string Name { get; set; }
        public string BusinessName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public DateTime DateCreated { get; set; }
        public List<ServiceOffered> ServicesOffered { get; set; }

    }
}