using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Inverter
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InverterId { get; set; }

        public string Name { get; set; } = string.Empty;

        public string State { get; set; } = string.Empty;
    }
}
