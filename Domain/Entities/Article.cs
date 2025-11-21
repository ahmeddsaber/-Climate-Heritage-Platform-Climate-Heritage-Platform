using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    // ==================== إدارة المحتوى ====================
    public class Article:BaseEntity
    {
      
        [Required, MaxLength(200)] 
        public string? TitleAr { get; set; }
        [Required, MaxLength(200)]
        public string ?TitleEn { get; set; }
        [Required] 
        public string ?ContentAr { get; set; }
        public string? ContentEn { get; set; }
        [MaxLength(500)] 
        public string? Summary { get; set; }
        public string? FeaturedImageUrl { get; set; }
        [MaxLength(100)] 
        public string? Category { get; set; }
        public bool IsPublished { get; set; } = false;
        
        public DateTime? PublishedAt { get; set; }
    }
}
