namespace AvailableCars.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Car
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Car()
        {
            Reservations = new HashSet<Reservation>();
        }

        public int CarID { get; set; }

        [Required]
        [StringLength(10)]
        public string Plate { get; set; }

        [Required]
        [StringLength(30)]
        public string Manufacturer { get; set; }

        [Required]
        [StringLength(50)]
        public string Model { get; set; }

        [Column(TypeName = "money")]
        public decimal PricePerDay { get; set; }

        public int LocationID { get; set; }

        public virtual Location Location { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
