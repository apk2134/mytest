namespace BookEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CoustomerSubscription")]
    public partial class CoustomerSubscription
    {
        [Required]
        [StringLength(50)]
        public string CoustomerId { get; set; }

        [Required]
        [StringLength(50)]
        public string SubscriptionId { get; set; }

        [Key]
        [StringLength(50)]
        public string CustomerSubscription { get; set; }

        public int? booksTaken { get; set; }

        public int booksRemaning { get; set; }

        public virtual CoustomerDetail CoustomerDetail { get; set; }

        public virtual Subscription Subscription { get; set; }
    }
}
