using LogicaNegocio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio.Entities
{
    public class Equipo : IValidable
    {  

        public int Id { get; set; }
        public string Nombre { get; set; }
        public Equipo(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        public void Validar()
        {
            throw new NotImplementedException();
        }


    }
}
