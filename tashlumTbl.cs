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
    
    public partial class tashlumTbl
    {
        public int idTashlum { get; set; }
        public int idTorem { get; set; }
        public Nullable<int> sum { get; set; }
        public Nullable<int> idSug { get; set; }
        public Nullable<int> misTashlum { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<int> sumKolel { get; set; }
        public string name { get; set; }
        public string idAshrai { get; set; }
        public string sugAshrai { get; set; }
        public string numAshrai { get; set; }
        public Nullable<System.DateTime> tokef { get; set; }
        public Nullable<int> cvv { get; set; }
        public Nullable<bool> kabala { get; set; }
        public string nameKabala { get; set; }
    
        public virtual EmzeiTashlum EmzeiTashlum { get; set; }
        public virtual tblTorem tblTorem { get; set; }
    }
}
