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
    
    public partial class item
    {
        public item()
        {
            this.devolucaos = new HashSet<devolucao>();
        }
    
        public decimal numero { get; set; }
        public decimal quantidade { get; set; }
        public decimal desconto { get; set; }
        public string descricao { get; set; }
        public Nullable<int> produto_sku { get; set; }
        public string factura_codigo { get; set; }
    
        public virtual ICollection<devolucao> devolucaos { get; set; }
        public virtual factura factura { get; set; }
        public virtual produto produto { get; set; }
    }
}
