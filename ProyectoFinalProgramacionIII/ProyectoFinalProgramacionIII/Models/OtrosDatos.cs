using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoFinalProgramacionIII.Models
{
    public class OtrosDatos
    {
        //(códigoOD, logo, eslogan)

        [Key]
        public string CodigoOD { get; set; }
//*********************************************************

            [Required]
        public string Logo { get; set; }
//*********************************************************

            [Required]
        public string Eslogan { get; set; }
    }
}