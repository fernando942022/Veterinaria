using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Vet.Models
{
    public class Owner
    {
        //Foreign key
        public int OwnerId { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name= "NameOwner")]
        public string NameOwner { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Home address")]
        public string HomeAddress { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Cellphone")]
        public string Cellphone { get; set; }
    }
}
