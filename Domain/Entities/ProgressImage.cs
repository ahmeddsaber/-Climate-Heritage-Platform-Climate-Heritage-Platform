using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ProgressImage:BaseEntity
    {
        
        public int PlanProgressId { get; set; }
        [Required]
        public string ?ImageUrl { get; set; }
        [MaxLength(200)]
        public string? Caption { get; set; }

        [ForeignKey("PlanProgressId")]
        public virtual PlanProgress ?PlanProgress { get; set; }
    }
}
