using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enums
{
   
        public enum SiteStatus { Active, UnderRestoration, Closed, Demolished }
    public enum MaterialType
    {
        Stone,          // حجر
        Brick,          // طوب
        Wood,           // خشب
        Metal,          // معدن
        Plaster,        // جص
        Marble,         // رخام
        Ceramic,        // سيراميك
        Glass,          // زجاج
        Concrete,       // خرسانة
        Mixed           // مختلط
    }

    public enum ElementCondition { Excellent, Good, Fair, Poor, Critical }
    public enum DamageType
    {
        Cracks,             // تشققات
        Erosion,            // تآكل
        Discoloration,      // تغير اللون
        Efflorescence,      // تملح
        Biological,         // بيولوجي (طحالب/فطريات)
        Structural,         // إنشائي
        WaterDamage,        // أضرار مياه
        WindDamage,         // أضرار رياح
        PollutionDamage,    // أضرار تلوث
        ThermalDamage,      // أضرار حرارية
        Other               // أخرى
    }

    public enum DamageSeverity { Minor, Medium, Severe, Critical }

    public enum ReportStatus { Pending, UnderReview, Approved, Rejected, Resolved }
    public enum PlanStatus { Draft, Proposed, Approved, InProgress, Completed, Cancelled }

    public enum PlanPriority { Low, Medium, High, Urgent }
    public enum PaymentStatus { Pending, Completed, Failed, Refunded }

}
