namespace StoreMobileApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Devices
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Devices()
        {
            OrdersDetails = new HashSet<OrdersDetails>();
            SuppliesDetails = new HashSet<SuppliesDetails>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DeviceID { get; set; }

        [Required]
        public string DeviceBarcode { get; set; }

        [Required]
        public string DeviceName { get; set; }

        public decimal DevicePrice { get; set; }

        public int DeviceQuantity { get; set; }

        [Column(TypeName = "text")]
        public string DeviceNotes { get; set; }

        public int BrandID { get; set; }

        public virtual Brands Brands { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdersDetails> OrdersDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SuppliesDetails> SuppliesDetails { get; set; }
    }
}
