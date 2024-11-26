using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquina_Cafe.Entities
{
    public class MaquinaCafe
    {
        private Cafetera cafe;
        private Vaso vasosPequenos;
        private Vaso vasosMedianos;
        private Vaso vasosGrandes;
        private Azucarero azucar;

        public MaquinaCafe(Cafetera cafe, Vaso vasosPequenos, Vaso vasosMedianos, Vaso vasosGrandes, Azucarero azucar)
        {
            this.cafe = cafe;
            this.vasosPequenos = vasosPequenos;
            this.vasosMedianos = vasosMedianos;
            this.vasosGrandes = vasosGrandes;
            this.azucar = azucar;
        }

        public Vaso GetTipoVaso(string tipoDeVaso)
        {
            return tipoDeVaso.ToLower() switch
            {
                "pequeno" => vasosPequenos,
                "mediano" => vasosMedianos,
                "grande" => vasosGrandes,
                _ => throw new ArgumentException("Tipo de vaso inválido.")
            };
        }

        public string GetVasoDeCafe(string tipoDeVaso, int cantidadDeVasos, int cantidadDeAzucar)
        {
            Vaso vaso = GetTipoVaso(tipoDeVaso);

            if (!vaso.HasVasos(cantidadDeVasos))
                return "No hay suficientes vasos.";

            int contenidoNecesario = vaso.GetContenido() * cantidadDeVasos;

            if (!cafe.HasCafe(contenidoNecesario))
                return "No hay suficiente café.";

            if (!azucar.HasAzucar(cantidadDeAzucar))
                return "No hay suficiente azúcar.";

            vaso.GiveVasos(cantidadDeVasos);
            cafe.GiveCafe(contenidoNecesario);
            azucar.GiveAzucar(cantidadDeAzucar);

            return "Aquí tienes tu café.";
        }
    }
}
