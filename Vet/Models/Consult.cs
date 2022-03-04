using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using System.Web.Mvc;


namespace Vet.Models
{
    public class Consult
    {
        public int ConsultId { get; set; }

        public int PetId { get; set; }
        public Pet Pet { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Owner name")]
        public string OwnerName { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Pet name")]
        public string PetName { get; set; }

        [Required]
        [Display(Name = "Consult date:   ")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ConsultDate { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Pet weight")]
        public int PetWeight { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Body temperature")]
        public string PetTemperature { get; set; }

        [Required]
        //[StringLength(200)]
        [AllowHtml]
        [Display(Name = "Medical pet chart")]
        public string MedicalChart { get; set; }
    }
}
