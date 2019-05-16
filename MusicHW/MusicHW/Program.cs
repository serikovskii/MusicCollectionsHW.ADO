using MusicHW.DataAccess;
using MusicHW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicHW
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new Service();
            var nameSinger = "";
            var nameSong = "";
            var duration = "";
            var text = "";
            var rating = 0;
            var choice = 0;

            if(choice == 1)
            {
                nameSinger = Console.ReadLine();
                nameSong = Console.ReadLine();
                duration = Console.ReadLine();
                rating = Int32.Parse(Console.ReadLine());
                text = Console.ReadLine();

                if (nameSinger.Length > 1 && nameSong.Length > 1)
                {
                    service.AddMusicCollection(nameSinger, nameSong, duration, rating, text);
                }
            }
            else
            {
                service.SearchForSinger("Muse");
                Console.WriteLine();
                service.SearchForRatings(5);
            }

            Console.ReadLine();

        }
    }
}
