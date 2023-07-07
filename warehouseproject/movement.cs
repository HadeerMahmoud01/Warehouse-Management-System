namespace warehouseproject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("movement")]
    public partial class movement
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int movementID { get; set; }

        public int? from_warehouse { get; set; }

        public int? to_warehouse { get; set; }

        public int? quantity { get; set; }

        [Column(TypeName = "date")]
        public DateTime? productiondate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? expirydate { get; set; }

        public int? supplierid { get; set; }

        public int? productid { get; set; }

        public int? warehouseid { get; set; }

        [Column(TypeName = "date")]
        public DateTime? current_date { get; set; }

        public virtual product product { get; set; }

        public virtual supplier supplier { get; set; }

        public virtual warehouse warehouse { get; set; }

        public virtual warehouse warehouse1 { get; set; }

        public virtual warehouse warehouse2 { get; set; }
    }
}
