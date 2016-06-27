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
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.T_ProductModule = new HashSet<ProductModule>();
            this.T_ProductVersion = new HashSet<ProductVersion>();
        }
    
        public long ID { get; set; }
        public string Name { get; set; }
        public bool CanSilent { get; set; }
        public bool HasPrivilege { get; set; }
        public string PreRunCommand { get; set; }
        public string PostRunCommand { get; set; }
        public string AppPreCondition { get; set; }
        public string GacableAssemblies { get; set; }
        public string UnGacableAssemblies { get; set; }
        public string Description { get; set; }
    
        public virtual Product T_Product1 { get; set; }
        public virtual Product T_Product2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductModule> T_ProductModule { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductVersion> T_ProductVersion { get; set; }
    }
}