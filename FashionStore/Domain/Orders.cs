//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class Orders
    {
        public Orders()
        {
            this.OrderProducts = new HashSet<OrderProducts>();
        }
    
        public int ID { get; set; }
        public System.DateTime Date { get; set; }
        public int Status { get; set; }
        public int Shipping { get; set; }
        public int ShippingMethod { get; set; }
        public Nullable<int> PaymentMethod { get; set; }
        public Nullable<decimal> TotalPay { get; set; }
        public Nullable<bool> Paid { get; set; }
    
        public virtual ICollection<OrderProducts> OrderProducts { get; set; }
        public virtual OrderStatus OrderStatus { get; set; }
        public virtual PaymentMethods PaymentMethods { get; set; }
        public virtual Shipping Shipping1 { get; set; }
        public virtual ShippingMethods ShippingMethods { get; set; }
    }
}
