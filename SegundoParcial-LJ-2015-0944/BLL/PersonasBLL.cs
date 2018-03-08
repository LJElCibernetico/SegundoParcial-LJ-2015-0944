using SegundoParcial_LJ_2015_0944.DAL;
using SegundoParcial_LJ_2015_0944.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace SegundoParcial_LJ_2015_0944.BLL
{
    public class PersonasBLL
    {
        public static bool Guardar(Personas persona)
        {
            bool paso = false;

            try
            {
                Contexto Contex = new Contexto();
                Contex.Persona.Add(persona);
                foreach (TiposDeTelefonoDetalle TdtDetalle in persona.Lista)
                    Contex.TdtDetalle.Add(TdtDetalle);

                Contex.SaveChanges();
                paso = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo Guardar: " + ex.ToString());
            }

            return paso;
        }

        public static Personas Buscar(int id)
        {
            Personas persona = new Personas();
            try
            {
                Contexto db = new Contexto();
                persona = db.Persona.Find(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Persona no Encontrada: " + ex.ToString());
            }
            return persona;
        }

        public static bool Modificar(Personas persona)
        {
            bool paso = false;

            try
            {
                Contexto contex = new Contexto();
                contex.Entry(persona).State = System.Data.Entity.EntityState.Modified;
                foreach (TiposDeTelefonoDetalle TdtDetalle in persona.Lista)
                    contex.Entry(TdtDetalle).State = System.Data.Entity.EntityState.Modified;

                contex.SaveChanges();
                paso = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo Modificar: " + ex.ToString());
            }

            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;

            try
            {
                Contexto contex = new Contexto();
                Personas persona = contex.Persona.Find(id);
                contex.TdtDetalle.RemoveRange(contex.TdtDetalle.Where(x => x.PersonaID == persona.personaID));
                contex.Persona.Remove(persona);
                contex.SaveChanges();

                paso = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo Eliminar: " + ex.ToString());
            }

            return paso;
        }

        public static List<Personas> GetList(Expression<Func<Personas, bool>> filter)
        {
            List<Personas> persona = new List<Personas>();

            try
            {
                Contexto contex = new Contexto();
                persona = contex.Persona.Where(filter).ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo Listar: " + ex.ToString());
            }
            return persona;
        }
    }
}
