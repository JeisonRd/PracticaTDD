using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquina_Cafe.Entities
{
    public class Vaso
    {
        // Atributos privados
        private int cantidadVasos;
        private int contenido;

        // Métodos setters y getters
        public void SetCantidadVasos(int cantidadVasos)
        {
            this.cantidadVasos = cantidadVasos;
        }

        public int GetCantidadVasos()
        {
            return this.cantidadVasos;
        }

        public void SetContenido(int contenido)
        {
            this.contenido = contenido;
        }

        public int GetContenido()
        {
            return this.contenido;
        }

        // Método hasVasos: verifica si hay suficientes vasos disponibles
        public bool HasVasos(int cantidadVasos)
        {
            return this.cantidadVasos >= cantidadVasos;
        }

        // Método giveVasos: reduce la cantidad de vasos disponibles si hay suficientes
        public void GiveVasos(int cantidadVasos)
        {
            if (HasVasos(cantidadVasos))
            {
                this.cantidadVasos -= cantidadVasos;
            }
            else
            {
                throw new InvalidOperationException("No hay suficientes vasos disponibles.");
            }
        }
    }
}
