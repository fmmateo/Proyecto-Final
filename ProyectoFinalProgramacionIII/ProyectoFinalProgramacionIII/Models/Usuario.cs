using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoFinalProgramacionIII.Models
{
    public class Usuario
    {
        //Cod_user, NickName, clave, nombre, apellido, cedula, correo, ciudad, teléfono, rol)

        [Key]
        public int Cod_user { get; set; }
//*********************************************************
        
            [Required(ErrorMessage = "Este campo es obligatorio")]
        public string NickName { get; set; }
//*********************************************************

            [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Clave { get; set; }
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

        [EmailAddress]//si no tiene el formato de correo no funciona
        [DataType(DataType.EmailAddress)]   //asocia los datos para el email
        public string Correo { get; set; }
 //********************************************************      

            [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Ciudad { get; set; }
//*********************************************************

            [Required(ErrorMessage = "Este campo es obligatorio")]
        public int Telefono { get; set; }
//*********************************************************

            [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Rol { get; set; }
    }
}