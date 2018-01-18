using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Nations.Models
{
    [Table("GeographyItem")]
    public class GeographyItem
    {
        public int Id { get; set; }
        public virtual GeographyType Geography { get; set; }
        public virtual Item Item { get; set; }
        public decimal Multiplier { get; set; }
    }
}
