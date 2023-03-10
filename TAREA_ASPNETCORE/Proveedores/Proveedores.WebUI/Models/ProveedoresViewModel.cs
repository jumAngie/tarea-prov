using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proveedores.WebUI.Models
{
    public class ProveedoresViewModel
    {
        [Display(Name="Proveedor ID")]
        public int prov_ID { get; set; }

        [Display(Name = "Nombre de la Empresa")]
        [Required(ErrorMessage = "*")]
        public string prov_Empresa { get; set; }

        [Display(Name = "Nombre del Contacto")]
        [Required(ErrorMessage = "*")]
        public string prov_NombreContacto { get; set; }

        [Display(Name = "Telefono del Contacto")]
        [Required(ErrorMessage = "*")]
        public string prov_TelefonoContacto { get; set; }

        [Display(Name = "Direccion Exacta del Contacto")]
        [Required(ErrorMessage = "*")]
        public string prov_DireccionExacta { get; set; }

        [Display(Name = "Direccion Exacta de la Empresa")]
        [Required(ErrorMessage = "*")]
        public string prov_DireccionExactaEmpresa { get; set; }

        [Display(Name = "Sexo del Contacto")]
        [Required(ErrorMessage = "*")]
        public string prov_SexoContacto { get; set; }
    }
}
