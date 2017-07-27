using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinalProgramacionIII.Models
{
    public class Cliente
    {
        // (Código, nombre, apellido, cedula, teléfono, ciudad, email)

        [Key]
        public int Codigo { get; set; }
//*********************************************************

            [Required(ErrorMessage ="Este campo es obligatorio")]
        public string Nombre { get; set; }
//*********************************************************

            [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Apellido { get; set; }
//*********************************************************

            [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Cedula { get; set; }
//*********************************************************

            [Required(ErrorMessage = "Este campo es obligatorio")]
        public int Telefono { get; set; }  
//*********************************************************

            [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Ciudad { get; set; }
//*********************************************************

            [EmailAddress]
            [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
//*********************************************************

        public virtual List<Producto> Productos{ get; set; }

        

    }
}