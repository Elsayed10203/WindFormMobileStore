namespace StoreMobileApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Supplies
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Supplies()
        {
            SuppliesDetails = new HashSet<SuppliesDetails>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SupplyID { get; set; }

        [Column(TypeName = "date")]
        public DateTime SupplyDate { get; set; }

        public decimal SupplyTotalPrice { get; set; }

        public int SupplierID { get; set; }

        public int UserID { get; set; }

        [Column(TypeName = "text")]
        public string SupplyNotes { get; set; }

        public virtual Suppliers Suppliers { get; set; }

        public virtual Users Users { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SuppliesDetails> SuppliesDetails { get; set; }
    }
}
