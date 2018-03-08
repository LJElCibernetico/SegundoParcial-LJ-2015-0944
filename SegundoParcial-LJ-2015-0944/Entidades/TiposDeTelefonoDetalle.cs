using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SegundoParcial_LJ_2015_0944.Entidades
{
    public class TiposDeTelefonoDetalle
    {
        [Key]
        public int DetalleID { get; set; }

        public int PersonaID { get; set; }
        public int TiposDeTelefonoID { get; set; }
        public String Tipo { get; set; }
        public String Telefono { get; set; }

        public TiposDeTelefonoDetalle(int detalleID, int personaID, int tiposDeTelefonoID, String tipo, String telefono)
        {
            DetalleID = detalleID;
            PersonaID = personaID;
            TiposDeTelefonoID = tiposDeTelefonoID;
            Tipo = tipo;
            Telefono = telefono;
        }

        public TiposDeTelefonoDetalle()
        {
            DetalleID = 0;
            PersonaID = 0;
            TiposDeTelefonoID = 0;
            Tipo = String.Empty;
            Telefono = String.Empty;
        }
    }
}
