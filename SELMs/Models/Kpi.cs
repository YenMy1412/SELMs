//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP_QLBH_BQD.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kpi
    {
        public int kpi_id { get; set; }
        public string member_code { get; set; }
        public Nullable<int> expected_working_days { get; set; }
        public Nullable<int> actual_working_days { get; set; }
        public Nullable<int> expected_task_amount { get; set; }
        public Nullable<int> actual_task_amount { get; set; }
        public Nullable<int> month { get; set; }
        public Nullable<int> year { get; set; }
        public string evaluation_manager { get; set; }
        public Nullable<System.DateTime> evaluation_date { get; set; }
    }
}
