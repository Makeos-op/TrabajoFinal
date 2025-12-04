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

        public string InsertarConductor(Conductor conductor)
        {
            return EjecutarFuncion(db =>
            {
                db.conductor.Add(conductor);
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

        public string ModificarConductor(Conductor conductor)
        {
            return EjecutarFuncion(db =>
            {
                var c = db.conductor.Find(conductor.idConductor);
                if (c == null) return "Conductor no encontrado.";

                c.nombre = conductor.nombre;
                c.apellido = conductor.apellido;
                c.dni = conductor.dni;
                c.edad = conductor.edad;
                c.nacionalidad = conductor.nacionalidad;

                db.SaveChanges();
                return "Conductor modificado correctamente.";
            });
        }
        public List<Conductor> MostrarConductores()
        {
            List<Conductor> listaconductor = new List<Conductor>();
            try
            {
                using (var context = new BDFEEntities()) // Crea una instancia del contexto de la base de datos
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    listaconductor = context.Conductor.ToList(); // Ejecuta la funcion pasada como parametro con el contexto y retorna su resultado
                }
                return listaconductor;
            }
            catch (Exception)
            {
                return listaconductor;
            }
        }
        public Conductor ObtenerConductorPorDNI(string dni)
        {
            return MostrarConductores().FirstOrDefault(c => c.dni == dni);
        }
        public List<Vehiculo> MostrarVehiculos(string dni)
        {
            return ObtenerConductorPorDNI(dni).vehiculo.ToList();
        }
        public List<Brevete> MostrarBrevetes(string dni)
        {
            return ObtenerConductorPorDNI(dni).Brevete.ToList();
        }
    }

}
