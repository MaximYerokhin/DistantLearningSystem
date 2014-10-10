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
    
    public partial class Lecturer
    {
        public Lecturer()
        {
            this.StudentGroups = new HashSet<StudentGroup>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Faculty { get; set; }
        public int DepartmentId { get; set; }
        public string Position { get; set; }
        public string LastName { get; set; }
        public string ImgSrc { get; set; }
        public System.DateTime LastVisitDate { get; set; }
        public int Activation { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual ICollection<StudentGroup> StudentGroups { get; set; }
    }
}
