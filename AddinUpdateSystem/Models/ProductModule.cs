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
    
    public partial class ProductModule
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Uri { get; set; }
        public long ProductID { get; set; }
        public long VersionID { get; set; }
        public System.DateTime BuildStartTime { get; set; }
        public int Major { get; set; }
        public int Minor { get; set; }
        public int Build { get; set; }
        public int Revision { get; set; }
        public string Description { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public System.DateTime ChangedTime { get; set; }
    
        public virtual Product T_Product { get; set; }
        public virtual ProductVersion T_ProductVersion { get; set; }
    }
}
