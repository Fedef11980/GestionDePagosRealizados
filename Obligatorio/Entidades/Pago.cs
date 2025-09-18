using Obligatorio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades
{
    public abstract class Pago
    {
        public int Id { get; set; }

        public bool PagoCredito { get; set; }
        public Usuario usuario { get; set; }
        public string Descripcion { get; set; }

        public List<TipoDeGasto> TipoDeGasto { get; set; }

        public Pago(int id, bool pagoCredito, Usuario usuario, string descripcion, List<TipoDeGasto> tipoDeGasto)
        {
            Id = id;
            PagoCredito = pagoCredito;
            this.usuario = usuario;
            Descripcion = descripcion;
            TipoDeGasto = tipoDeGasto;
        }

        public abstract double CalcularMontoPago();
    }

   
}
