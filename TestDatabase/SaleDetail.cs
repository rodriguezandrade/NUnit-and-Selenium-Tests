namespace TestDatabase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SaleDetail")]
    public partial class SaleDetail
    {
        public int Id { get; set; }

        public decimal Amount { get; set; }

        public decimal subTotal { get; set; }

        public int ProductId { get; set; }

        public int SaleId { get; set; }

        public virtual Product Product { get; set; }

        public virtual Sale Sale { get; set; }
    }
}
