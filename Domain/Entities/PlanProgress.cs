using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    // ==================== تقدم خطة الحفاظ ====================
    public class PlanProgress:BaseEntity
    {
       

        [Required]
        public int ConservationPlanId { get; set; }

        [Required, MaxLength(500)]
        public string? UpdateAr { get; set; }

        [MaxLength(500)]
        public string? UpdateEn { get; set; }

        [Range(0, 100)]
        public int ProgressPercentage { get; set; }

       

        [MaxLength(200)]
      

        // Navigation
        [ForeignKey("ConservationPlanId")]
        public virtual ConservationPlan ?ConservationPlan { get; set; }

        public virtual ICollection<ProgressImage>? Images { get; set; }
    }
}
