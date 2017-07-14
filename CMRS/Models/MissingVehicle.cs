namespace CMRS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MissingVehicle")]
    public partial class MissingVehicle
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Name Of Reporter")]
        public string NameOfRep { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Type Of Vehicle")]
        public string VehicleType { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Name Of Vehicle Owner")]
        public string NameOfOwner { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Name Of Vehicle")]
        public string NameOfVehicle { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name ="Registration Number")]
        public string RegNumber { get; set; }

        [Required]
        [StringLength(60)]
        [Display(Name ="Chasis Number")]
        public string ChasisNumb { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name ="Vehicle Color")]
        public string Color { get; set; }

        [Display(Name ="Last Seen Date")]
        public DateTime LastSeenDate { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name ="Last Seen Location")]
        public string LastSeenLoc { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name ="Description")]
        public string Description { get; set; }

        [Display(Name ="Police Station")]
        public string PoliceStation { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name ="Investigating Officer")]
        public string InvestigationOff { get; set; }

        [Display(Name ="Report Date")]
        public DateTime ReportDate { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name ="Case Status")]
        public string CaseStatus { get; set; }
    }
}
