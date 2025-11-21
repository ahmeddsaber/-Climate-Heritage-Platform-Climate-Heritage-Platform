using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PlanDocument:BaseEntity
    {
       
        public int ConservationPlanId { get; set; }
        [Required] 
        public string? FileUrl { get; set; }
        [Required, MaxLength(200)] 
        public string? FileName { get; set; }
        [MaxLength(50)]
        public string ?FileType { get; set; } // PDF, Image, etc.
        public DateTime UploadedAt { get; set; } = DateTime.UtcNow;

        [ForeignKey("ConservationPlanId")]
        public virtual ConservationPlan? ConservationPlan { get; set; }
    }
}
