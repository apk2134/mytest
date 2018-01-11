namespace BookEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PaymentDetail
    {
        [Key]
        [StringLength(50)]
        public string PaymentId { get; set; }

        [Required]
        [StringLength(50)]
        public string CoustomerId { get; set; }

        [Required]
        [StringLength(50)]
        public string PaymentSatus { get; set; }

        public DateTime PaymentDate { get; set; }

        public virtual CoustomerDetail CoustomerDetail { get; set; }
    }
}
