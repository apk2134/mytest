namespace BookEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BookCategory")]
    public partial class BookCategory
    {
        [Required]
        [StringLength(50)]
        public string CategoryId { get; set; }

        [Required]
        [StringLength(50)]
        public string BookId { get; set; }

        [Key]
        [Column("BookCategory")]
        [StringLength(50)]
        public string BookCategory1 { get; set; }

        public virtual Book Book { get; set; }

        public virtual Category Category { get; set; }
    }
}
