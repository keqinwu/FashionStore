//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customers
    {
        public Customers()
        {
            this.Shipping = new HashSet<Shipping>();
        }
    
        public int ID { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        private bool gender { get; set; }
        public string Password { get; set; }
    
        public virtual ICollection<Shipping> Shipping { get; set; }
    }
}
