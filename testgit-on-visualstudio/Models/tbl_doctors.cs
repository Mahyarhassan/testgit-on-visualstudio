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
    
    public partial class tbl_doctors
    {
        public int pkID { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public int fkskills { get; set; }
    
        public virtual tbl_doctors tbl_doctors1 { get; set; }
        public virtual tbl_doctors tbl_doctors2 { get; set; }
    }
}
