using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    // ==================== خطة الحفاظ ====================
    public class ConservationPlan:BaseEntity
    {
        

        [Required]
        public int DamageReportId { get; set; }

       
        

        [Required, MaxLength(200)]
        public string ?TitleAr { get; set; }

        [Required, MaxLength(200)]
        public string ?TitleEn { get; set; }

        [Required, MaxLength(3000)]
        public string ?DescriptionAr { get; set; }

        [MaxLength(3000)]
        public string? DescriptionEn { get; set; }

        [MaxLength(2000)]
        public string? ProposedMethodsAr { get; set; } // الأساليب المقترحة

        [MaxLength(2000)]
        public string? ProposedMethodsEn { get; set; }

        [MaxLength(1000)]
        public string? RequiredMaterials { get; set; } // المواد المطلوبة

        [Column(TypeName = "decimal(18,2)")]
        public decimal? EstimatedCost { get; set; }

        public int? EstimatedDurationDays { get; set; }

        public PlanStatus Status { get; set; } = PlanStatus.Draft;

        public PlanPriority Priority { get; set; } = PlanPriority.Medium;

       

        public DateTime? ApprovedAt { get; set; }

        public DateTime? StartedAt { get; set; }

        public DateTime? CompletedAt { get; set; }

        [Range(1, 5)]
        public int? UserRating { get; set; } // تقييم المستخدم

        [MaxLength(500)]
        public string? UserFeedback { get; set; }

        // Navigation
        [ForeignKey("DamageReportId")]
        public virtual DamageReport? DamageReport { get; set; }

        [ForeignKey("CreatedByUserId")]
        

        public virtual ICollection<PlanDocument> ?Documents { get; set; }
        public virtual ICollection<PlanProgress>? ProgressUpdates { get; set; }
    }
}
