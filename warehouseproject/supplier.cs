namespace warehouseproject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("supplier")]
    public partial class supplier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public supplier()
        {
            exchange_permission = new HashSet<exchange_permission>();
            movemnts = new HashSet<movemnt>();
            supply_permission = new HashSet<supply_permission>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int supplierID { get; set; }

        [StringLength(255)]
        public string suppliername { get; set; }

        [StringLength(255)]
        public string phone { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        [StringLength(255)]
        public string mobile { get; set; }

        [StringLength(255)]
        public string fax { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<exchange_permission> exchange_permission { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<movemnt> movemnts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<supply_permission> supply_permission { get; set; }
    }
}
