using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dato
{
    public class Dreserva
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

        public string InsertarReserva(reserva R)
        {
            return EjecutarFuncion(db =>
            {
                db.reserva.Add(R);
                db.SaveChanges();
                return "Reserva registrada correctamente.";
            });
        }

        public string EliminarReserva(int id)
        {
            return EjecutarFuncion(db =>
            {
                var r = db.reserva.Find(id);
                db.reserva.Remove(r);
                db.SaveChanges();
                return "Reserva eliminada correctamente.";
            });
        }

        public string ModificarReserva(reserva R)
        {
            return EjecutarFuncion(db =>
            {
                var r = db.reserva.Find(R.idReserva);
                if (r == null) return "Reserva no encontrada.";

                r.idVehiculo = R.idVehiculo;
                r.idEspacio = R.idEspacio;
                r.fecha = R.fecha;
                r.hora = R.hora;
                r.cantHoras = R.cantHoras;
                r.montoTotal = R.montoTotal;

                db.SaveChanges();
                return "Reserva modificada correctamente.";
            });
        }
    }

}
