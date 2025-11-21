using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class DamageImage:BaseEntity
    {
        
        public int DamageReportId { get; set; }
        [Required]
        public string? ImageUrl { get; set; }
        [MaxLength(200)] public string? Caption { get; set; }
        public DateTime UploadedAt { get; set; } = DateTime.UtcNow;

        [ForeignKey("DamageReportId")]
        public virtual DamageReport? DamageReport { get; set; }
    }
}
