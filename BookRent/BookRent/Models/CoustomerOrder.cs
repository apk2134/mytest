//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookRent.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CoustomerOrder
    {
        public string OrderId { get; set; }
        public string CoustomerId { get; set; }
        public System.DateTime OrderDate { get; set; }
    
        public virtual CoustomerDetail CoustomerDetail { get; set; }
    }
}
