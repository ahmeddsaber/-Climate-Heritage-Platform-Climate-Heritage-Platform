using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ElementImage:BaseEntity
    {
        
        public int ArchitecturalElementId { get; set; }
        [Required] 
        public string? ImageUrl { get; set; }
        [MaxLength(200)] public string? Caption { get; set; }
        public DateTime UploadedAt { get; set; } = DateTime.UtcNow;

        [ForeignKey("ArchitecturalElementId")]
        public virtual ArchitecturalElement? ArchitecturalElement { get; set; }
    }
}
