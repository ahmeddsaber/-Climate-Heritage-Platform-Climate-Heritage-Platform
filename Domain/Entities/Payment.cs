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
    // ==================== المدفوعات ====================
    public class Payment:BaseEntity
    {
      
        [Required] 
        public string UserId { get; set; }
        [Required, MaxLength(100)] 
        public string ?PayPalTransactionId { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }
        [MaxLength(10)] public string Currency { get; set; } = "USD";
        [MaxLength(200)] public string? Description { get; set; }
        public PaymentStatus Status { get; set; } = PaymentStatus.Pending;
      
        public DateTime? CompletedAt { get; set; }

        [ForeignKey("UserId")]
        public virtual ApplicationUser? User { get; set; }
    }
}
