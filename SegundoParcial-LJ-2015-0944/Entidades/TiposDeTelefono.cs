using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SegundoParcial_LJ_2015_0944.Entidades
{
    public class TiposDeTelefono
    {
        [Key]
        public int ID { get; set; }

        public String Tipo { get; set; }
        
        public TiposDeTelefono(int id, String tipo)
        {
            ID = id;
            Tipo = tipo;
        }

        public TiposDeTelefono()
        {
            ID = 0;
            Tipo = String.Empty;
        }
    }
}
