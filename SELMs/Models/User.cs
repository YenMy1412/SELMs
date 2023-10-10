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
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.Project_Member = new HashSet<Project_Member>();
        }
    
        public int user_id { get; set; }
        public string member_code { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string fullname { get; set; }
        public string position_code { get; set; }
        public Nullable<bool> is_admin { get; set; }
        public Nullable<System.DateTime> date_of_birth { get; set; }
        public string hotline { get; set; }
        public string email { get; set; }
        public Nullable<bool> gender { get; set; }
        public string address { get; set; }
        public string avatar { get; set; }
        public Nullable<System.DateTime> hire_date { get; set; }
        public Nullable<System.DateTime> resignation_date { get; set; }
        public string work_term { get; set; }
        public string skill { get; set; }
        public string job_description { get; set; }
        public bool active { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Project_Member> Project_Member { get; set; }
    }
}
