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
    
    public partial class studentTbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public studentTbl()
        {
            this.tblTorem = new HashSet<tblTorem>();
        }
    
        public int idStudent { get; set; }
        public string tzStudent { get; set; }
        public string lastName { get; set; }
        public string firstname { get; set; }
        public string connect { get; set; }
        public string kita { get; set; }
        public string madricha { get; set; }
        public string teacher { get; set; }
        public string @class { get; set; }
        public string miun { get; set; }
        public string phone { get; set; }
        public Nullable<int> yaad { get; set; }
        public Nullable<int> untill { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTorem> tblTorem { get; set; }
    }
}