using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingIt.Models
{
    /// <summary>
    /// A song has 1 User
    /// 1 user can have many songs
    /// 1 song has many votes
    /// 
    /// Title
    /// Singer
    /// Votes
    /// </summary>
    public class Song
    {

        public int SongId { get; set; }
        public virtual ApplicationUser singer { get; set; }
        public virtual ICollection<Vote> votes { get; set; }
        public string Title { get; set; }
        

    }
}
