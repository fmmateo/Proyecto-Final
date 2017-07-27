using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoFinalProgramacionIII.Models
{
    public class Proveedor
    {
//(Cod_proveedor, Nombre_Compañia, Nombre_Representante, 
//Apellido_Representante, Sector_Comercial, Teléfono, email, país, ciudad)

        [Key]
        public string Cod_proveedor { get; set; }
//*********************************************************

            [Required(ErrorMessage ="Este campo es Obligatorio")]
        public string Nombre_Compañia { get; set; }
//*********************************************************

            [Required(ErrorMessage = "Este campo es Obligatorio")]
        public string Nombre_Representante { get; set; }
//*********************************************************

            [Required(ErrorMessage = "Este campo es Obligatorio")]
        public string Apellido_Representante { get; set; }
//*********************************************************

            [Required(ErrorMessage = "Este campo es Obligatorio")]
        public string Sector_Comercial { get; set; }
//*********************************************************

            [Required(ErrorMessage = "Este campo es Obligatorio")]
        public int Telefono { get; set; }
//*********************************************************

            [Required(ErrorMessage = "Este campo es Obligatorio")]
        public string Email { get; set; }
//*********************************************************

            [Required(ErrorMessage = "Este campo es Obligatorio")]
        public string Pais { get; set; }
//*********************************************************

            [Required(ErrorMessage = "Este campo es Obligatorio")]
        public string Ciudad { get; set; }

    }
}