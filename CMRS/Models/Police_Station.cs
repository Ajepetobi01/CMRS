namespace CMRS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Police_Station
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name ="State")]
        public string State { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name ="State Branch")]
        public string Branch { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name ="Branch Contact")]
        public string Contact { get; set; }
    }
}
