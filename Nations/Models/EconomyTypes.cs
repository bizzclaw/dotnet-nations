using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nations.Models
{
    [Table("EconomyTypes")]
    public class EconomyType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
