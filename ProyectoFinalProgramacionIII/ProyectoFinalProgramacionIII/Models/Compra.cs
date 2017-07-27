using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoFinalProgramacionIII.Models
{
    public class Compra
    {
        //(No_FactCompra, fecha, Total, Cod_proveedor)

            [Key]
        public int No_FactCompra { get; set; }
//*********************************************************

            [Required(ErrorMessage ="Este Campo es Obligatorio")]
        public int Fecha { get; set; }
//*********************************************************

            [Required(ErrorMessage ="Este Campo es Obligatorio")]
        public int Total { get; set; }
//*********************************************************
        public int Cod_Proveedor { get; set; }
    }
}