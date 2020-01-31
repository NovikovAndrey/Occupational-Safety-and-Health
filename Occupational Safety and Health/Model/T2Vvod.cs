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
    
    public partial class T2Vvod
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T2Vvod()
        {
            this.UserAccesses = new HashSet<UserAccess>();
            this.UsersMOes = new HashSet<UsersMO>();
            this.UsersOTs = new HashSet<UsersOT>();
            this.UsersSIZs = new HashSet<UsersSIZ>();
            this.UsersTemplates = new HashSet<UsersTemplate>();
            this.UsersViolations = new HashSet<UsersViolation>();
            this.UserTemplateHistories = new HashSet<UserTemplateHistory>();
        }
    
        public int Id { get; set; }
        public int KodPred { get; set; }
        public int KodOtdel { get; set; }
        public int TabNomer { get; set; }
        public string FIO { get; set; }
        public int KodDolj { get; set; }
    
        public virtual Photo Photo { get; set; }
        public virtual T2Dolj T2Dolj { get; set; }
        public virtual T2Otdel T2Otdel { get; set; }
        public virtual Сompany Сompany { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserAccess> UserAccesses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsersMO> UsersMOes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsersOT> UsersOTs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsersSIZ> UsersSIZs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsersTemplate> UsersTemplates { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsersViolation> UsersViolations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserTemplateHistory> UserTemplateHistories { get; set; }
    }
}
