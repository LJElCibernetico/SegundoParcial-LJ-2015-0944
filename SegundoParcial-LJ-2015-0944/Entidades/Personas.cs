using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SegundoParcial_LJ_2015_0944.Entidades
{
    public class Personas
    {
        [Key]
        public int personaID { get; set; }

        public String nombre { get; set; }
        public DateTime fecha { get; set; }
        public virtual List<TiposDeTelefonoDetalle> Lista { get; set; }

        public Personas(int personaID, string nombre, DateTime fecha, List<TiposDeTelefonoDetalle> Lista)
        {
            this.personaID = personaID;
            this.nombre = nombre;
            this.fecha = fecha;
        }

        public Personas()
        {
            this.personaID = 0;
            this.nombre = String.Empty;
            this.fecha = DateTime.Now;
            Lista = new List<TiposDeTelefonoDetalle>();
        }
    }
}
