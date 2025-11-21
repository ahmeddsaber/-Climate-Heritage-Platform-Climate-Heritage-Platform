using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    // ==================== المستخدم ====================
    public class ApplicationUser : IdentityUser
    {
        [MaxLength(100)]
        public string ?FullNameAr { get; set; }

        [MaxLength(100)]
        public string ?FullNameEn { get; set; }

        [MaxLength(200)]
        public string? Organization { get; set; }

        [MaxLength(100)]
        public string? JobTitle { get; set; }

        public string? ProfileImageUrl { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public bool IsActive { get; set; } = true;

        // Navigation
        public virtual ICollection<DamageReport> ?DamageReports { get; set; }
        public virtual ICollection<ConservationPlan> ?ConservationPlans { get; set; }
    }
}
