﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_2.Entities
{
    internal class Playlist
    {
        public Guid Id { get; set; }
        private List<Song> Songs { get; set; }
        private Random random;
        public Playlist(Song firstSong)
        {
            Id = Guid.NewGuid();
            Songs = new List<Song>();
            random = new();
            AddSong(firstSong);
        }
        public void AddSong(Song song)
        {
            if (song != null)
                Songs.Add(song);
        }
        public string GetSongs()
        {
            return string.Join("\n", Songs.Select(song => $"{song.Title} - {song.Composer}"));
        }


        public void ShuffleSongs()
        {
            int songCount = Songs.Count; //6

            while (songCount > 0)
            {
                songCount--;//5

                Song song = Songs[songCount]; //F

                int randomIndex = random.Next(songCount);// next value, 0-4

                Songs[songCount] = Songs[randomIndex]; //C

                Songs[randomIndex] = song; //2:F
            }

        }
    }
}
