using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace zignos.Models
{
    public class Usuario
    {
        [Key]

        public String UsuarioID { get; set; }



        [Required(ErrorMessage = "El Campo {0} es obligatorio")]
        [MaxLength(50, ErrorMessage = "El Campo {0} debe tener una longitud maxima de 50 caracteres")]
        [Display(Name = "Nombre")]
        public String Nombre { get; set; }

        [Required(ErrorMessage = "El Campo {0} es obligatorio")]
        [MaxLength(50, ErrorMessage = "El Campo {0} debe tener una longitud maxima de 50 caracteres")]
        [Display(Name = "Apellido")]
        public String Apellido { get; set; }

        [Required(ErrorMessage = "El Campo {0} es obligatorio")]
        [MaxLength(15, ErrorMessage = "El Campo {0} debe tener una longitud maxima de 15 caracteres")]
        [Display(Name = "Cedula")]
        public String Cedula { get; set; }


        
        [Display(Name = "Fecha de Nacimiento")]
        [Column(TypeName = "date")]
        public DateTime Fecha_Nacimiento { get; set; }


    }
}