using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingIt.Models
{
    public class Vote
    {
        public int VoteId { get; set; }
        public virtual ApplicationUser voter { get; set; }
        public virtual Song song { get; set; }
    }
}
