using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{

    // ==================== البيانات المناخية ====================
    public class ClimateData : BaseEntity
    {


        public int? HeritageSiteId { get; set; }

        [Required]
        public DateTime RecordedAt { get; set; }

        [Range(-50, 60)]
        public double? Temperature { get; set; } // درجة الحرارة

        [Range(0, 100)]
        public double? Humidity { get; set; } // الرطوبة

        [Range(0, 500)]
        public double? Rainfall { get; set; } // الأمطار (mm)

        [Range(0, 300)]
        public double? WindSpeed { get; set; } // سرعة الرياح (km/h)

        [MaxLength(50)]
        public string? WindDirection { get; set; }

        [Range(0, 500)]
        public double? AirPollutionIndex { get; set; } // مؤشر التلوث

        [MaxLength(100)]
        public string? DataSource { get; set; } // مصدر البيانات

        public bool IsManualEntry { get; set; } = true;

        // Navigation
        [ForeignKey("HeritageSiteId")]
        public virtual HeritageSite? HeritageSite { get; set; }
    }
}
