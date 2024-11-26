using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquina_Cafe.Entities
{
    public class Azucarero
    {
        // Atributo privado
        private int cantidadDeAzucar;

        // Métodos setters y getters
        public void SetCantidadDeAzucar(int cantidadDeAzucar)
        {
            this.cantidadDeAzucar = cantidadDeAzucar;
        }

        public int GetCantidadDeAzucar()
        {
            return this.cantidadDeAzucar;
        }

        // Método hasAzucar: verifica si hay suficiente azúcar disponible
        public bool HasAzucar(int cantidadDeAzucar)
        {
            return this.cantidadDeAzucar >= cantidadDeAzucar;
        }

        // Método giveAzucar: reduce la cantidad de azúcar si hay suficiente
        public void GiveAzucar(int cantidadDeAzucar)
        {
            if (HasAzucar(cantidadDeAzucar))
            {
                this.cantidadDeAzucar -= cantidadDeAzucar;
            }
            else
            {
                throw new InvalidOperationException("No hay suficiente azúcar disponible.");
            }
        }
    }

}
