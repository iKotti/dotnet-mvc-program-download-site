//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AuraDownload.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class comment
    {
        public int program_id { get; set; }
        public int user_id { get; set; }
        public string comment_content { get; set; }
        public System.DateTime comment_time { get; set; }
        public int comment_id { get; set; }
    
        public virtual program program { get; set; }
        public virtual user user { get; set; }
    }
}