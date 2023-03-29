namespace Class08_Library
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public EnumClass FavouriteMusicType { get; set; }
        public List<Song> FavouriteSong { get; set; }

        public Person(int id, string firstName, string lastName, int age, EnumClass favouriteMusicType)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            FavouriteMusicType = favouriteMusicType;
            FavouriteSong = new List<Song>();
            
        }

        public void GetFavSong() 
        {
            if (FavouriteSong == null || FavouriteSong.Count == 0)
            {
                Console.WriteLine("This person hates music");
            }
            else
            {
                Console.WriteLine($"{FirstName} favourite songs are:");
                foreach (Song song in FavouriteSong)
                {
                    Console.WriteLine(song.Title);
                    
                }
            }
        }
    }
}
