//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CoMute.Web.Models.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class CarpoolsTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CarpoolsTable()
        {
            this.CarpoolsJoineds = new HashSet<CarpoolsJoined>();
        }
    
        public int CarpoolID { get; set; }
        public int OwnerID { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string DaysAvailable { get; set; }
        public int AvailableSeats { get; set; }
        public System.TimeSpan DepartureTime { get; set; }
        public System.TimeSpan ExpectedTime { get; set; }
        public string Notes { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CarpoolsJoined> CarpoolsJoineds { get; set; }
        public virtual UsersList UsersList { get; set; }
    }
}
