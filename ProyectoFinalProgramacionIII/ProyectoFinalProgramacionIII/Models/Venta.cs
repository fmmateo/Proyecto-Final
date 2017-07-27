using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoFinalProgramacionIII.Models
{
    public class Venta
    {
        //(NoFactVenta, fecha, estado, total, Cod_Cliente)

        [Key]
        public int NoFactVenta { get; set; }
//*********************************************************

            [Required(ErrorMessage ="Este Campo es Obligatorio")]
        public int Fecha { get; set; }
//*********************************************************

            [Required(ErrorMessage ="Este Campo es Obligatorio")]
        public int Estado { get; set; }
//*********************************************************

            [Required(ErrorMessage ="Este Campo es Obligatorio")]
        public int Total { get; set; }
//*********************************************************
        public int Cod_Cliente { get; set; }

    }
}