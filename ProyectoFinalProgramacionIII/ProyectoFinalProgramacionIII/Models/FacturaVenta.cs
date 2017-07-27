using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoFinalProgramacionIII.Models
{
    public class FacturaVenta
    {
//(No_factura, detalleProdcuto, Cantidad, PrecioUnitario, Descuento,
//ITBIS, SubTotal_Neto, SubTotal, fecha, Cod_Cliente, Cod_user, Cod_Empresa)

        [Key]
        public int No_Factura { get; set; }
//*********************************************************

            [Required(ErrorMessage ="Este campo es Obligatorio")]
        public string DetalleProducto { get; set; }
//*********************************************************

                [Required]
        public int Cantida { get; set; }
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
        public int Fecha { get; set; }
//*********************************************************

            [Required]
        public int Cod_Cliente { get; set; }
//*********************************************************

            [Required]
        public int Cod_User { get; set; }
//*********************************************************

            [Required]
        public int Cod_Empresa { get; set; }
        //*********************************************************

        public virtual List<Cod_Producto> Cod_Productos { get; set; }
    }
}