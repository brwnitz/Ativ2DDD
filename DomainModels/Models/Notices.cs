using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModels.Models
{
    public class Notices : BaseEntity
    {
        public string PublicationDate { get; set; }
        public string Type { get; set; }
        public string EventDate { get; set; }
        public string PubDescription { get; set; }
        public string Category { get; set; }
    }

}
