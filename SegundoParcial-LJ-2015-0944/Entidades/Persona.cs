using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SegundoParcial_LJ_2015_0944.Entidades
{
    public class Persona
    {
        [Key]
        public int personaID { get; set; }

        public String nombre { get; set; }
        public DateTime fecha { get; set; }
        public String telefono { get; set; }

        public Persona(int personaID, string nombre, DateTime fecha, string telefono)
        {
            this.personaID = personaID;
            this.nombre = nombre;
            this.fecha = fecha;
            this.telefono = telefono;
        }

        public Persona()
        {
            this.personaID = 0;
            this.nombre = String.Empty;
            this.fecha = DateTime.Now;
            this.telefono = String.Empty;
        }
    }
}
