using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace WebApp4ByNishan.Models
{
    public class Product
    {
        [Key]
        [Required]
        // Here, "product_id" is the name of column which will be set in the databse
        [Column("Id", Order = 0)]
        public int Id { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public double Price { get; set; }

        [StringLength(500, MinimumLength = 2)]
        public string Description { get; set; }
    }
}
