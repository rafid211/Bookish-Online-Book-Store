//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_ATP2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.DeliveryTasks = new HashSet<DeliveryTask>();
            this.OrderDatas = new HashSet<OrderData>();
            this.OrderLogs = new HashSet<OrderLog>();
        }
    
        public int Id { get; set; }
        public int User_Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Area { get; set; }
        public string Address { get; set; }
        public string Status { get; set; }
        public string ProcessedBy { get; set; }
        public string DeliveredBy { get; set; }
        public System.DateTime AddedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> Coupon_Id { get; set; }
    
        public virtual Coupon Coupon { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DeliveryTask> DeliveryTasks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderData> OrderDatas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderLog> OrderLogs { get; set; }
        public virtual User User { get; set; }
    }
}
