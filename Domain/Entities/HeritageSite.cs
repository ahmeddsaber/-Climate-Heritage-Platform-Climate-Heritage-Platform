using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    // ==================== الموقع الأثري ====================
    public class HeritageSite:BaseEntity
    {
     

        [Required, MaxLength(200)]
        public string? NameAr { get; set; }

        [Required, MaxLength(200)]
        public string? NameEn { get; set; }

        [MaxLength(1000)]
        public string? DescriptionAr { get; set; }

        [MaxLength(1000)]
        public string? DescriptionEn { get; set; }

        [Required, MaxLength(100)]
        public string ?Governorate { get; set; } // المحافظة

        [MaxLength(200)]
        public string? Address { get; set; }

        public double? Latitude { get; set; }

        public double? Longitude { get; set; }

        public int? ConstructionYear { get; set; }

        [MaxLength(100)]
        public string? HistoricalPeriod { get; set; } // الحقبة التاريخية

        public string? MainImageUrl { get; set; }

        public SiteStatus Status { get; set; } = SiteStatus.Active;

      

        // Navigation
        public virtual ICollection<ArchitecturalElement> ?ArchitecturalElements { get; set; }
        public virtual ICollection<SiteImage> ?Images { get; set; }
    }
}
