//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectCrudOperations.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AddSheet
    {
        public int id { get; set; }
        public string projectName { get; set; }
        public Nullable<System.DateTime> hours { get; set; }
        public Nullable<bool> approval { get; set; }
    }
}