using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicHW.Models
{
    public class Song : Entity
    {
        public Guid SingerId { get; set; }
        public string NameSong { get; set; }
        public Description DescriptionSong { get; set; }
    }
}
