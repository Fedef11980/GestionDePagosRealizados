using LogicaNegocio.ValuesObjects;
using Obligatorio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades
{
    public class Recurrente : Pago 
    {

        public Periodo Periodo { get; set; }
        public Recurrente(int id, bool pagoCredito, Usuario usuario, string descripcion, List<TipoDeGasto> tipoDeGasto, Periodo periodo) : 
            base(id, pagoCredito, usuario, descripcion, tipoDeGasto)
        {
           Periodo = periodo;

        }

        public override double CalcularMontoPago()
        {
            throw new NotImplementedException();
        }


    }
}
