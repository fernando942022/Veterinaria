using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vet.Models;
using System.ComponentModel.DataAnnotations;

namespace Vet.Models
{
    public class Pay
    {
        public int PayId { get; set; }

        public int ConsultId { get; set; }
        public Consult Consult { get; set; }

        [Required]
        [Display(Name = "Payment date:   ")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime PaymentDate { get; set; }

        [Required]
        [Display(Name = "Payment amount")]
        public int PaymentAmount { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Payment Type")]
        public string PaymentType { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Status")]
        public string Status { get; set; }
    }
}
