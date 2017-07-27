using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoFinalProgramacionIII.Models
{
    public class DatosEmpresa
    {
        //(Cod_Empresa, Nombre, Comercio, RNC, teléfono, correo, país, 
        //ciudad, CodigoDI, CódigoOD)

        [Key]
        public int Cod_Empresa { get; set; }
//*********************************************************

            [Required(ErrorMessage ="Esta campo es Obligatorio")]
        public string Nombre { get; set; }
//*********************************************************

            [Required]
        public string Comercio { get; set; }
//*********************************************************

            [Required]
        public string RNC { get; set; }
//*********************************************************

            [Required]
        public int Telefono { get; set; }
//*********************************************************

            [Required]
        public string Correo { get; set; }
//*********************************************************

            [Required]
        public string Pais { get; set; }
//*********************************************************

            [Required]
        public string Ciudad { get; set; }
//*********************************************************

            [Required]
        public int CodigoDI { get; set; }
//*********************************************************

            [Required]
        public int CodigoOD { get; set; }
//*********************************************************

    }
}