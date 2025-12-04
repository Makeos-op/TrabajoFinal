using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dato
{
    public class Darrendador
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

        public string InsertarArrendador(arrendador A)
        {
            return EjecutarFuncion(db =>
            {
                db.arrendador.Add(A);
                db.SaveChanges();
                return "Arrendador registrado correctamente.";
            });
        }

        public string EliminarArrendador(int id)
        {
            return EjecutarFuncion(db =>
            {
                var a = db.arrendador.Find(id);
                db.arrendador.Remove(a);
                db.SaveChanges();
                return "Arrendador eliminado correctamente.";
            });
        }

        public string ModificarArrendador(arrendador A)
        {
            return EjecutarFuncion(db =>
            {
                var a = db.arrendador.Find(A.idArrendador);
                if (a == null) return "Arrendador no encontrado.";

                a.nombre = A.nombre;
                a.apellido = A.apellido;
                a.dni = A.dni;
                a.edad = A.edad;
                a.nacionalidad = A.nacionalidad;

                db.SaveChanges();
                return "Arrendador modificado correctamente.";
            });
        }
        public List<arrendador> MostrarArrendadores()
        {
            List<arrendador> lista = new List<arrendador>();
            EjecutarFuncion(db =>
            {
                db.Configuration.LazyLoadingEnabled = false;
                lista = db.arrendador.ToList();
                return "Operación exitosa.";
            });
            return lista;
        }
    }

}
