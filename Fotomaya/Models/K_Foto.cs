//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fotomaya.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class K_Foto
    {
        public int foto_id { get; set; }
        public string foto_uzanti { get; set; }
        public Nullable<int> kullanici_id { get; set; }
    
        public virtual Kullanici Kullanici { get; set; }
    }
}