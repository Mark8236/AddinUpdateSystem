using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AddinUpdateSystem.Models
{
    public class ProductInfo
    {
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
    }
}
