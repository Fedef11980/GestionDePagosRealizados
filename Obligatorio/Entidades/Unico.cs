using Obligatorio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades
{
    public class Unico : Pago
    {
        public DateTime FechaPago { get; set; }
        public int Recibo { get; set; }

        public Unico (int id, bool pagoCredito, Usuario usuario, string descripcion, List<TipoDeGasto> tipoDeGasto,DateTime fechaPago, int recibo) : 
            base (id, pagoCredito, usuario, descripcion, tipoDeGasto)
        {
            FechaPago = fechaPago;
            Recibo = recibo;
        }

        public override double CalcularMontoPago()
        {
            throw new NotImplementedException();
        }
    }
}
