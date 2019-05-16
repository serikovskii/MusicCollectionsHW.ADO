using MusicHW.DataAccess;
using MusicHW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicHW
{
    public class Service
    {
        public void AddMusicCollection(string nameSinger, string nameSong, string duration, int rating, string text)
        {
            using (var context = new MusicContext())

            {
                var singers = new List<Singer>
                {
                    new Singer
                    {
                        NameSinger = nameSinger,
                        Songs = new List<Song>
                        {
                            new Song
                            {
                                NameSong = nameSong,
                                DescriptionSong = new Description
                                {
                                    Duration = duration,
                                    Rating = rating,
                                    Text = text
                                }
                            }
                        }
                    }
                };

                context.Singers.AddRange(singers);
                context.SaveChanges();
            }
        }

        public void SearchForSinger(string nameSinger)
        {
            using(var context = new MusicContext())
            {
                var searchSinger = context.Singers.Where(s => s.NameSinger.Contains(nameSinger)).FirstOrDefault();
                var singerSongs = context.Songs.Where(s => s.SingerId == searchSinger.Id).ToList();

                foreach(var songs in singerSongs)
                {
                    Console.WriteLine(songs.NameSong);
                }
            }
        }

        public void SearchForRatings(int rating)
        {
            using(var context = new MusicContext())
            {
                var singerSongs = context.Songs.Where(s => s.DescriptionSong.Rating == rating).ToList();

                foreach(var songs in singerSongs)
                {
                    Console.WriteLine(songs.NameSong);
                }
            }
        }
    }
}
