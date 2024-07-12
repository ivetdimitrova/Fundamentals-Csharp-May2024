﻿namespace _03.Songs
{
    class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }

        public string Time { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 1; i <= count; i++)
            {
                string[] data = Console.ReadLine().Split("_").ToArray();

                string typeList = data[0];
                string name = data[1];
                string time = data[2];

                Song song = new Song();
                song.TypeList =typeList;
                song.Name =name;
                song.Time =time;
            }

            string favoriteList = Console.ReadLine();

            if (favoriteList == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in songs)
                {
                    if (song.TypeList == favoriteList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }
}
