//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mid_project.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Request
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Request()
        {
            this.Items = new HashSet<Item>();
        }
    
        public int id { get; set; }
        public int restaurant_id { get; set; }
        public System.DateTime expiredAt { get; set; }
        public System.DateTime requestAt { get; set; }
        public Nullable<int> employee_id { get; set; }
        public string status { get; set; }
    
        public virtual Employee Employee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Item> Items { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}
