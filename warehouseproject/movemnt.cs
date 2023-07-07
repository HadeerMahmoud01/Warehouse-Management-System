namespace warehouseproject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("movemnt")]
    public partial class movemnt
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int movemntID { get; set; }

        public int? towarehouseid { get; set; }

        public int? fromwarehouseid { get; set; }

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

        [Column(TypeName = "date")]
        public DateTime? currentdate { get; set; }

        public virtual warehouse warehouse { get; set; }

        public virtual product product { get; set; }

        public virtual supplier supplier { get; set; }

        public virtual warehouse warehouse1 { get; set; }
    }
}
