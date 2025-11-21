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
    public class DamageReport:BaseEntity
    {
       

        [Required]
        public string? UserId { get; set; }

        [Required]
        public int ArchitecturalElementId { get; set; }

        public int? ClimateDataId { get; set; }

        [Required, MaxLength(200)]
        public string? TitleAr { get; set; }

        [Required, MaxLength(200)]
        public string ?TitleEn { get; set; }

        [Required, MaxLength(2000)]
        public string? DescriptionAr { get; set; }

        [MaxLength(2000)]
        public string? DescriptionEn { get; set; }

        [Required]
        public DamageType DamageType { get; set; }

        public DamageSeverity Severity { get; set; } = DamageSeverity.Medium;

        public ReportStatus Status { get; set; } = ReportStatus.Pending;

        public DateTime ReportedAt { get; set; } = DateTime.UtcNow;

        public DateTime? DamageObservedAt { get; set; }

        [MaxLength(1000)]
        public string? AdminNotes { get; set; }

        // Navigation
        [ForeignKey("UserId")]
        public virtual ApplicationUser? User { get; set; }

        [ForeignKey("ArchitecturalElementId")]
        public virtual ArchitecturalElement? ArchitecturalElement { get; set; }

        [ForeignKey("ClimateDataId")]
        public virtual ClimateData? ClimateData { get; set; }

        public virtual ICollection<DamageImage>? Images { get; set; }
        public virtual ICollection<ConservationPlan> ?ConservationPlans { get; set; }
    }
}
