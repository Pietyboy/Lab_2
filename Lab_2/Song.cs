using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Song
    {
        public string Author;
        public string Authors_song;
        public Song(string author, string song) 
        {
            Author = author;
            Authors_song = song;
        }

        private string GetAuthor { get; }

        private string GetAuthors_song { get; }

        public void PrintSong()
        {
            Console.WriteLine(Author + " - " + Authors_song);
        }
    }
}
