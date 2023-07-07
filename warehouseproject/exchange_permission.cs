namespace warehouseproject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class exchange_permission
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int permissionID { get; set; }

        public int? permissionno { get; set; }

        [Column(TypeName = "date")]
        public DateTime? permissiondate { get; set; }

        public int? quantity { get; set; }

        [Column(TypeName = "date")]
        public DateTime? productiondate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? expirydate { get; set; }

        public int? supplierID { get; set; }

        public int? productcode { get; set; }

        public int? warehouseID { get; set; }

        public virtual product product { get; set; }

        public virtual supplier supplier { get; set; }

        public virtual warehouse warehouse { get; set; }
    }
}
