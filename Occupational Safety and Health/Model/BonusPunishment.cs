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
    
    public partial class BonusPunishment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BonusPunishment()
        {
            this.UsersViolations = new HashSet<UsersViolation>();
        }
    
        public int Id { get; set; }
        public int Bonus { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsersViolation> UsersViolations { get; set; }
    }
}
