﻿using Class08_Library;
namespace Class08_Exercise02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            Person person1 = new Person(2156, "Slave", "Pejkov", 18, EnumClass.Hip_Hop);
            Person person2 = new Person(2156, "Marko", "Stojanovski", 24, EnumClass.Classical);
            Person person3 = new Person(2156, "Risto", "Panchevski", 29, EnumClass.Hip_Hop);
            Person person4 = new Person(2156, "John", "Doe", 45, EnumClass.Rock);

            persons.Add(person1);
            persons.Add(person2);
            persons.Add(person3);
            persons.Add(person4);

            //I just copied the songs from the reppo on the github bc it would take me all day making songs :}
            Song song1 = new Song("Bohemian Rhapsody", 367, EnumClass.Rock);
            Song song2 = new Song("Stairway To Heaven", 480, EnumClass.Rock);
            Song song3 = new Song("Riders On The Storm", 430, EnumClass.Rock);
            Song song4 = new Song("Not Fade Away", 108, EnumClass.Rock);
            Song song5 = new Song("Breaking Glass", 111, EnumClass.Rock);
            Song song6 = new Song("Welcome To The Jungle", 275, EnumClass.Rock);
            Song song7 = new Song("Walk Of Life", 266, EnumClass.Rock);
            Song song8 = new Song("Smoke on the Water", 340, EnumClass.Rock);
            Song song9 = new Song("93 'til Infinity", 209, EnumClass.Techno);
            Song song10 = new Song("Fight the Power", 321, EnumClass.Techno);
            Song song11 = new Song("The Message", 363, EnumClass.Techno);
            Song song12 = new Song("Butterfly Effect", 213, EnumClass.Techno);
            Song song13 = new Song("No Fear", 182, EnumClass.Techno);
            Song song14 = new Song("Hereditary", 340, EnumClass.Techno);
            Song song15 = new Song(" Bounce Back", 226, EnumClass.Techno);
            Song song16 = new Song("The Four Seasons", 2520, EnumClass.Classical);
            Song song17 = new Song("Canon in D major", 376, EnumClass.Classical);
            Song song18 = new Song("Swan Lake", 461, EnumClass.Classical);
            Song song19 = new Song("Symphony No. 5", 425, EnumClass.Classical);
            Song song20 = new Song("Ride of the Valkyries", 608, EnumClass.Classical);
            Song song21 = new Song("The Magic Flute", 458, EnumClass.Classical);
            Song song22 = new Song("Carmen Suite No.1", 721, EnumClass.Classical);
            Song song23 = new Song("Planet E", 420, EnumClass.Techno);
            Song song24 = new Song("Phasor", 368, EnumClass.Techno);
            Song song25 = new Song("Counting Comets", 242, EnumClass.Techno);
            Song song26 = new Song("Cold Summer", 358, EnumClass.Techno);
            Song song27 = new Song("Destroyer", 359, EnumClass.Techno);
            Song song28 = new Song("Phalanx", 307, EnumClass.Techno);
            Song song29 = new Song("Vision", 693, EnumClass.Techno);
            Song song30 = new Song("Chain Reaction", 181, EnumClass.Techno);
            Song song31 = new Song("", 181, EnumClass.Techno);


            List<Song> songs = new List<Song>() { song1, song2, song3, song4, song5, song6, song7,
                                                song8, song9, song10, song11, song12, song13, song14,
                                                song15, song16, song17, song18, song19, song20,
                                                song21, song22, song23, song24, song25, song26, song27, song28, song29, song30, song31 
            };


            person1.FavouriteSong = songs.Where(x => x.Title.StartsWith("B")).ToList();
            person2.FavouriteSong = songs.Where(x => x.Length > 360).ToList();
            person3.FavouriteSong = songs.Where(x => x.Genre == EnumClass.Rock).ToList();
            person4.FavouriteSong = songs.Where(x => x.Genre == EnumClass.Hip_Hop && x.Length < 180).ToList();




            List<Person> filteredList = persons.Where(x => x.FavouriteSong.Count >= 4).ToList();

            filteredList.ForEach(x =>
            {
                Console.WriteLine($"-------{x.FirstName} {x.LastName}------");

                

                x.FavouriteSong.ForEach(y => Console.WriteLine(y.Title));

                
            });
        }
    }
}