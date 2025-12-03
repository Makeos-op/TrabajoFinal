using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dato
{
    public class Dvehiculo
    {
        private string EjecutarFuncion(Func<BDFEEntities, string> funcion) //Recibe una funcion llamada funcion que reciba objeto BDEFEntities y retorne un string
        {
            try
            {
                using (var context = new BDFEEntities()) // Crea una instancia del contexto de la base de datos
                {
                    return funcion(context); // Ejecuta la funcion pasada como parametro con el contexto y retorna su resultado
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string InsertarVehiculo(vehiculo Vehiculo)
        {
            return EjecutarFuncion(instrucciones =>
            {
                instrucciones.vehiculo.Add(Vehiculo); // Agrega el vehiculo al contexto
                instrucciones.SaveChanges(); // Guarda los cambios en la base de datos
                return "Vehiculo insertado correctamente.";
            });
        }
        public string EliminarVehiculo(int idvehiculo)
        {
            return EjecutarFuncion(instrucciones =>
            {
                instrucciones.vehiculo.Remove(instrucciones.vehiculo.Find(idvehiculo));
                instrucciones.SaveChanges();
                return "Vehiculo eliminado correctamente.";
            });
        }
        public string ModificarVehiculo(vehiculo Vehiculo)
        {
            return EjecutarFuncion(instrucciones =>
            {
                var vehiculoExistente = instrucciones.vehiculo.Find(Vehiculo.idVehiculo);
                if (vehiculoExistente != null)
                {
                    vehiculoExistente.matricula = Vehiculo.matricula;
                    vehiculoExistente.cantAsientos = Vehiculo.cantAsientos;
                    vehiculoExistente.color = Vehiculo.color;
                    instrucciones.SaveChanges();
                    return "Vehiculo modificado correctamente.";
                }
                else
                {
                    return "Vehiculo no encontrado.";
                }
            });
        }
    }
}
