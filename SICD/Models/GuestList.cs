namespace SICD.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GuestList")]
    public partial class GuestList
    {
        [Key]
        public int ListID { get; set; }

        [StringLength(50)]
        public string GuestName { get; set; }

        public string GuestMsg { get; set; }

        public int? Attendee { get; set; }

        [StringLength(50)]
        public string email { get; set; }
    }
}
