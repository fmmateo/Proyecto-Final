using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoFinalProgramacionIII.Models
{
    public class FacturaCompra
    {
   //(No_Compra, detalle_producto, cantidad, PrecioUnitario, descuento, ITBIS, 
   //SubTotal_Neto, SubTotal, Fecha, Cod_Empresa)

        [Key]
        public int No_Compra { get; set; }
//*********************************************************

            [Required]
        public string Detalle_Producto { get; set; }
//*********************************************************

            [Required]
        public int Cantidad { get; set; }
//*********************************************************

            [Required]
        public int PrecioUnitario { get; set; }
//*********************************************************

            [Required]
        public int Descuento { get; set; }
//*********************************************************

            [Required]
        public int ITBIS { get; set; }
//*********************************************************

            [Required]
        public int SubTotal_Neto { get; set; }
//*********************************************************

            [Required]
        public int SubTotal { get; set; }
//*********************************************************

            [Required]
        public int Fecha { get; set; }
//*********************************************************

            [Required]
        public int Cod_Empresa { get; set; }
//*********************************************************

        public virtual List<Cod_Producto> Cod_Productos { get; set; }

    }
}