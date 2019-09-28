using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TiketeApi.Models
{
    [Table("ticket")]
    public partial class Ticket
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("ticket_no")]
        public string TicketNo { get; set; }
        [Column("category_type")]
        public string CategoryType { get; set; }
        [Column("issue")]
        public string Issue { get; set; }
        [Column("details")]
        public string Details { get; set; }
        [Column("image_path")]
        public string ImagePath { get; set; }
        [Column("time_of_occurence", TypeName = "datetime")]
        public DateTime? TimeOfOccurence { get; set; }
        [Column("citizen")]
        public string Citizen { get; set; }
        [Required]
        [Column("municipal")]
        public string Municipal { get; set; }
        [Column("status")]
        public string Status { get; set; }
        [Column("gov_assigned")]
        public string GovAssigned { get; set; }
        [Column("gov_cause")]
        public string GovCause { get; set; }
        [Column("gov_estimate_start", TypeName = "datetime")]
        public DateTime? GovEstimateStart { get; set; }
        [Column("gov_estimate_end", TypeName = "datetime")]
        public DateTime? GovEstimateEnd { get; set; }
        [Column("citizen_confirmed")]
        public bool? CitizenConfirmed { get; set; }
        [Column("duplicate")]
        public bool? Duplicate { get; set; }
        [Column("parent_id")]
        public int? ParentId { get; set; }
        [Column("remarks")]
        public string Remarks { get; set; }
    }
}