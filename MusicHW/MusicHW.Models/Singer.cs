using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicHW.Models
{
    public class Singer : Entity
    {
        public string NameSinger { get; set; }
        public ICollection<Song> Songs { get; set; }
    }
}
