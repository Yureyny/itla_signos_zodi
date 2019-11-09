using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace zignos.Models
{
    public class zignosContext : DbContext
    {
        public zignosContext() : base("name=zignos")
        {

        }
        public DbSet<Usuario> Usuario
        {
            get; set;
        }

    }
}