namespace BookEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CoustomerOrder")]
    public partial class CoustomerOrder
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string OrderId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string CoustomerId { get; set; }

        public DateTime OrderDate { get; set; }

        public virtual CoustomerDetail CoustomerDetail { get; set; }
    }
}
