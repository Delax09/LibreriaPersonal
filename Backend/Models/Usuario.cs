using System.ComponentModel.DataAnnotations;

namespace AprendizajeSoftware.Models
{
    public class Usuario
    {
        [Key] //Clave primaria
        public int IdUsuario {get; set;}
        public required string Nombre {get; set;} 
        public required string Apellido_Pa {get; set; }
        public required string Apellido_Ma {get; set; }
    }
}