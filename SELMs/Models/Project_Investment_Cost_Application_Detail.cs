//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SELMs.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Project_Investment_Cost_Application_Detail
    {
        public int application_detail_id { get; set; }
        public int application_id { get; set; }
        public string explaination { get; set; }
        public Nullable<decimal> amount { get; set; }
        public string notes { get; set; }
    
        public virtual Project_Investment_Cost_Application Project_Investment_Cost_Application { get; set; }
    }
}
