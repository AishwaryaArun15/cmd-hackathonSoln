using cmd_hackathon.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace cmd_hackathon.Models.Data
{
    public class CmdDBContext: DbContext
    {
        public CmdDBContext(): base("name=DefaultConnection") { }

        public DbSet<Clinic> Clinics { get; set; }
        public DbSet<ServiceOffered> Services { get; set; }
    }
}