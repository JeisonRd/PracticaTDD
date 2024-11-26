using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquina_Cafe.Entities
{
    public class Cafetera
    {
        // Atributo privado
        private int cantidadCafe;

        // Métodos setters y getters
        public void SetCantidadDeCafe(int cantidadCafe)
        {
            this.cantidadCafe = cantidadCafe;
        }

        public int GetCantidadDeCafe()
        {
            return this.cantidadCafe;
        }

        // Método hasCafe: verifica si hay suficiente café disponible
        public bool HasCafe(int cantidadCafe)
        {
            return this.cantidadCafe >= cantidadCafe;
        }

        // Método giveCafe: reduce la cantidad de café si hay suficiente
        public void GiveCafe(int cantidadCafe)
        {
            if (HasCafe(cantidadCafe))
            {
                this.cantidadCafe -= cantidadCafe;
            }
            else
            {
                throw new InvalidOperationException("No hay suficiente café disponible.");
            }
        }
    }

}
