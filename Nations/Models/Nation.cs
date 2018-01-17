using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nations.Models
{
    [Table("Nations")]
    public class Nation
    {
        [Key]
        public int Id { get; set; }
        public virtual GovernmentType GovernmentType { get; set; }
        public virtual EconomyType EconomyType { get; set; }
        public virtual GeographyType GeographyType { get; set; }
        public int Population { get; set; }
        public decimal Stability { get; set; }
        public virtual IEnumerable<NationItem> Inventory { get; set; }
        public virtual ApplicationUser Owner { get; set; }
    }
}
