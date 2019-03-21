namespace TestDatabase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CartItem")]
    public partial class CartItem
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public int Amount { get; set; }

        public int UserId { get; set; }

        public decimal SubTotal { get; set; }

        public virtual Product Product { get; set; }

        public virtual User User { get; set; }
    }
}
