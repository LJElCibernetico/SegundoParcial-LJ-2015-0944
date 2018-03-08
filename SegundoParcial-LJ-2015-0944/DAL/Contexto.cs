using SegundoParcial_LJ_2015_0944.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace SegundoParcial_LJ_2015_0944.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Personas> Persona { get; set; }
        public DbSet<TiposDeTelefono> TipoTelefono { get; set; }
        public DbSet<TiposDeTelefonoDetalle> TdtDetalle { get; set; }

        public Contexto() : base("ConStr")
        {

        }
    }
}
