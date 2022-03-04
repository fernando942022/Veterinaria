using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Vet.Models
{
    public class Pet
    {
        //Primary key
        public int PetId { get; set; }
        //Foreign key
        public int OwnerId { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        public string Image { get; set; }

        [Required]
        [Display(Name = "Birthday")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Age")]
        public string Age { get; set; }

        [Required]
        [Display(Name = "Sex")]
        [StringLength(20)]
        public string Sex { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Specie")]
        public string Specie { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Race")]
        public string Race { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Color")]
        public string Color { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Weight")]
        public string weight { get; set; }

       
        [Display(Name = "Other Comments")]
        public string Comment { get; set; }

        //Foreign key
        public Owner Owner { get; set; }

    }
}
