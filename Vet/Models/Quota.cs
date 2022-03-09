using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Vet.Models
{
    public class Quota
    {
        public int QuotaId { get; set; }

        public int PayId { get; set; }
        public Pay Pay { get; set; }

        [Required]
        [Display(Name = "Quota date:   ")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime QuotaDate { get; set; }

        [Required]
        [Display(Name = "Total")]
        public int Total { get; set; }

        [Required]
        [Display(Name = "Payment amount")]
        public int PaymentAmount { get; set; }

        [Required]
        [Display(Name = "Rest")]
        public int Rest { get; set; }

    }
}
