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
    
    public partial class TaskAssignment
    {
        public int assignment_id { get; set; }
        public Nullable<int> task_id { get; set; }
        public Nullable<int> user_id { get; set; }
        public Nullable<System.DateTime> assigned_at { get; set; }
    }
}
