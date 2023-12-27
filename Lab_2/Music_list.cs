using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Music_list
    {
        private List<Song> musicList = new List<Song>();

        public Music_list() 
        {
            Add("Dave", "Location");
            Add("Dave", "Verdansk");
            Add("JHus", "Militerian");
            Add("Yuong Thug", "On U went");
        }

        // Print list of music songs + authors
        public void PrintList()
        {
            foreach (Song song in musicList)
            {
                song.PrintSong();
            }
        }

        // Add to the music list song + author
        public void Add(string Author, string song)
        {
            if (musicList.SingleOrDefault(x => x.Author == Author && x.Authors_song == song) != null)
            {
                musicList.Add(new Song(Author, song));
            }
            else
            {
                Console.WriteLine("This composition is already in catalog");
            }
            
        }

        // Delete song + autor from music list
        public void Del(string deleteElemenet) 
        {
            string[] element = deleteElemenet.Split('-');
            try
            {   if (element.Length == 2 || element != null)
                {
                    musicList.Remove(musicList.SingleOrDefault(x => x.Author == element[0] && x.Authors_song == element[1]));
                } else
                {
                    Console.WriteLine("Inputed name is invalid");
                }
            } catch (Exception e)
            {
                Console.WriteLine("Inputed name wasn't in catalog");
            }
        }

        // Search songs or authors by input
        public void Search(string name)
        {
            bool noFound = true;
            foreach(Song song in musicList)
            {
                if (name == song.Author || name == song.Authors_song)
                {
                    noFound = false;
                    song.PrintSong();
                }
            }
            if (noFound)
            {
                Console.WriteLine("No items with this name're found in catalog");
            }
        }
    }
}
