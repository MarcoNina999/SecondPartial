//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sistemacompra.modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Buy_Detail
    {
        public int id_bd { get; set; }
        public string amount_bd { get; set; }
        public string price { get; set; }
        public string sub_total { get; set; }
        public int Product_id_prod { get; set; }
        public int Buy_id_buy { get; set; }
    
        public virtual Buy Buy { get; set; }
        public virtual Product Product { get; set; }
    }
}
