//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace datafirst.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class exceptionlog
    {
        public int logid { get; set; }
        public string exMessage { get; set; }
        public string exType { get; set; }
        public string exSource { get; set; }
        public string exUrl { get; set; }
        public Nullable<System.DateTime> logDate { get; set; }
    }
}
