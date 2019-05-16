using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicHW.Models
{
    public class Description : Entity
    {
        public Guid SongId { get; set; }
        public string Text { get; set; }
        public string Duration { get; set; }
        public int Rating { get; set; }
    }
}
