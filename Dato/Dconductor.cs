using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dato
{
    public class Dconductor
    {
        private string EjecutarFuncion(Func<BDFEEntities, string> funcion)
        {
            try
            {
                using (var context = new BDFEEntities())
                {
                    return funcion(context);
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string InsertarConductor(conductor Conductor)
        {
            return EjecutarFuncion(db =>
            {
                db.conductor.Add(Conductor);
                db.SaveChanges();
                return "Conductor registrado correctamente.";
            });
        }

        public string EliminarConductor(int id)
        {
            return EjecutarFuncion(db =>
            {
                var c = db.conductor.Find(id);
                db.conductor.Remove(c);
                db.SaveChanges();
                return "Conductor eliminado correctamente.";
            });
        }

        public string ModificarConductor(conductor Conductor)
        {
            return EjecutarFuncion(db =>
            {
                var c = db.conductor.Find(Conductor.idConductor);
                if (c == null) return "Conductor no encontrado.";

                c.nombre = Conductor.nombre;
                c.apellido = Conductor.apellido;
                c.dni = Conductor.dni;
                c.edad = Conductor.edad;
                c.nacionalidad = Conductor.nacionalidad;

                db.SaveChanges();
                return "Conductor modificado correctamente.";
            });
        }
    }

}
