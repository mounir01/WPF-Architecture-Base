//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HMS.DataSource
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sport
    {
        public Sport()
        {
            this.Disciplines = new HashSet<Discipline>();
            this.Medalists = new HashSet<Medalist>();
        }
    
        public int SportID { get; set; }
        public string Sport1 { get; set; }
    
        public virtual ICollection<Discipline> Disciplines { get; set; }
        public virtual ICollection<Medalist> Medalists { get; set; }
    }
}
