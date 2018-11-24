using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.Data.Entity; // Has to be installed via Tools > NuGet Package Manater, then enter command Install-Package EntityFramework

namespace VesselCrudProject.Models
{
    public class Vessel
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Vessel Name")]
        public string s_vessel_name { get; set; }
        [Display(Name = "Brand ID")]
        public int n_brand_x { get; set; } = 1;
        [Required]
        [StringLength(50)]
        [Display(Name = "Profit Center")]
        public string s_profit_center { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Vessel IMO Number")]
        public string s_imo_number { get; set; }
        [Required]
        [Display(Name = "Vessel Type IDX")]
        public int n_vessel_type_idx { get; set; }
        [Display(Name = "Vessel Type VType")]
        public IEnumerable<SelectListItem> Vessels { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Start Date")]
        public DateTime d_start_date { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "End Date")]
        public Nullable<DateTime> d_end_date { get; set; }
        [Display(Name = "US Invoiced Vessel")]
        public bool b_us_ar { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Vessel Call Sign")]
        public string s_callsign { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Vessel Email Address")]
        public string s_vessel_email_address { get; set; }
    }

    public class VesselDBContext : DbContext
    {
        public DbSet<Vessel> Vessels { get; set; }
    }

}