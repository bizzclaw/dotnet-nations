using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nations.Models
{
    [Table("GovernmentTypes")]
    public class GovernmentType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
