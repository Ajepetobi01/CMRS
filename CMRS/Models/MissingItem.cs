namespace CMRS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MissingItem
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Name Of Reporter")]
        public string NameOfRep { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Name Of Item Owner")]
        public string NameOfOwner { get; set; }

        [Required]
        [Display(Name = "Full Description")]
        public string Description { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Last Seen Location")]
        public string LastSeenLoc { get; set; }
        [Display(Name = "Last Seen Date")]
        public DateTime LastSeenDate { get; set; }

        [Display(Name = "Police Station")]
        public string PoliceStation { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Investigating Officer")]
        public string InvestigatingOff { get; set; }

        [Display(Name = "Date Of Report")]
        public DateTime ReportDate { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name ="Case Status")]
        public string CaseStatus { get; set; }
    }
}
