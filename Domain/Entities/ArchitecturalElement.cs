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
    // ==================== العنصر المعماري ====================
    public class ArchitecturalElement:BaseEntity
    {
       

        [Required]
        public int HeritageSiteId { get; set; }

        [Required, MaxLength(200)]
        public string? NameAr { get; set; }

        [Required, MaxLength(200)]
        public string ?NameEn { get; set; }

        [MaxLength(500)]
        public string? DescriptionAr { get; set; }

        [MaxLength(500)]
        public string? DescriptionEn { get; set; }

        [Required]
        public MaterialType MaterialType { get; set; } // نوع المادة

        public ElementCondition CurrentCondition { get; set; } = ElementCondition.Good;

        [MaxLength(200)]
        public string? Location { get; set; } // موقعه داخل المبنى

        

        public DateTime? LastInspectionDate { get; set; }

        // Navigation
        [ForeignKey("HeritageSiteId")]
        public virtual HeritageSite? HeritageSite { get; set; }
        public virtual ICollection<ElementImage> ?Images { get; set; }
        public virtual ICollection<DamageReport>? DamageReports { get; set; }
    }
}
