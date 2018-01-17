using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Nations.Models
{
    [Table("NationItem")]
    public class NationItem
    {
        public virtual Nation Owner { get; set; }
        public virtual Item Item { get; set; }
        public int Amount { get; set; }
    }
}
