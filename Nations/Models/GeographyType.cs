using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nations.Models
{
    [Table("GeographyTypes")]
    public class GeographyType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual IEnumerable<GeographyItem> Items { get; set; } 
    }
}
