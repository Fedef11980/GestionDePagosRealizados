using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio.Entities
{
    public class Usuario    {
        
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public TipoRol _tipoRol {  get; set; }

        public Usuario(int id, string nombre, string apellido, string password, string email, TipoRol tipoRol)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Password = password;
            Email = email;
            _tipoRol = tipoRol;
        }


    }
}
