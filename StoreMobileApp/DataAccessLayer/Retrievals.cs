namespace StoreMobileApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Retrievals
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Retrievals()
        {
            RetrievalsDetails = new HashSet<RetrievalsDetails>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RetrievalID { get; set; }

        public int OrderID { get; set; }

        [Column(TypeName = "date")]
        public DateTime RetrievaleDate { get; set; }

        [Column(TypeName = "text")]
        public string RetrievalsNotes { get; set; }

        public int UserID { get; set; }

        public virtual Orders Orders { get; set; }

        public virtual Users Users { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RetrievalsDetails> RetrievalsDetails { get; set; }
    }
}
