namespace warehouseproject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("customer")]
    public partial class customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int customerID { get; set; }

        [StringLength(255)]
        public string customername { get; set; }

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
    }
}
