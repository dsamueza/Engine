//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mardis.Engine.DataAccess.MardisCore
{
    [Table("FilterTable", Schema = "MardisCore")]
    public partial class FilterTable : IEntity
    {
       
        public FilterTable()
        {
            this.FilterFields = new HashSet<FilterField>();
        }

        [Key]
        public System.Guid Id { get; set; }
        public System.Guid IdFilterController { get; set; }
        public string Description { get; set; }
        public string TableRelation { get; set; }
        public string FieldMainTable { get; set; }
        public string FieldRelationTable { get; set; }
        public string Visible { get; set; }
        public string HasRelation { get; set; }
        public string TableInitial { get; set; }
        public string HasStatus { get; set; }
        public string HasAccount { get; set; }

        public virtual ICollection<FilterField> FilterFields { get; set; }
    }
}