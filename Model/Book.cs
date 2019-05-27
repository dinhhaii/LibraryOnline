namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        public int id { get; set; }

        [StringLength(250)]
        public string name { get; set; }

        [StringLength(250)]
        public string category { get; set; }

        public int? amount { get; set; }

        public float? price { get; set; }

        [StringLength(250)]
        public string author { get; set; }

        [Column(TypeName = "date")]
        public DateTime? publicationdate { get; set; }

        [StringLength(250)]
        public string publishcompany { get; set; }

        [StringLength(50)]
        public string size { get; set; }
    }
}
