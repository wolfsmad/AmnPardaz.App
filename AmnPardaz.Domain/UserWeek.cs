//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AmnPardaz.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserWeek
    {
        public int UWID { get; set; }
        public int UserId { get; set; }
        public int DayId { get; set; }
        public int CourseId { get; set; }
        public int TimeId { get; set; }
    
        public virtual Cours Cours { get; set; }
        public virtual DayWeek DayWeek { get; set; }
        public virtual Time Time { get; set; }
        public virtual User User { get; set; }
    }
}