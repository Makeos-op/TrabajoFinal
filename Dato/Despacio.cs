using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Dato
{
    public class Despacio
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

        public string InsertarEspacio(espacio E)
        {
            return EjecutarFuncion(db =>
            {
                db.espacio.Add(E);
                db.SaveChanges();
                return "Espacio registrado correctamente.";
            });
        }

        public string EliminarEspacio(int id)
        {
            return EjecutarFuncion(db =>
            {
                var e = db.espacio.Find(id);
                db.espacio.Remove(e);
                db.SaveChanges();
                return "Espacio eliminado correctamente.";
            });
        }

        public string ModificarEspacio(espacio E)
        {
            return EjecutarFuncion(db =>
            {
                var e = db.espacio.Find(E.idEspacio);
                if (e == null) return "Espacio no encontrado.";

                e.idArrendador = E.idArrendador;
                e.ubicacion = E.ubicacion;
                e.area = E.area;
                e.precioHora = E.precioHora;

                db.SaveChanges();
                return "Espacio modificado correctamente.";
            });
        }
        public List<espacio> MostrarEspacios()
        {
            List<espacio> lista = new List<espacio>();
            EjecutarFuncion(db =>
            {
                db.Configuration.LazyLoadingEnabled = false;
                lista = db.espacio.ToList();
                return "Operación exitosa.";
            });
            return lista;
        }
    }

}
