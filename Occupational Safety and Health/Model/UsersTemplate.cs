//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Occupational_Safety_and_Health.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class UsersTemplate
    {
        public int Id { get; set; }
        public int TabNomer { get; set; }
        public int ReadyTemplatesId { get; set; }
    
        public virtual ReadyTemplate ReadyTemplate { get; set; }
        public virtual T2Vvod T2Vvod { get; set; }
    }
}
