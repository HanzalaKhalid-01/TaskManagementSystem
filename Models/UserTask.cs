//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TaskManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserTask
    {
        public int task_id { get; set; }
        public Nullable<int> project_id { get; set; }
        public Nullable<int> status_id { get; set; }
        public string task_name { get; set; }
        public string description { get; set; }
        public Nullable<System.DateTime> due_date { get; set; }
        public string priority { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
    }
}
