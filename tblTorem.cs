//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dal
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblTorem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblTorem()
        {
            this.tashlumTbl = new HashSet<tashlumTbl>();
        }
    
        public int idTorem { get; set; }
        public string nameTorem { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string tel { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string hakdasha { get; set; }
        public Nullable<int> idSug { get; set; }
        public string nameStudent { get; set; }
        public Nullable<int> idStudent { get; set; }
    
        public virtual hakdashaTbl hakdashaTbl { get; set; }
        public virtual studentTbl studentTbl { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tashlumTbl> tashlumTbl { get; set; }
        public virtual tashlumTbl1 tashlumTbl1 { get; set; }
    }
}
