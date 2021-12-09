using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModels.Models
{
    public class Chat : BaseEntity
    {
        public int ChatId { get; set; }
        public int UserIdReceive { get; set; }
        public int UserIdSend { get; set; }
        public string Message { get; set; }

        public User User { get; set; }
    }
}
