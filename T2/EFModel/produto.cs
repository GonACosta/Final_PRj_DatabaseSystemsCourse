//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class produto
    {
        public produto()
        {
            this.items = new HashSet<item>();
        }
    
        public int sku { get; set; }
        public decimal preco { get; set; }
        public decimal iva { get; set; }
        public string descricao { get; set; }
    
        public virtual ICollection<item> items { get; set; }
    }
}