//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace testgit_on_visualstudio.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_skills
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_skills()
        {
            this.tbl_doctors = new HashSet<tbl_doctors>();
        }
    
        public int pkID { get; set; }
        public string skills { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_doctors> tbl_doctors { get; set; }
    }
}