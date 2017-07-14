namespace CMRS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MissingPerson")]
    public partial class MissingPerson
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Name Of Reporter")]
        public string NameOfReporter { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Name Of Missing Person")]
        public string NameOfMisPer { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Gender Of Missing Person")]
        public string GenderOfMisPer { get; set; }

        [StringLength(50)]
        [Display(Name = "Age of the Missing Person")]
        public string AgeOfMisPer { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Last Seen Date")]
        public string LastSeenDate { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Point Of Contact")]
        public string PocPer { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Address Of Missing Person")]
        public string AddOfMisPer { get; set; }

        [Required]
        [Display(Name = "Details Of Missing Person")]
        public string DetOfMisPer { get; set; }

        [Display(Name = "Any Suspect?")]
        public bool SuspectValue { get; set; }

        [StringLength(50)]
        [Display(Name = "Suspect Name")]
        public string SuspectName { get; set; }

        [Required]
        [Display(Name = "Suspect Details")]
        public string SuspectDetails { get; set; }

        [Display(Name = "Police Station")]
        public string PoliceStation { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Investigating Officer")]
        public string InvestigatingOff { get; set; }

        [Display(Name = "Report Date")]
        public DateTime ReportDate { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name ="Case Status")]
        public string CaseStatus { get; set; }
    }
}
