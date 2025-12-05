using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dato
{
    public class DArrendador
    {
        private string EjecutarFuncion(Func<BDFEntities, string> funcion)
        {
            try
            {
                using (var context = new BDFEntities())
                {
                    return funcion(context);
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string InsertarArrendador(Arrendador A)
        {
            return EjecutarFuncion(db =>
            {
                db.Arrendador.Add(A);
                db.SaveChanges();
                return "Arrendador registrado correctamente.";
            });
        }

        public string EliminarArrendador(int id)
        {
            return EjecutarFuncion(db =>
            {
                var a = db.Arrendador.Find(id);
                db.Arrendador.Remove(a);
                db.SaveChanges();
                return "Arrendador eliminado correctamente.";
            });
        }

        public string ModificarArrendador(Arrendador A)
        {
            return EjecutarFuncion(db =>
            {
               var arr = db.Arrendador.Include(a => a.Persona).FirstOrDefault(a=>a.IdArrendador == A.IdArrendador);
                return "Bien";
            });
        }
        public List<Arrendador> MostrarArrendadores()
        {
            List<Arrendador> lista = new List<Arrendador>();
            EjecutarFuncion(db =>
            {
                db.Configuration.LazyLoadingEnabled = false;
                lista = db.Arrendador.ToList();
                return "Operación exitosa.";
            });
            return lista;
        }
    }

}
