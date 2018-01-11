namespace BookEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BooksAuthor
    {
        [Required]
        [StringLength(50)]
        public string AuthorId { get; set; }

        [Required]
        [StringLength(50)]
        public string BookId { get; set; }

        [Key]
        [StringLength(50)]
        public string BookAuthorid { get; set; }

        public virtual Author Author { get; set; }

        public virtual Book Book { get; set; }
    }
}
