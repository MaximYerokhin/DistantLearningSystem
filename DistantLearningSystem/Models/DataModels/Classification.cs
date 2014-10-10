//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DistantLearningSystem.Models.DataModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class Classification
    {
        public Classification()
        {
            this.Connections = new HashSet<Connection>();
        }
    
        public int Id { get; set; }
        public string Base { get; set; }
        public int ClassificationTypeId { get; set; }
        public System.DateTime AddedDate { get; set; }
        public Nullable<int> Rating { get; set; }
        public int Status { get; set; }
        public Nullable<int> StudentId { get; set; }
    
        public virtual Student Student { get; set; }
        public virtual ICollection<Connection> Connections { get; set; }
    }
}
