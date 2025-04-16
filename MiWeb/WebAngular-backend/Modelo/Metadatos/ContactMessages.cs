using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Modelos
{
    [MetadataType(typeof(ContactMessagesMetadato))]
    public partial class ContactMessages
    {
    }

    public class ContactMessagesMetadato
    {

        [Required]
        [StringLength(50)]
        public string name { get; set; }
        [Required]
        [StringLength(50)]
        [EmailAddress]
        public string email { get; set; }
        [Required]
        [StringLength(50)]
        public string subject { get; set; }
        [Required]
        public string messageText { get; set; }
        [Required]
        public long contactId { get; set; }
    }
}
