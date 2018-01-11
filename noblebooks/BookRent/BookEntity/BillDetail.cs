namespace BookEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BillDetail
    {
        [Key]
        [StringLength(50)]
        public string BillId { get; set; }

        [Required]
        [StringLength(50)]
        public string CoustomerId { get; set; }

        [Required]
        [StringLength(50)]
        public string SubscriptionId { get; set; }

        public DateTime RenualDate { get; set; }

        public virtual CoustomerDetail CoustomerDetail { get; set; }

        public virtual Subscription Subscription { get; set; }
    }
}
