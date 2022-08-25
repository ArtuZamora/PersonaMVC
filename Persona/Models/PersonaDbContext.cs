using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Persona.Models
{
    public class PersonaDbContext : DbContext
    {
        public DbSet<Persona> Personas { get; set; }
    }
}