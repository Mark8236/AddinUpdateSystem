//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AddinUpdateSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductVersion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductVersion()
        {
            this.T_ProductModule = new HashSet<ProductModule>();
        }
    
        public long ID { get; set; }
        public long ProductID { get; set; }
        public int Major { get; set; }
        public int Minor { get; set; }
        public int Build { get; set; }
        public int Revision { get; set; }
        public bool IsBeta { get; set; }
        public string Description { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public System.DateTime ChangedTime { get; set; }
    
        public virtual Product T_Product { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductModule> T_ProductModule { get; set; }
    }
}
