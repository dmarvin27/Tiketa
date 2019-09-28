using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TiketeApi.Models
{
    [Table("citizen")]
    public partial class Citizen
    {
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("name")]
        [StringLength(100)]
        public string Name { get; set; }
        [Column("age")]
        public int Age { get; set; }
        [Column("years_of_residency")]
        public int YearsOfResidency { get; set; }
        [Column("municipal_id")]
        public int MunicipalId { get; set; }
    }
}