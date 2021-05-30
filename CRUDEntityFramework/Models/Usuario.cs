using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDEntityFramework.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Required Field")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Required Field")]
        [Display(Name = "Email")]
        public string Correo { get; set; }

        [Required(ErrorMessage = "Required Field")]
        public string Password { get; set; }
    }
}
