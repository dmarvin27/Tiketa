using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TiketeApi.Models
{
    [Table("municipality")]
    public partial class Municipality
    {
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("municipal")]
        [StringLength(100)]
        public string Municipal { get; set; }
    }
}