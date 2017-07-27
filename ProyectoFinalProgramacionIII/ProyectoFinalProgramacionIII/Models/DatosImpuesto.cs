using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoFinalProgramacionIII.Models
{
    public class DatosImpuesto
    {
        //(codigoDI, Nom_Impuesto, Porciento_ITBIS, Punto_Venta, símbolo_Moneda,
        //identificación_tributaria, símbolo_moneda, IngresoBruto, cod_frenteIVA)

        [Key]
        public int CodigoDI { get; set; }
//*********************************************************

            [Required]
        public string Nom_Impuesto { get; set; }
//*********************************************************

            [Required]
        public int Porciento_ITBIS { get; set; }
//*********************************************************

            [Required]
        public int Punto_Venta { get; set; }
//*********************************************************

            [Required]
        public string Simbolo_moneda { get; set; }
//*********************************************************

            [Required]
        public string Identificacion_Tributaria { get; set; }
//*********************************************************

            [Required]
        public int IngresoBruto { get; set; }
//*********************************************************

            [Required]
        public int Cod_FrenteIVA { get; set; }

    }
}