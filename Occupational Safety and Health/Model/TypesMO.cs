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
    
    public partial class TypesMO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TypesMO()
        {
            this.UsersMOes = new HashSet<UsersMO>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public int Period { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsersMO> UsersMOes { get; set; }
    }
}
