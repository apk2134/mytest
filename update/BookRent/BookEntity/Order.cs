namespace BookEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string OrderId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string BookId { get; set; }

        public int quantity { get; set; }

        public virtual Book Book { get; set; }
    }
}
