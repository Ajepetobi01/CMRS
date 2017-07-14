namespace CMRS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;


    public partial class Convict
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name ="Name Of Convict")]
        public string ConvictName { get; set; }

        [Display(Name ="Convict's Age")]
        public int ConvictAge { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name= "Crime Commmited")]
        public string Offense { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name ="Case Status")]
        public string CaseStatus { get; set; }

        [Display(Name ="Jail Term")]
        [Required]
        public int? JailTerm { get; set; }

        [Display(Name ="Start Date")]
        [Required]
        public DateTime? StartDate { get; set; }

        [Display(Name ="End Date")]
        [Required]
        public DateTime? EndDate { get; set; }

        [StringLength(50)]
        [Display(Name ="Name Of Prison")]
        [Required]
        public string PrisonName { get; set; }


        public byte[] Image { get; set; }
    }
}
