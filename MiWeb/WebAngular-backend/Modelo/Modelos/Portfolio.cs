//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Modelo.Modelos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Portfolio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Portfolio()
        {
            this.PortfolioItems = new HashSet<PortfolioItems>();
        }
    
        public long id { get; set; }
        public string sectionName { get; set; }
        public string title { get; set; }
        public long generalPageId { get; set; }
    
        public virtual GeneralPage GeneralPage { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PortfolioItems> PortfolioItems { get; set; }
    }
}
