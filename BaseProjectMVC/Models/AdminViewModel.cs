using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace IdentitySample.Models
{
    public class RoleViewModel
    {
        public string Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "RoleName")]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false)]
        [StringLength(500)]
        [Display(Name= "Descripción")]
        public string Descripcion { get; set; }
    }

    public class EditUserViewModel
    {
        public string Id { get; set; }

        //[Required]
        [Display(Name = "Identidad")]
        [StringLength(20, ErrorMessage = "El campo {0} debe tener una longitud máxima de {1}")]
        public string Identidad { get; set; }

        [Required]
        [Display(Name = "Primer nombre")]
        [StringLength(128, ErrorMessage = "El campo {0} debe tener una longitud máxima de {1}")]
        public string PrimerNombre { get; set; }

        [Required]
        [Display(Name = "Segundo nombre")]
        [StringLength(128, ErrorMessage = "El campo {0} debe tener una longitud máxima de {1}")]
        public string SegundoNombre { get; set; }

        [Required]
        [Display(Name = "Primer apellido")]
        [StringLength(128, ErrorMessage = "El campo {0} debe tener una longitud máxima de {1}")]
        public string PrimerApellido { get; set; }

        [Required]
        [Display(Name = "Segundo apellido")]
        [StringLength(128, ErrorMessage = "El campo {0} debe tener una longitud máxima de {1}")]
        public string SegundoApellido { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha de nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        public IEnumerable<SelectListItem> RolesList { get; set; }
    }
}