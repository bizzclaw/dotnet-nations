﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Nations.Models
{
    [Table("NationItem")]
    public class NationItem
    {
        [Key]
        public int Id { get; set; }
        public virtual Nation Owner { get; set; }
        public virtual Item Item { get; set; }
        public int Amount { get; set; }
    }
}
