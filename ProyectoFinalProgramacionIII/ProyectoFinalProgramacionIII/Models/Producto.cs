using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoFinalProgramacionIII.Models
{
    public class Producto
    {
      //(Código, nombre, precio_compra, precio_venta, cantidad, cantida_minima, categoría, marca, Cod_proveedor)

        [Key]
        public int Codigo { get; set; }
//*********************************************************

            [Required(ErrorMessage ="Este Campo es Obligatorio")]
        public string Nombre { get; set; }
//*********************************************************

        [Required(ErrorMessage = "Este Campo es Obligatorio")]
        public int Precio_compra { get; set; }
//*********************************************************

            [Required(ErrorMessage = "Este Campo es Obligatorio")]
        public int Precio_venta { get; set; }
//*********************************************************

            [Required(ErrorMessage = "Este Campo es Obligatorio")]
        public int Cantidad { get; set; }
//*********************************************************

            [Required(ErrorMessage = "Este Campo es Obligatorio")]
        public int Cantidad_minima { get; set; }
//*********************************************************

            [Required(ErrorMessage = "Este Campo es Obligatorio")]
        public string Categoria { get; set; }
//*********************************************************

            [Required(ErrorMessage = "Este Campo es Obligatorio")]
        public string Marca { get; set; }
//*********************************************************

            [Required(ErrorMessage = "Este Campo es Obligatorio")]
        public int Cod_proveedor { get; set; }
        //*********************************************************

        public virtual List<Cliente> Clientes{ get; set; }
        public virtual List<No_Factura> No_Facturas{ get; set; }
        public virtual List<No_Compra> No_Compras { get; set; }

    }
}