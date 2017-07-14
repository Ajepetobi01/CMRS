namespace CMRS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Admin")]
    public partial class Admin
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        [Display(Name="Full Name")]
        public string Name { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        [Display(Name= "Username")]
        public string Username { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        [Display(Name="Password")]
        public string Password { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name ="Admin Level")]
        public int AdminLevel { get; set; }
    }
}
